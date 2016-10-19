using System.Configuration;
using System.Data;
using System.Data.SQLite;

namespace Dal
{
    internal class SqliteHelper
    {
        private static readonly string connStr = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;

        public static DataTable GetList(string sql, params SQLiteParameter[] ps)
        {
            //创建连接对象
            using (var conn = new SQLiteConnection(connStr))
            {
                var adapter = new SQLiteDataAdapter(sql, conn);
                adapter.SelectCommand.Parameters.AddRange(ps);
                var dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public static int ExecuteNonQuery(string sql, params SQLiteParameter[] ps)
        {
            using (var conn = new SQLiteConnection(connStr))
            {
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddRange(ps);
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }
    }
}