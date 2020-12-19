using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;

using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;

using Common;

namespace MySqlDemo.Web.DbService
{
    public static class DbHelper
    {
        public static string ConnectionStr { get; private set; }


        static DbHelper()
        {
            ConnectionStr = ConfigurationManager.ConnectionStrings["MySqlDemo"].ConnectionString;
        }

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionStr);
        }

        public static MySqlCommand GetCmd(MySqlConnection conn, string sql)
        {
            return new MySqlCommand(sql, conn);
        }

        public static DataTable GetTable(string sql)
        {
            DataTable dt = new DataTable();

            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();

                    var cmd = GetCmd(conn, sql);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            catch (Exception e)
            {
                string str = string.Format("sql: {0}", sql);
                CommonLogger.WriteLog(
                    ELogCategory.Fatal,
                    string.Format("DbHelper.GetTable Exception: {0}{1}{2}", e.Message, Environment.NewLine, str),
                    e
                );
            }

            return dt;
        }
    }
}