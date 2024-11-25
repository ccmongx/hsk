namespace BTH_QLCHDT
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Mn_QLSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.Mn_QLKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.qLNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qLHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mn_QLSanPham,
            this.Mn_QLKhachHang,
            this.qLNhânViênToolStripMenuItem,
            this.qLHóaĐơnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Mn_QLSanPham
            // 
            this.Mn_QLSanPham.Name = "Mn_QLSanPham";
            this.Mn_QLSanPham.Size = new System.Drawing.Size(114, 24);
            this.Mn_QLSanPham.Text = "&QL Sản Phẩm ";
            this.Mn_QLSanPham.Click += new System.EventHandler(this.quảnLýSảnPhẩmToolStripMenuItem_Click);
            // 
            // Mn_QLKhachHang
            // 
            this.Mn_QLKhachHang.Name = "Mn_QLKhachHang";
            this.Mn_QLKhachHang.Size = new System.Drawing.Size(125, 24);
            this.Mn_QLKhachHang.Text = "&QL Khách Hàng";
            this.Mn_QLKhachHang.Click += new System.EventHandler(this.quảnLýKháchHàngToolStripMenuItem_Click);
            // 
            // qLNhânViênToolStripMenuItem
            // 
            this.qLNhânViênToolStripMenuItem.Name = "qLNhânViênToolStripMenuItem";
            this.qLNhânViênToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.qLNhânViênToolStripMenuItem.Text = "&QL Nhân Viên";
            this.qLNhânViênToolStripMenuItem.Click += new System.EventHandler(this.qLNhânViênToolStripMenuItem_Click);
            // 
            // qLHóaĐơnToolStripMenuItem
            // 
            this.qLHóaĐơnToolStripMenuItem.Name = "qLHóaĐơnToolStripMenuItem";
            this.qLHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.qLHóaĐơnToolStripMenuItem.Text = "&QL Hóa Đơn";
            this.qLHóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.qLHóaĐơnToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Quản Lý Cửa Hàng Điện Thoại";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Mn_QLSanPham;
        private System.Windows.Forms.ToolStripMenuItem Mn_QLKhachHang;
        private System.Windows.Forms.ToolStripMenuItem qLNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qLHóaĐơnToolStripMenuItem;
    }
}

