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
                //OracleCommand cmd = new OracleCommand("SELECT * FROM NHAN_VIEN", DbUltils.con);
                //OracleDataAdapter oda = new OracleDataAdapter(cmd);
                //DataSet ds = new DataSet();

                //oda.Fill(ds);
                //if (ds.Tables.Count > 0)
                //{
                //    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                //    dataGridView1.ReadOnly = true;
                //}
                OracleCommand cmd = new OracleCommand("SELECT * FROM NHAN_VIEN", DbUltils.con);
                OracleDataAdapter oda = new OracleDataAdapter(cmd);
                DataTable table = new DataTable();

                oda.Fill(table);

                dataGridView1.DataSource = table;
                dataGridView1.ReadOnly = true;
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

        private void buttonChooseUpdate_Click(object sender, EventArgs e)
        {
            UpdateEmp f = new UpdateEmp();
            f.labelID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            f.textBoxName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //f.dateTimePickerDoB.Value = (DateTime)dataGridView1.CurrentRow.Cells[2].Value;
            f.textBoxEmail.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            f.textBoxSalary.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            f.ShowDialog();
        }
    }
}
