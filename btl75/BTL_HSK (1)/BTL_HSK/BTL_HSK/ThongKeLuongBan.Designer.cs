namespace BTL_HSK
{
    partial class ThongKeLuongBan
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
            this.gvThongke = new System.Windows.Forms.DataGridView();
            this.tbTimkiem = new System.Windows.Forms.TextBox();
            this.lbTimkiem = new System.Windows.Forms.Label();
            this.lbTieude = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvThongke)).BeginInit();
            this.SuspendLayout();
            // 
            // gvThongke
            // 
            this.gvThongke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvThongke.Location = new System.Drawing.Point(68, 106);
            this.gvThongke.Name = "gvThongke";
            this.gvThongke.RowTemplate.Height = 24;
            this.gvThongke.Size = new System.Drawing.Size(721, 398);
            this.gvThongke.TabIndex = 0;
            // 
            // tbTimkiem
            // 
            this.tbTimkiem.Location = new System.Drawing.Point(636, 65);
            this.tbTimkiem.Name = "tbTimkiem";
            this.tbTimkiem.Size = new System.Drawing.Size(153, 22);
            this.tbTimkiem.TabIndex = 1;
            this.tbTimkiem.TextChanged += new System.EventHandler(this.tbTimkiem_TextChanged);
            // 
            // lbTimkiem
            // 
            this.lbTimkiem.AutoSize = true;
            this.lbTimkiem.Location = new System.Drawing.Point(566, 68);
            this.lbTimkiem.Name = "lbTimkiem";
            this.lbTimkiem.Size = new System.Drawing.Size(64, 17);
            this.lbTimkiem.TabIndex = 2;
            this.lbTimkiem.Text = "Tìm kiếm";
            // 
            // lbTieude
            // 
            this.lbTieude.AutoSize = true;
            this.lbTieude.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieude.Location = new System.Drawing.Point(255, 21);
            this.lbTieude.Name = "lbTieude";
            this.lbTieude.Size = new System.Drawing.Size(330, 20);
            this.lbTieude.TabIndex = 3;
            this.lbTieude.Text = "THỐNG KÊ LƯỢNG ĐIỆN THOẠI BÁN RA";
            // 
            // ThongKeLuongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 571);
            this.Controls.Add(this.lbTieude);
            this.Controls.Add(this.lbTimkiem);
            this.Controls.Add(this.tbTimkiem);
            this.Controls.Add(this.gvThongke);
            this.Name = "ThongKeLuongBan";
            this.Text = "Thống kê lượng điện thoại bán ra";
            ((System.ComponentModel.ISupportInitialize)(this.gvThongke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvThongke;
        private System.Windows.Forms.TextBox tbTimkiem;
        private System.Windows.Forms.Label lbTimkiem;
        private System.Windows.Forms.Label lbTieude;
    }
}

