using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Dal
{
    public class TableInfoDal
    {
        public List<TableInfo> GetList(TableInfo ti)
        {
            List<TableInfo> list = new List<TableInfo>();
            string sql = "select ti.*,hi.htitle as halltitle from tableinfo ti" +
                         " inner join hallinfo hi" +
                         " on ti.thallid=hi.hid" +
                         " where ti.tisdelete=0";
            List<SQLiteParameter> listP = new List<SQLiteParameter>();
            if (ti.THallId > -1)
            {
                sql += " and ti.thallid=@thallid";
                listP.Add(new SQLiteParameter("@thallid", ti.THallId));
            }
            if (ti.IsFreeSearch > -1)
            {
                sql += " and ti.tisfree=@tisfree";
                listP.Add(new SQLiteParameter("@tisfree", ti.IsFreeSearch));
            }

            DataTable dt = SqliteHelper.GetList(sql, listP.ToArray());

            foreach (DataRow row in dt.Rows)
            {
                list.Add(new TableInfo()
                {
                    TId = Convert.ToInt32(row["tid"]),
                    TTitle = row["ttitle"].ToString(),
                    TIsFree = Convert.ToBoolean(row["tisfree"]),
                    HallTitle = row["halltitle"].ToString(),
                });
            }
            return list;
        }

        public int Update(TableInfo ti)
        {
            string sql = "update tableinfo set ttitle=@ttitle,thallid=@thallid,tisfree=@tisfree where tid=@tid";
            SQLiteParameter[] ps =
            {
                new SQLiteParameter("@ttitle", ti.TTitle),
                new SQLiteParameter("@thallid", ti.THallId),
                new SQLiteParameter("@tisfree", ti.TIsFree),
                new SQLiteParameter("@tid", ti.TId),
            };
            return SqliteHelper.ExecuteNonQuery(sql, ps);
        }

        public int Insert(TableInfo ti)
        {
            string sql = "insert into tableinfo (ttitle,thallid,tisfree,tisdelete) values (@ttitle,@thallid,@tisfree,0)";
            SQLiteParameter[] ps =
            {
                new SQLiteParameter("@ttitle", ti.TTitle),
                new SQLiteParameter("@thallid", ti.THallId),
                new SQLiteParameter("@tisfree", ti.TIsFree),
            };
            return SqliteHelper.ExecuteNonQuery(sql, ps);
        }

        public int Delete(int id)
        {
            string sql = "update tableinfo set tisdelete=1 where tid=@tid";
            SQLiteParameter p=new SQLiteParameter("@tid",id);
            return SqliteHelper.ExecuteNonQuery(sql, p);
        }
    }
}