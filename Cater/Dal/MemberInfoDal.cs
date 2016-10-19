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
    public class MemberInfoDal
    {
        public List<MemberInfo> GetList(MemberInfo mi)
        {
            string sql = "select mi.*,mti.mtitle " +
                         "from memberinfo mi inner join membertypeinfo mti " +
                         "on mi.MTypeId==mti.MID " +
                         "where mi.MIsDelete=0";

            List<SQLiteParameter> listp = new List<SQLiteParameter>();
            if (!string.IsNullOrEmpty(mi.MName))
            {
                sql += " and mi.mname like @name";
                listp.Add(new SQLiteParameter("@name", "%"+mi.MName+"%"));
            }
            if (!string.IsNullOrEmpty(mi.MPhone))
            {
                sql += " and mi.mname like @phone";
                listp.Add(new SQLiteParameter("@phone", "%" + mi.MPhone + "%"));
            }


            DataTable dt = SqliteHelper.GetList(sql,listp.ToArray());

            List<MemberInfo> list = new List<MemberInfo>();

            foreach (DataRow row in dt.Rows)
            {
                list.Add(new MemberInfo()
                {
                    Mid = Convert.ToInt32(row["mid"]),
                    MMoney = Convert.ToDecimal(row["mmoney"]),
                    MTypeId = Convert.ToInt32(row["mtypeid"]),
                    MPhone = row["mphone"].ToString(),
                    MName = row["mname"].ToString(),
                    TyptTitle = row["mtitle"].ToString()
                });
            }
            return list;
        }

        public int Insert(MemberInfo mi)
        {
            string sql = "insert into memberinfo (mname,mphone,mmoney,mtypeid,misdelete) " +
                         "values" +
                         "(@mname,@mphone,@mmoney,@mtypeid,0)";
            SQLiteParameter[] ps =
            {
                new SQLiteParameter("@mname", mi.MName),
                new SQLiteParameter("@mphone", mi.MPhone),
                new SQLiteParameter("@mmoney", mi.MMoney),
                new SQLiteParameter("@mtypeid", mi.MTypeId),
            };
            return SqliteHelper.ExecuteNonQuery(sql, ps);
        }

        public int Update(MemberInfo mi)
        {
            string sql =
                "update memberinfo set mname=@mname,mphone=@mphone,mmoney=@mmoney,mtypeid=@mtypeid where mid=@mid";
            SQLiteParameter[] ps =
            {
                new SQLiteParameter("@mname", mi.MName),
                new SQLiteParameter("@mphone", mi.MPhone),
                new SQLiteParameter("@mmoney", mi.MMoney),
                new SQLiteParameter("@mtypeid", mi.MTypeId),
                new SQLiteParameter("@mid", mi.Mid),
            };
            return SqliteHelper.ExecuteNonQuery(sql, ps);
        }

        public int DeleteById(int id)
        {
            string sql = "delete from memberinfo where mid=@mid";
            SQLiteParameter ps=new SQLiteParameter("@mid",id);
            return SqliteHelper.ExecuteNonQuery(sql, ps);
        }
    }
}