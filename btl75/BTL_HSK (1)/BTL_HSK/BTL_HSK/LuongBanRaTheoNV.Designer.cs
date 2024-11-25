namespace BTL_HSK
{
    partial class LuongBanRaTheoNV
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tbNhanvien = new System.Windows.Forms.Label();
            this.cbNhanvien = new System.Windows.Forms.ComboBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(27, 87);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1397, 628);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // tbNhanvien
            // 
            this.tbNhanvien.AutoSize = true;
            this.tbNhanvien.Location = new System.Drawing.Point(27, 48);
            this.tbNhanvien.Name = "tbNhanvien";
            this.tbNhanvien.Size = new System.Drawing.Size(72, 17);
            this.tbNhanvien.TabIndex = 1;
            this.tbNhanvien.Text = "Nhân viên";
            // 
            // cbNhanvien
            // 
            this.cbNhanvien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNhanvien.FormattingEnabled = true;
            this.cbNhanvien.Location = new System.Drawing.Point(127, 45);
            this.cbNhanvien.Name = "cbNhanvien";
            this.cbNhanvien.Size = new System.Drawing.Size(121, 24);
            this.cbNhanvien.TabIndex = 2;
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(315, 46);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(112, 23);
            this.btnIn.TabIndex = 3;
            this.btnIn.Text = "In báo cáo";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // RPTLuongBanRaTheoNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1459, 727);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.cbNhanvien);
            this.Controls.Add(this.tbNhanvien);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "RPTLuongBanRaTheoNV";
            this.Text = "RPTLuongBanRaTheoNV";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Label tbNhanvien;
        private System.Windows.Forms.ComboBox cbNhanvien;
        private System.Windows.Forms.Button btnIn;
    }
}