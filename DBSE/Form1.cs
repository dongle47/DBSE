//using System.Data.OracleClient;
using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBSE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPass.Text;

            DbUltils.con = DbUltils.GetDBConnection(username, password);

            //OracleConnection con = DbUltils.GetDBConnection(id, username, password);

            OracleCommand cmd = new OracleCommand("SELECT * FROM user_users", DbUltils.con);
            OracleDataAdapter oda = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            try
            {
                oda.Fill(ds);
                if (ds.Tables.Count > 0)
                {
                    DashBoard f = new DashBoard();
                    f.Show();
                    f.Closed += (s, args) => this.Close();
                    this.Hide();
                }
            }
            catch(Exception E)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
