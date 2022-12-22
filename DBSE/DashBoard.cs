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
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void buttonEmpList_Click(object sender, EventArgs e)
        {
            EmpList f = new EmpList();
            if(DbUltils.username != "linh" 
                && DbUltils.username != "nhu" 
                && DbUltils.username != "nhi")
            {
                f.buttonChooseUpdate.Enabled = false;
            }
            f.Show();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }
    }
}
