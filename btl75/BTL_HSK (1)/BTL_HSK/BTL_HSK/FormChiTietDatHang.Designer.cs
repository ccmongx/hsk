
namespace BTL_HSK
{
    partial class FormChiTietDatHang
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inBiểuMẫuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đặtHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chiTiếtĐơnHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.điệnThoạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Them = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtiSoluong = new System.Windows.Forms.TextBox();
            this.Sua = new System.Windows.Forms.Button();
            this.Xoa = new System.Windows.Forms.Button();
            this.TimKiem = new System.Windows.Forms.Button();
            this.cbDienthoai = new System.Windows.Forms.ComboBox();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.cbMaDH = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 243);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(739, 276);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(744, 24);
            this.menuStrip1.TabIndex = 22;
            // 
            // inBiểuMẫuToolStripMenuItem
            // 
            this.inBiểuMẫuToolStripMenuItem.Name = "inBiểuMẫuToolStripMenuItem";
            this.inBiểuMẫuToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // đặtHàngToolStripMenuItem
            // 
            this.đặtHàngToolStripMenuItem.Name = "đặtHàngToolStripMenuItem";
            this.đặtHàngToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // chiTiếtĐơnHàngToolStripMenuItem
            // 
            this.chiTiếtĐơnHàngToolStripMenuItem.Name = "chiTiếtĐơnHàngToolStripMenuItem";
            this.chiTiếtĐơnHàngToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // điệnThoạiToolStripMenuItem
            // 
            this.điệnThoạiToolStripMenuItem.Name = "điệnThoạiToolStripMenuItem";
            this.điệnThoạiToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // Them
            // 
            this.Them.Location = new System.Drawing.Point(57, 204);
            this.Them.Name = "Them";
            this.Them.Size = new System.Drawing.Size(75, 23);
            this.Them.TabIndex = 4;
            this.Them.Text = "Thêm";
            this.Them.UseVisualStyleBackColor = true;
            this.Them.Click += new System.EventHandler(this.Them_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Số Lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Điện Thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mã Đặt Hàng";
            // 
            // txtiSoluong
            // 
            this.txtiSoluong.Location = new System.Drawing.Point(457, 44);
            this.txtiSoluong.Name = "txtiSoluong";
            this.txtiSoluong.Size = new System.Drawing.Size(147, 22);
            this.txtiSoluong.TabIndex = 10;
            // 
            // Sua
            // 
            this.Sua.Enabled = false;
            this.Sua.Location = new System.Drawing.Point(196, 204);
            this.Sua.Name = "Sua";
            this.Sua.Size = new System.Drawing.Size(75, 23);
            this.Sua.TabIndex = 13;
            this.Sua.Text = "Sửa";
            this.Sua.UseVisualStyleBackColor = true;
            this.Sua.Click += new System.EventHandler(this.Sua_Click);
            // 
            // Xoa
            // 
            this.Xoa.Enabled = false;
            this.Xoa.Location = new System.Drawing.Point(345, 204);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(75, 23);
            this.Xoa.TabIndex = 14;
            this.Xoa.Text = "Xóa";
            this.Xoa.UseVisualStyleBackColor = true;
            this.Xoa.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // TimKiem
            // 
            this.TimKiem.Location = new System.Drawing.Point(639, 204);
            this.TimKiem.Name = "TimKiem";
            this.TimKiem.Size = new System.Drawing.Size(75, 23);
            this.TimKiem.TabIndex = 16;
            this.TimKiem.Text = "Tìm Kiếm";
            this.TimKiem.UseVisualStyleBackColor = true;
            this.TimKiem.Click += new System.EventHandler(this.TimKiem_Click);
            // 
            // cbDienthoai
            // 
            this.cbDienthoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDienthoai.FormattingEnabled = true;
            this.cbDienthoai.Location = new System.Drawing.Point(173, 103);
            this.cbDienthoai.Name = "cbDienthoai";
            this.cbDienthoai.Size = new System.Drawing.Size(121, 24);
            this.cbDienthoai.TabIndex = 21;
            // 
            // btnBoqua
            // 
            this.btnBoqua.Enabled = false;
            this.btnBoqua.Location = new System.Drawing.Point(486, 204);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(75, 23);
            this.btnBoqua.TabIndex = 23;
            this.btnBoqua.Text = "Bỏ qua";
            this.btnBoqua.UseVisualStyleBackColor = true;
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // cbMaDH
            // 
            this.cbMaDH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaDH.FormattingEnabled = true;
            this.cbMaDH.Location = new System.Drawing.Point(173, 40);
            this.cbMaDH.Name = "cbMaDH";
            this.cbMaDH.Size = new System.Drawing.Size(121, 24);
            this.cbMaDH.TabIndex = 24;
            // 
            // FormChiTietDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 577);
            this.Controls.Add(this.cbMaDH);
            this.Controls.Add(this.btnBoqua);
            this.Controls.Add(this.cbDienthoai);
            this.Controls.Add(this.TimKiem);
            this.Controls.Add(this.Xoa);
            this.Controls.Add(this.Sua);
            this.Controls.Add(this.txtiSoluong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Them);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormChiTietDatHang";
            this.Text = "FormChiTietDatHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormChiTietDatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inBiểuMẫuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đặtHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chiTiếtĐơnHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem điệnThoạiToolStripMenuItem;
        private System.Windows.Forms.Button Them;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        // private CachedCrystalReporthienthongtintheomahang cachedCrystalReporthienthongtintheomahang1;
        private System.Windows.Forms.TextBox txtiSoluong;
        private System.Windows.Forms.Button Sua;
        private System.Windows.Forms.Button Xoa;
        private System.Windows.Forms.Button TimKiem;
        private System.Windows.Forms.ComboBox cbDienthoai;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.ComboBox cbMaDH;
    }
}