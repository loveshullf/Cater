using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
namespace Dal
{
    class SqliteHelper
    {
        private static string connStr = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;

        public static DataTable GetList(string sql)
        {
            //创建连接对象
            using (SQLiteConnection conn = new SQLiteConnection(connStr))
            {
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        public static int ExecuteNonQuery(string sql, params SQLiteParameter[] ps)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connStr))
            {
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddRange(ps);
                conn.Open();
                return cmd.ExecuteNonQuery();
            }

        }
    }
}
