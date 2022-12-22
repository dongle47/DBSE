using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;

namespace DBSE
{
    class DbUltils
    {
        public static string username;
        public static OracleConnection con;
        public static OracleConnection
        GetDBConnection(string username, string password)
        {
            string connString = "DATA SOURCE=103.104.122.48:59012/xe;" +
                "PERSIST SECURITY INFO=True; USER ID=" + username + 
                "; password=" + password + "; Pooling = False; ";
            OracleConnection conn = new OracleConnection(connString);

            return conn;
        }

        public static void openConnection()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public static void setUsername(string userName)
        {
            username = userName;
        }
    }
}
