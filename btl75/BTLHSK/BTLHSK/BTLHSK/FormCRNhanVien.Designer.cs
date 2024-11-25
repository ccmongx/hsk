namespace BTLHSK
{
    partial class FormCRNhanVien
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
            this.crp_nhanvien = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crp_nhanvien
            // 
            this.crp_nhanvien.ActiveViewIndex = -1;
            this.crp_nhanvien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crp_nhanvien.Cursor = System.Windows.Forms.Cursors.Default;
            this.crp_nhanvien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crp_nhanvien.Location = new System.Drawing.Point(0, 0);
            this.crp_nhanvien.Name = "crp_nhanvien";
            this.crp_nhanvien.Size = new System.Drawing.Size(800, 450);
            this.crp_nhanvien.TabIndex = 0;
            // 
            // FormCRNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crp_nhanvien);
            this.Name = "FormCRNhanVien";
            this.Text = "FormCRNhanVien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormCRNhanVien_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crp_nhanvien;
    }
}