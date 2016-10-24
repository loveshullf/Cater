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
    public class DishInfoDal
    {
        public List<DishInfo> GetList(DishInfo di)
        {
            List<DishInfo> list = new List<DishInfo>();
            string sql = "select di.*,dti.dtitle as typetitle from dishinfo di" +
                         " inner join dishtypeinfo dti on" +
                         " di.dtypeid=dti.did" +
                         " where di.disdelete=0";
            //条件 title id char
            List<SQLiteParameter> listp = new List<SQLiteParameter>();
            if (!string.IsNullOrEmpty(di.DTitle))
            {
                sql += " and di.dtitle like @dtitle";
                listp.Add(new SQLiteParameter("@dtitle", "%" + di.DTitle + "%"));
            }
            if (di.DTypeId > 0)
            {
                sql += " and di.dtypeid=@dtypeid";
                listp.Add(new SQLiteParameter("@dtypeid", di.DTypeId));
            }
            if (!string.IsNullOrEmpty(di.DChar))
            {
                sql += " and di.dchar like @dchar";
                listp.Add(new SQLiteParameter("@dchar","%"+di.DChar+"%"));

            }
            sql += " order by di.did desc";
            DataTable dt = SqliteHelper.GetList(sql, listp.ToArray());
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new DishInfo()
                {
                    DTitle = row["dtitle"].ToString(),
                    DChar = row["dchar"].ToString(),
                    DPrice = Convert.ToDecimal(row["dprice"]),
                    DTypeId = Convert.ToInt32(row["dtypeid"]),
                    Did = Convert.ToInt32(row["did"]),
                    TypeTitle = row["typetitle"].ToString()
                });
            }
            return list;
        }

        public int Delete(int id)
        {
            string sql = "update dishinfo set disdelete=1 where did=@did";

            SQLiteParameter ps = new SQLiteParameter("@did", id);

            return SqliteHelper.ExecuteNonQuery(sql, ps);
        }

        public int Insert(DishInfo di)
        {
            string sql = "insert into dishinfo(dtitle,dprice,dtypeid,dchar,disdelete) values " +
                         "(@dtitle,@dprice,@dtypeid,@dchar,0)";
            SQLiteParameter[] ps =
            {
                new SQLiteParameter("@dtitle", di.DTitle),
                new SQLiteParameter("@dprice", di.DPrice),
                new SQLiteParameter("@dtypeid", di.DTypeId),
                new SQLiteParameter("@dchar", di.DChar)
            };
            return SqliteHelper.ExecuteNonQuery(sql, ps);
        }

        public int Update(DishInfo di)
        {
            string sql =
                "update dishinfo set dtitle=@dtitle,dprice=@dprice,dtypeid=@dtypeid,dchar=@dchar where did=@did";

            SQLiteParameter[] ps =
            {
                new SQLiteParameter("@dtitle", di.DTitle),
                new SQLiteParameter("@dprice", di.DPrice),
                new SQLiteParameter("@dtypeid", di.DTypeId),
                new SQLiteParameter("@dchar", di.DChar),
                new SQLiteParameter("@did", di.Did),
            };
            return SqliteHelper.ExecuteNonQuery(sql, ps);
        }
    }
}