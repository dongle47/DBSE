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
using Oracle.DataAccess.Client;

namespace DBSE
{
    public partial class UpdateEmp : Form
    {
        public UpdateEmp()
        {
            InitializeComponent();
        }

        private void UpdateEmp_Load(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string id = labelID.Text;
            DateTime birth = dateTimePickerDoB.Value;
            string mail = textBoxEmail.Text;
            string name = textBoxName.Text;
            string salary = textBoxSalary.Text;

            OracleCommand command = new OracleCommand("EXEC dbo.insert_kh @id, @pass, @name, @phn, @mail, @cmnd, @birth", DbUltils.con);
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            //command.Parameters.Add("@pass", SqlDbType.NVarChar).Value = pass;
            //command.Parameters.Add("@phn", SqlDbType.NVarChar).Value = phone;
            //command.Parameters.Add("@cmnd", SqlDbType.NVarChar).Value = cmnd;
            command.Parameters.Add("@mail", SqlDbType.NVarChar).Value = mail;
            command.Parameters.Add("@birth", SqlDbType.DateTime).Value = birth;
            //mydb.openConnection();
            //if ((command.ExecuteNonQuery() == 1))
            //{
            //    mydb.closeConnection();
            //    return true;
            //}
            //else
            //{
            //    mydb.closeConnection();
            //    return false;
            //}

            //try
            //{
            //    if (kh.update(id, name, phone, mail, cmnd, birth))
            //    {
            //        MessageBox.Show("Đã cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    else
            //    {
            //        MessageBox.Show("Error", "Edit Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Edit Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
        }
    }
}
