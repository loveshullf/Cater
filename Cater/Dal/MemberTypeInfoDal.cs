using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using Model;

namespace Dal
{
    public class MemberTypeInfoDal
    {
        public List<MemberTypeInfo> GetList()
        {
            var sql = "select * from membertypeinfo where misdelete = 0 ";
            var dt = SqliteHelper.GetList(sql);
            var list = new List<MemberTypeInfo>();

            foreach (DataRow row in dt.Rows)
                list.Add(new MemberTypeInfo
                {
                    Mid = Convert.ToInt32(row["mid"]),
                    MTitle = row["mtitle"].ToString(),
                    MDiscount = Convert.ToDecimal(row["mdiscount"])
                });
            return list;
        }

        public int Insert(MemberTypeInfo mti)
        {
            var sql = "insert into membertypeinfo (mtitle,mdiscount,misDelete) values (@title,@discount,0)";
            SQLiteParameter[] ps =
            {
                new SQLiteParameter("@title", mti.MTitle),
                new SQLiteParameter("@discount", mti.MDiscount)
            };
            return SqliteHelper.ExecuteNonQuery(sql, ps);
        }

        public int Update(MemberTypeInfo mti)
        {
            var sql = "update membertypeinfo set mtitle=@mtitle,mdiscount=@mdiscount where mid=@mid";
            SQLiteParameter[] ps =
            {
                new SQLiteParameter("@mtitle", mti.MTitle),
                new SQLiteParameter("@mdiscount", mti.MDiscount),
                new SQLiteParameter("@mid", mti.Mid)
            };
            return SqliteHelper.ExecuteNonQuery(sql, ps);
        }

        public int Delete(int id)
        {
            string sql = "update membertypeinfo set misdelete=1 where mid=@id";
            SQLiteParameter p=new SQLiteParameter("@id",id);
            return SqliteHelper.ExecuteNonQuery(sql, p);
        }
    }
}