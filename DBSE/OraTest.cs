using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBSE
{
    class OraTest
    {
        OracleConnection con;
        void Connect()
        {
            con = new OracleConnection();
            con.ConnectionString = "User Id=hr;Password=fMigBU5hg2vBQ7t;Data Source=xe";
            con.Open();
            Console.WriteLine("Connected to Oracle" + con.ServerVersion);
        }

        void Close()
        {
            con.Close();
            con.Dispose();
        }
    }
}
