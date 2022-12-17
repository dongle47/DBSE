
namespace DBSE
{
    partial class EmpList
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonChooseUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(735, 198);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonChooseUpdate
            // 
            this.buttonChooseUpdate.Location = new System.Drawing.Point(285, 235);
            this.buttonChooseUpdate.Name = "buttonChooseUpdate";
            this.buttonChooseUpdate.Size = new System.Drawing.Size(159, 39);
            this.buttonChooseUpdate.TabIndex = 1;
            this.buttonChooseUpdate.Text = "CHỈNH SỬA";
            this.buttonChooseUpdate.UseVisualStyleBackColor = true;
            // 
            // EmpList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 286);
            this.Controls.Add(this.buttonChooseUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EmpList";
            this.Text = "EmpList";
            this.Load += new System.EventHandler(this.EmpList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonChooseUpdate;
    }
}