using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using Model;

namespace Dal
{
    public class OrderInfoDal
    {
        public int KaiDan(int tableId)
        {
            var sql =
                "insert into orderinfo (odate,oispay,otableid) values (datetime('now','localtime'),0,@otaleid);" +
                "update tableinfo set tisfree = 0 where tid=@otaleid;";
            var p = new SQLiteParameter("@otaleid", tableId);
            return SqliteHelper.ExecuteNonQuery(sql, p);
        }

        public int GetOidByTId(int tableId)
        {
            //查找订单id 未结账，tableid 
            var sql = "select oid from orderinfo where otableid=@tableid and oispay=0";
            var p = new SQLiteParameter("@tableid", tableId);

            return Convert.ToInt32(SqliteHelper.ExecuteScalar(sql, p));
        }

        public int DianCai(int orderid, int dishid)
        {
            //查看是否已有数据
            var sql = "select count(*) from orderdetailinfo where orderid=@orderid and dishid=@dishid";
            SQLiteParameter[] ps1 =
            {
                new SQLiteParameter("@orderid", orderid),
                new SQLiteParameter("@dishid", dishid)
            };
            var count = Convert.ToInt32(SqliteHelper.ExecuteScalar(sql, ps1));
            if (count == 0)
            {
                //当前没有数据 
                sql = "insert into orderdetailinfo (orderid,dishid,count) values (@orderid,@dishid,1)";
                SQLiteParameter[] ps =
                {
                    new SQLiteParameter("@orderid", orderid),
                    new SQLiteParameter("@dishid", dishid)
                };
                return SqliteHelper.ExecuteNonQuery(sql, ps);
            }
            //已有数据，更新数据
            sql = "update orderdetailinfo set count=count+1 where orderid=@orderid and dishid=@dishid";
            return SqliteHelper.ExecuteNonQuery(sql, ps1);
        }

        public decimal GetMoneyByTId(int tablid)
        {
            var sql = "select omoney from orderinfo where otableid=@tableid";
            var p = new SQLiteParameter("@tableid", tablid);

            return Convert.ToDecimal(SqliteHelper.ExecuteScalar(sql, p));
        }

        public List<OrderDetailInfo> GetDetaillist(int orderid)
        {
            var list = new List<OrderDetailInfo>();
            var sql = "select odi.*,di.dtitle,di.dprice from orderdetailinfo odi " +
                      "inner join dishinfo di " +
                      "on odi.dishid=di.did " +
                      "where odi.orderid=@orderid";
            var p = new SQLiteParameter("@orderid", orderid);

            var dt = SqliteHelper.GetList(sql, p);

            foreach (DataRow row in dt.Rows)
                list.Add(new OrderDetailInfo
                {
                    OId = Convert.ToInt32(row["oid"]),
                    OrderId = orderid,
                    DishId = Convert.ToInt32(row["dishid"]),
                    Count = Convert.ToInt32(row["count"]),
                    DishPrice = Convert.ToDecimal(row["dprice"]),
                    DishTitle = row["dtitle"].ToString()
                });

            return list;
        }

        public int UpdateDishCount(int oid, int count)
        {
            var sql = "update orderdetailinfo set count=@count where oid=@oid";
            SQLiteParameter[] ps =
            {
                new SQLiteParameter("@count", count),
                new SQLiteParameter("@oid", oid)
            };
            return SqliteHelper.ExecuteNonQuery(sql, ps);
        }

        public int DeleteDish(int oid)
        {
            var sql = "delete from orderdetailinfo where oid=@oid";
            var p = new SQLiteParameter("@oid", oid);
            return SqliteHelper.ExecuteNonQuery(sql, p);
        }

        public int XiaDan(int orderid, decimal totalmoney)
        {
            var sql = "update orderinfo set omoney=@totalmoney where oid=@orderid";
            SQLiteParameter[] ps =
            {
                new SQLiteParameter("@orderid", orderid),
                new SQLiteParameter("@totalmoney", totalmoney)
            };
            return SqliteHelper.ExecuteNonQuery(sql, ps);
        }

        //结账
        public int JieZhang(int tableid, int memberid, decimal discount, decimal paymoney)
        {
            //事务
            using (
                var conn =
                    new SQLiteConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString))
            {
                conn.Open();
                var tran = conn.BeginTransaction();
                var count = 0;
                try
                {
                    //改订单状态
                    //是会员，记录信息

                    var cmd = new SQLiteCommand();
                    //事务和命令关联起来
                    cmd.Transaction = tran;
                    var sql = "update orderinfo set oispay=1";

                    if (memberid > 0)
                        sql += ",memberid=" + memberid + ",odiscount=" + discount;
                    sql += " where otableid=" + tableid + " and oispay=0";
                    cmd.CommandText = sql;
                    count += cmd.ExecuteNonQuery();
                    //餐桌状态，

                    sql = "update tableinfo set tisfree=1 where tid=" + tableid;
                    cmd.CommandText = sql;
                    count += cmd.ExecuteNonQuery();
                    //使用余额，更新余额
                    if (paymoney > 0)
                    {
                        sql = "update memberinfo set mmoney=mmoney-" + paymoney + " where mid=" + memberid;
                        cmd.CommandText = sql;
                        count += cmd.ExecuteNonQuery();
                    }
                    //状态图片
                    //提交事务
                    tran.Commit();
                }
                catch (Exception)
                {
                    //失败事务回滚
                    count = 0;
                    tran.Rollback();
                }
                return count;
            }
        }
    }
}