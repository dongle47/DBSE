using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;

namespace DBSE
{
    class DbUltils
    {
        public static OracleConnection
        GetDBConnection(string id, string username, string password)
        {
            string connString = "DATA SOURCE=103.104.122.48:59012/xe;" +
                "PERSIST SECURITY INFO=True; USER ID=" + username + 
                "; password=" + password + "; Pooling = False; ";
            OracleConnection conn = new OracleConnection(connString);
            return conn;
        }
    }
}
