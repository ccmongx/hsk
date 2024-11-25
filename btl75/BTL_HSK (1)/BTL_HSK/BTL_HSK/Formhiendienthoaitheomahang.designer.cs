
namespace BTL_HSK
{
    partial class Formhiendienthoaitheomahang
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
            this.In = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtiMahangDT = new System.Windows.Forms.TextBox();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // In
            // 
            this.In.Location = new System.Drawing.Point(13, 3);
            this.In.Name = "In";
            this.In.Size = new System.Drawing.Size(75, 23);
            this.In.TabIndex = 0;
            this.In.Text = "In";
            this.In.UseVisualStyleBackColor = true;
            this.In.Click += new System.EventHandler(this.In_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên hãng";
            // 
            // txtiMahangDT
            // 
            this.txtiMahangDT.Location = new System.Drawing.Point(243, 4);
            this.txtiMahangDT.Name = "txtiMahangDT";
            this.txtiMahangDT.Size = new System.Drawing.Size(114, 22);
            this.txtiMahangDT.TabIndex = 2;
            this.txtiMahangDT.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(3, 32);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1242, 461);
            this.crystalReportViewer1.TabIndex = 3;
            // 
            // Formhiendienthoaitheomahang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 490);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.txtiMahangDT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.In);
            this.Name = "Formhiendienthoaitheomahang";
            this.Text = "Formhiendienthoaitheomahang";
            this.Load += new System.EventHandler(this.Formhiendienthoaitheomahang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button In;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtiMahangDT;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}