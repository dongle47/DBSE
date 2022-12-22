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
            if(DbUltils.username == "dat" || 
                DbUltils.username == "hai" || 
                DbUltils.username == "tuan")
            {
                textBoxSalary.Enabled = false;
            }

            int id = Int32.Parse(labelID.Text);
            int pbId = Int32.Parse(labelPbID.Text);
            if (pbId == 1 && (DbUltils.username == "nhu" || DbUltils.username == "nhi" || id == 44))
            {
                textBoxSalary.Enabled = false;
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(labelID.Text);
            DateTime birth = dateTimePickerDoB.Value;
            string mail = textBoxEmail.Text;
            string name = textBoxName.Text;
            string salary = textBoxSalary.Text;

            int pbId = Int32.Parse(labelPbID.Text);

            string newDateString = birth.ToString("dd-MMM-yy");

            if (DbUltils.username == "dat" ||
                DbUltils.username == "hai" ||
                DbUltils.username == "tuan")
            {
                salary = "0";
            }

            if(pbId == 1 && (DbUltils.username == "nhu" || DbUltils.username == "nhi" || id == 44))
            {
                salary = "0";
            }

            string connString = "UPDATE hr.nhan_vien SET ten_nv = '" + name +
                "', ngay_sinh = '" + newDateString + 
                "', email = '" + mail + 
                "', luong = " + salary + " WHERE NV_ID = " + id.ToString() ;

            MessageBox.Show(connString);

            //OracleCommand command = new OracleCommand("UPDATE hr.nhan_vien SET ten_nv = @name, " +
            //    "ngay_sinh = @birth, email = @mail, luong = @salary  WHERE NV_ID = @id;", DbUltils.con);

            OracleCommand command = new OracleCommand(connString, DbUltils.con);
            //command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            //command.Parameters.Add("@mail", SqlDbType.NVarChar).Value = mail;
            //command.Parameters.Add("@birth", SqlDbType.DateTime).Value = birth;
            //command.Parameters.Add("@salary", SqlDbType.Int).Value = salary;
            //command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            DbUltils.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                //mydb.closeConnection();
                //return true;
                MessageBox.Show("Cập nhật thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //mydb.closeConnection();
                //return false;
                MessageBox.Show("Không có quyền chỉnh sửa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
