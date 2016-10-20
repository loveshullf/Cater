using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Dal
{
    public class HallInfoDal
    {
        public List<HallInfo> GetList()
        {
            List<HallInfo> list = new List<HallInfo>();
            string sql = "select * from hallinfo where hisdelete=0";

            DataTable dt = SqliteHelper.GetList(sql);
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new HallInfo()
                {
                    HId = Convert.ToInt32(row["hid"]),
                    HTitle = row["htitle"].ToString()
                });
            }
            return list;
        }

        public int Delete(int id)
        {
            string sql = "update hallinfo set hisdelete=1 where hid=@hid";
            SQLiteParameter p = new SQLiteParameter("@hid", id);
            return SqliteHelper.ExecuteNonQuery(sql, p);
        }

        public int Update(HallInfo hi)
        {
            string sql = "update hallinfo set htitle=@htitle where hid=@hid";
            SQLiteParameter[] ps=
            {
                new SQLiteParameter("@htitle",hi.HTitle),
                new SQLiteParameter("@hid",hi.HId),
            };
            return SqliteHelper.ExecuteNonQuery(sql, ps);
        }

        public int Insert(HallInfo hi)
        {
            string sql = "insert into hallinfo(htitle,hisdelete) values(@htitle,0)";

            SQLiteParameter[] ps =
            {
                new SQLiteParameter("@htitle", hi.HTitle), 
            };

            return SqliteHelper.ExecuteNonQuery(sql, ps);
        }
    }
}