namespace BTL_HSK
{
    partial class LocGiaKhoang
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
            this.btnIn2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGiadau = new System.Windows.Forms.TextBox();
            this.txtGiacuoi = new System.Windows.Forms.TextBox();
            this.crystalReportViewer2 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.hang = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIn2
            // 
            this.btnIn2.Location = new System.Drawing.Point(148, 56);
            this.btnIn2.Name = "btnIn2";
            this.btnIn2.Size = new System.Drawing.Size(75, 23);
            this.btnIn2.TabIndex = 4;
            this.btnIn2.Text = "In";
            this.btnIn2.UseVisualStyleBackColor = true;
            this.btnIn2.Click += new System.EventHandler(this.btnIn2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Giá đầu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(557, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Giá cuối";
            // 
            // txtGiadau
            // 
            this.txtGiadau.Location = new System.Drawing.Point(404, 54);
            this.txtGiadau.Name = "txtGiadau";
            this.txtGiadau.Size = new System.Drawing.Size(100, 22);
            this.txtGiadau.TabIndex = 7;
            // 
            // txtGiacuoi
            // 
            this.txtGiacuoi.Location = new System.Drawing.Point(650, 53);
            this.txtGiacuoi.Name = "txtGiacuoi";
            this.txtGiacuoi.Size = new System.Drawing.Size(100, 22);
            this.txtGiacuoi.TabIndex = 8;
            // 
            // crystalReportViewer2
            // 
            this.crystalReportViewer2.ActiveViewIndex = -1;
            this.crystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer2.Location = new System.Drawing.Point(12, 104);
            this.crystalReportViewer2.Name = "crystalReportViewer2";
            this.crystalReportViewer2.Size = new System.Drawing.Size(1411, 662);
            this.crystalReportViewer2.TabIndex = 9;
            this.crystalReportViewer2.Load += new System.EventHandler(this.crystalReportViewer2_Load);
            // 
            // hang
            // 
            this.hang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hang.FormattingEnabled = true;
            this.hang.Location = new System.Drawing.Point(933, 53);
            this.hang.Name = "hang";
            this.hang.Size = new System.Drawing.Size(121, 24);
            this.hang.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(805, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Hãng điện thoại";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1435, 809);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.hang);
            this.Controls.Add(this.crystalReportViewer2);
            this.Controls.Add(this.txtGiacuoi);
            this.Controls.Add(this.txtGiadau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnIn2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnIn2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGiadau;
        private System.Windows.Forms.TextBox txtGiacuoi;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer2;
        private System.Windows.Forms.ComboBox hang;
        private System.Windows.Forms.Label label4;
    }
}