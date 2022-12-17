using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBSE
{
    public partial class EmpList : Form
    {
        public EmpList()
        {
            InitializeComponent();
        }

        private void EmpList_Load(object sender, EventArgs e)
        {
            try
            {
                string connString = "DATA SOURCE=103.104.122.48:59012/xe;" +
                "PERSIST SECURITY INFO=True; USER ID=hr; password=fMigBU5hg2vBQ7t; Pooling = False; ";
                using (OracleConnection con = new OracleConnection(connString))
                {
                    OracleCommand cmd = new OracleCommand("SELECT * FROM NHAN_VIEN", con);
                    OracleDataAdapter oda = new OracleDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    oda.Fill(ds);
                    if (ds.Tables.Count > 0)
                    {
                        dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    }
                 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            //string connString = "Data Source=XE;User Id=hr;Password=fMigBU5hg2vBQ7t;";
            //OracleConnection conn = new OracleConnection();
            //conn.ConnectionString = connString;
            //conn.Open();
            //MessageBox.Show("im here");
        }
    }
}
