namespace BTH_QLCHDT
{
    partial class QLKhachHang
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
            this.dgvQLKhachHang = new System.Windows.Forms.DataGridView();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnHien = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.textBoxGioiTinhKH = new System.Windows.Forms.TextBox();
            this.textBoxDiaChiKH = new System.Windows.Forms.TextBox();
            this.textBoxNgaySinhKH = new System.Windows.Forms.TextBox();
            this.textBoxTenKH = new System.Windows.Forms.TextBox();
            this.textBoxMaKH = new System.Windows.Forms.TextBox();
            this.txtGioiTinh = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.Label();
            this.txtNgaySinh = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.Label();
            this.textBoxSDT = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvQLKhachHang
            // 
            this.dgvQLKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLKhachHang.Location = new System.Drawing.Point(18, 142);
            this.dgvQLKhachHang.Name = "dgvQLKhachHang";
            this.dgvQLKhachHang.RowHeadersWidth = 51;
            this.dgvQLKhachHang.RowTemplate.Height = 24;
            this.dgvQLKhachHang.Size = new System.Drawing.Size(767, 299);
            this.dgvQLKhachHang.TabIndex = 34;
            this.dgvQLKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLKhachHang_CellClick);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(710, 97);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(75, 23);
            this.btnIn.TabIndex = 33;
            this.btnIn.Text = "In ";
            this.btnIn.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(583, 97);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 32;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnHien
            // 
            this.btnHien.Location = new System.Drawing.Point(445, 97);
            this.btnHien.Name = "btnHien";
            this.btnHien.Size = new System.Drawing.Size(75, 23);
            this.btnHien.TabIndex = 31;
            this.btnHien.Text = "Hiện";
            this.btnHien.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(299, 97);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 30;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(158, 97);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 29;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(18, 97);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 28;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // textBoxGioiTinhKH
            // 
            this.textBoxGioiTinhKH.Location = new System.Drawing.Point(607, 10);
            this.textBoxGioiTinhKH.Name = "textBoxGioiTinhKH";
            this.textBoxGioiTinhKH.Size = new System.Drawing.Size(178, 22);
            this.textBoxGioiTinhKH.TabIndex = 27;
            // 
            // textBoxDiaChiKH
            // 
            this.textBoxDiaChiKH.Location = new System.Drawing.Point(356, 46);
            this.textBoxDiaChiKH.Name = "textBoxDiaChiKH";
            this.textBoxDiaChiKH.Size = new System.Drawing.Size(175, 22);
            this.textBoxDiaChiKH.TabIndex = 26;
            // 
            // textBoxNgaySinhKH
            // 
            this.textBoxNgaySinhKH.Location = new System.Drawing.Point(356, 9);
            this.textBoxNgaySinhKH.Name = "textBoxNgaySinhKH";
            this.textBoxNgaySinhKH.Size = new System.Drawing.Size(175, 22);
            this.textBoxNgaySinhKH.TabIndex = 25;
            this.textBoxNgaySinhKH.TextChanged += new System.EventHandler(this.textBoxTenDT_TextChanged);
            // 
            // textBoxTenKH
            // 
            this.textBoxTenKH.Location = new System.Drawing.Point(123, 46);
            this.textBoxTenKH.Name = "textBoxTenKH";
            this.textBoxTenKH.Size = new System.Drawing.Size(152, 22);
            this.textBoxTenKH.TabIndex = 24;
            // 
            // textBoxMaKH
            // 
            this.textBoxMaKH.Location = new System.Drawing.Point(123, 9);
            this.textBoxMaKH.Name = "textBoxMaKH";
            this.textBoxMaKH.Size = new System.Drawing.Size(152, 22);
            this.textBoxMaKH.TabIndex = 23;
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.AutoSize = true;
            this.txtGioiTinh.Location = new System.Drawing.Point(537, 16);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(60, 16);
            this.txtGioiTinh.TabIndex = 22;
            this.txtGioiTinh.Text = "Giới Tính";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.AutoSize = true;
            this.txtDiaChi.Location = new System.Drawing.Point(281, 46);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(49, 16);
            this.txtDiaChi.TabIndex = 21;
            this.txtDiaChi.Text = "Địa Chỉ";
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.AutoSize = true;
            this.txtNgaySinh.Location = new System.Drawing.Point(281, 16);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(69, 16);
            this.txtNgaySinh.TabIndex = 20;
            this.txtNgaySinh.Text = "Ngày Sinh";
            // 
            // txtTenKH
            // 
            this.txtTenKH.AutoSize = true;
            this.txtTenKH.Location = new System.Drawing.Point(15, 46);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(107, 16);
            this.txtTenKH.TabIndex = 19;
            this.txtTenKH.Text = "Tên Khách Hàng";
            // 
            // txtMaKH
            // 
            this.txtMaKH.AutoSize = true;
            this.txtMaKH.Location = new System.Drawing.Point(15, 15);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(102, 16);
            this.txtMaKH.TabIndex = 18;
            this.txtMaKH.Text = "Mã Khách Hàng";
            // 
            // textBoxSDT
            // 
            this.textBoxSDT.Location = new System.Drawing.Point(607, 46);
            this.textBoxSDT.Name = "textBoxSDT";
            this.textBoxSDT.Size = new System.Drawing.Size(178, 22);
            this.textBoxSDT.TabIndex = 36;
            // 
            // txtSDT
            // 
            this.txtSDT.AutoSize = true;
            this.txtSDT.Location = new System.Drawing.Point(537, 52);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(34, 16);
            this.txtSDT.TabIndex = 35;
            this.txtSDT.Text = "SĐT";
            // 
            // QLKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxSDT);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.dgvQLKhachHang);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnHien);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.textBoxGioiTinhKH);
            this.Controls.Add(this.textBoxDiaChiKH);
            this.Controls.Add(this.textBoxNgaySinhKH);
            this.Controls.Add(this.textBoxTenKH);
            this.Controls.Add(this.textBoxMaKH);
            this.Controls.Add(this.txtGioiTinh);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtNgaySinh);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.txtMaKH);
            this.Name = "QLKhachHang";
            this.Text = "Quản Lý Khách Hàng";
            this.Load += new System.EventHandler(this.QLKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvQLKhachHang;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnHien;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox textBoxGioiTinhKH;
        private System.Windows.Forms.TextBox textBoxDiaChiKH;
        private System.Windows.Forms.TextBox textBoxNgaySinhKH;
        private System.Windows.Forms.TextBox textBoxTenKH;
        private System.Windows.Forms.TextBox textBoxMaKH;
        private System.Windows.Forms.Label txtGioiTinh;
        private System.Windows.Forms.Label txtDiaChi;
        private System.Windows.Forms.Label txtNgaySinh;
        private System.Windows.Forms.Label txtTenKH;
        private System.Windows.Forms.Label txtMaKH;
        private System.Windows.Forms.TextBox textBoxSDT;
        private System.Windows.Forms.Label txtSDT;
    }
}