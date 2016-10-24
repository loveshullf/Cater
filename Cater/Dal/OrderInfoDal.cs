using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;
using System.Data.SqlClient;

namespace Dal
{
    public class OrderInfoDal
    {
        public int KaiDan(int tableId)
        {
            string sql = "insert into orderinfo (odate,oispay,otableid) values (datetime('now','localtime'),0,@otaleid);"+
                         "update tableinfo set tisfree = 0 where tid=@otaleid;";
            SQLiteParameter p=new SQLiteParameter("@otaleid", tableId);
            return SqliteHelper.ExecuteNonQuery(sql,p);
        }

        public int GetOidByTId(int tableId)
        {
            //查找订单id 未结账，tableid 
            string sql = "select oid from orderinfo where otableid=@tableid and oispay=0";
            SQLiteParameter p=new SQLiteParameter("@tableid",tableId);

            return Convert.ToInt32(SqliteHelper.ExecuteScalar(sql, p));
        }

        public int DianCai(int orderid, int dishid)
        {
            //查看是否已有数据
            string sql = "select count(*) from orderdetailinfo where orderid=@orderid and dishid=@dishid";
            SQLiteParameter[] ps1 =
            {
                new SQLiteParameter("@orderid",orderid),
                new SQLiteParameter("@dishid",dishid),  
            };
            int count = Convert.ToInt32(SqliteHelper.ExecuteScalar(sql, ps1));
            if (count == 0)
            {
                //当前没有数据 
                sql = "insert into orderdetailinfo (orderid,dishid,count) values (@orderid,@dishid,1)";
                SQLiteParameter[] ps =
                {
                new SQLiteParameter("@orderid",orderid),
                new SQLiteParameter("@dishid",dishid),
                };
                return SqliteHelper.ExecuteNonQuery(sql, ps);
            }
            else
            {
                //已有数据，更新数据
                sql = "update orderdetailinfo set count=count+1 where orderid=@orderid and dishid=@dishid";
                return SqliteHelper.ExecuteNonQuery(sql, ps1);
            }
        }
        public List<OrderDetailInfo> GetDetaillist(int orderid)
        {
            List<OrderDetailInfo> list = new List<OrderDetailInfo>();
            string sql = "select odi.*,di.dtitle,di.dprice from orderdetailinfo odi " +
                         "inner join dishinfo di " +
                         "on odi.dishid=di.did " +
                         "where odi.orderid=@orderid";
            SQLiteParameter p = new SQLiteParameter("@orderid", orderid);

            DataTable dt = SqliteHelper.GetList(sql, p);

            foreach (DataRow row in dt.Rows)
            {
                list.Add(new OrderDetailInfo()
                {
                    OId = Convert.ToInt32(row["oid"]),
                    OrderId = orderid,
                    DishId = Convert.ToInt32(row["dishid"]),
                    Count = Convert.ToInt32(row["count"]),
                    DishPrice = Convert.ToDecimal(row["dprice"]),
                    DishTitle = row["dtitle"].ToString(),
                });
            }

            return list;
        }
        public int UpdateDishCount(int oid, int count)
        {
            string sql = "update orderdetailinfo set count=@count where oid=@oid";
            SQLiteParameter[] ps =
            {
                new SQLiteParameter("@count",count),
                new SQLiteParameter("@oid",oid),
            };
            return SqliteHelper.ExecuteNonQuery(sql,ps);
        }

        public int DeleteDish(int oid)
        {
            string sql = "delete from orderdetailinfo where oid=@oid";
            SQLiteParameter p = new SQLiteParameter("@oid", oid);
            return SqliteHelper.ExecuteNonQuery(sql, p);
        }

        public int XiaDan(int orderid,decimal totalmoney)
        {
            string sql = "update orderinfo set omoney=@totalmoney where oid=@orderid";
            SQLiteParameter[] ps =
            {
                new SQLiteParameter("@orderid",orderid),
                new SQLiteParameter("@totalmoney",totalmoney),  
            };
            return SqliteHelper.ExecuteNonQuery(sql, ps);
        }
    }
}
