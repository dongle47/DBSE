
namespace DBSE
{
    partial class DashBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonEmpList = new System.Windows.Forms.Button();
            this.buttonSupervision = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEmpList
            // 
            this.buttonEmpList.Location = new System.Drawing.Point(54, 30);
            this.buttonEmpList.Name = "buttonEmpList";
            this.buttonEmpList.Size = new System.Drawing.Size(167, 35);
            this.buttonEmpList.TabIndex = 0;
            this.buttonEmpList.Text = "Danh sách nhân viên";
            this.buttonEmpList.UseVisualStyleBackColor = true;
            this.buttonEmpList.Click += new System.EventHandler(this.buttonEmpList_Click);
            // 
            // buttonSupervision
            // 
            this.buttonSupervision.Location = new System.Drawing.Point(259, 30);
            this.buttonSupervision.Name = "buttonSupervision";
            this.buttonSupervision.Size = new System.Drawing.Size(167, 35);
            this.buttonSupervision.TabIndex = 1;
            this.buttonSupervision.Text = "Giám sát chỉnh sửa";
            this.buttonSupervision.UseVisualStyleBackColor = true;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(188, 105);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(94, 28);
            this.buttonLogout.TabIndex = 2;
            this.buttonLogout.Text = "Đăng xuất";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 167);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonSupervision);
            this.Controls.Add(this.buttonEmpList);
            this.Name = "DashBoard";
            this.Text = "DashBoard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEmpList;
        private System.Windows.Forms.Button buttonSupervision;
        private System.Windows.Forms.Button buttonLogout;
    }
}