using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using Common;
using Model;

namespace Dal
{
    public class ManagerInfoDal
    {
        public List<ManagerInfo> GetList(ManagerInfo mi)
        {
            var list = new List<ManagerInfo>();
            var sql = "select * from managerinfo ";

            var ps = new List<SQLiteParameter>();

            if (mi != null)
            {
                sql += "where mname=@name and mpwd=@pwd";
                ps.Add(new SQLiteParameter("@name", mi.MName));
                ps.Add(new SQLiteParameter("@pwd", MD5Helper.GetMD5(mi.MPwd)));
            }

            var dt = SqliteHelper.GetList(sql, ps.ToArray());


            foreach (DataRow row in dt.Rows)
                list.Add(new ManagerInfo
                {
                    Mid = Convert.ToInt32(row["mid"]),
                    MName = row["mname"].ToString(),
                    MPwd = row["mpwd"].ToString(),
                    MType = Convert.ToInt32(row["mtype"])
                });
            return list;
        }

        public int DeleteById(int id)
        {
            var sql = "delete from managerinfo where mid=@id";
            var ps = new SQLiteParameter("@id", id);
            return SqliteHelper.ExecuteNonQuery(sql, ps);
        }

        public int Update(ManagerInfo mi)
        {
            var list = new List<SQLiteParameter>();

            var sql = "update managerinfo set mname=@name,";
            list.Add(new SQLiteParameter("@name", mi.MName));

            //判断要不要改密码
            if (!mi.MPwd.Equals("******"))
            {
                sql += "mpwd=@pwd,";
                list.Add(new SQLiteParameter("@pwd", MD5Helper.GetMD5(mi.MPwd)));
            }

            sql += "mtype = @type where mid = @id";
            list.Add(new SQLiteParameter("@id", mi.Mid));
            list.Add(new SQLiteParameter("@type", mi.MType));

            return SqliteHelper.ExecuteNonQuery(sql, list.ToArray());
        }

        public int Insert(ManagerInfo mi)
        {
            var sql = "insert into managerinfo(mname,mpwd,mtype) values (@name,@pwd,@type) ";
            SQLiteParameter[] ps =
            {
                new SQLiteParameter("@name", mi.MName),
                new SQLiteParameter("@pwd", MD5Helper.GetMD5(mi.MPwd)),
                new SQLiteParameter("@type", mi.MType)
            };
            return SqliteHelper.ExecuteNonQuery(sql, ps);
        }
    }
}