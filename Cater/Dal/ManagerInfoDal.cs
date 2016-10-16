﻿using System.Collections.Generic;
using Model;
using System.Data;
using System;
using Common;
using System.Data.SQLite;
namespace Dal
{
    public class ManagerInfoDal
    {
        public List<ManagerInfo> GetList()
        {
            List<ManagerInfo> list = new List<Model.ManagerInfo>();                                                                                                       
            DataTable dt = SqliteHelper.GetList("select * from managerinfo");
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new ManagerInfo()
                {
                    Mid = Convert.ToInt32(row["mid"]),
                    MName = row["mname"].ToString(),
                    MPwd = row["mpwd"].ToString(),
                    MType = Convert.ToInt32(row["mtype"])
                });
            }
            return list;
        }

        public int DeleteById(int id)
        {
            string sql = "delete from managerinfo where mid=@id";
            SQLiteParameter ps = new SQLiteParameter("@id", id);
            return SqliteHelper.ExecuteNonQuery(sql, ps);
        }
        public int Update(ManagerInfo mi)
        {
            List<SQLiteParameter> list = new List<SQLiteParameter>();

            string sql = "update managerinfo set mname=@name,";
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
            string sql = "insert into managerinfo(mname,mpwd,mtype) values (@name,@pwd,@type) ";
            SQLiteParameter[] ps = 
            {
                new SQLiteParameter("@name",mi.MName),
                new SQLiteParameter("@pwd",MD5Helper.GetMD5(mi.MPwd)),
                new SQLiteParameter("@type",mi.MType)
            };
            return SqliteHelper.ExecuteNonQuery(sql, ps);
        }
    }
}
