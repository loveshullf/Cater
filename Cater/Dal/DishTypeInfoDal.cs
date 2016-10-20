using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using Model;

namespace Dal
{
    public class DishTypeInfoDal
    {
        public List<DishTypeInfo> GetList()
        {
            var list = new List<DishTypeInfo>();

            var sql = "select * from dishtypeinfo where disdelete=0";
            var dt = SqliteHelper.GetList(sql);
            foreach (DataRow row in dt.Rows)
                list.Add(new DishTypeInfo
                {
                    DId = Convert.ToInt32(row["did"]),
                    DTitle = row["dtitle"].ToString()
                });
            return list;
        }

        public int Insert(DishTypeInfo dti)
        {
            var Sql = "insert into dishtypeinfo(dtitle,disdelete) values (@dtitle,0)";

            var p = new SQLiteParameter("@dtitle", dti.DTitle);
            return SqliteHelper.ExecuteNonQuery(Sql, p);
        }

        public int Update(DishTypeInfo dti)
        {
            var sql = "update dishtypeinfo set dtitle=@dtitle where did=@did";
            SQLiteParameter[] ps =
            {
                new SQLiteParameter("@did", dti.DId),
                new SQLiteParameter("@dtitle", dti.DTitle)
            };
            return SqliteHelper.ExecuteNonQuery(sql, ps);
        }

        public int Delete(int id)
        {
            string sql = "update dishtypeinfo set disdelete=1 where did=@did";
            SQLiteParameter p=new SQLiteParameter("@did",id);
            return SqliteHelper.ExecuteNonQuery(sql, p);

        }
    }
}