
namespace BTL_HSK
{
    partial class FormKhachHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtsMaKH = new System.Windows.Forms.TextBox();
            this.txtsSdt = new System.Windows.Forms.TextBox();
            this.txtsDiachi = new System.Windows.Forms.TextBox();
            this.txtdNgaysinh = new System.Windows.Forms.TextBox();
            this.txtsTenkhachhang = new System.Windows.Forms.TextBox();
            this.Them = new System.Windows.Forms.Button();
            this.Sua = new System.Windows.Forms.Button();
            this.Xoa = new System.Windows.Forms.Button();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.TimKiem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.gbGioitinh = new System.Windows.Forms.GroupBox();
            this.txtGhichu = new System.Windows.Forms.Label();
            this.cbKHCU = new System.Windows.Forms.CheckBox();
            this.cbKHmoi = new System.Windows.Forms.CheckBox();
            this.cbKHvip = new System.Windows.Forms.CheckBox();
            this.cbKHkhac = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbGioitinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Khách Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Khách Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày Sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(531, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa Chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(531, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số Điện Thoại";
            // 
            // txtsMaKH
            // 
            this.txtsMaKH.Location = new System.Drawing.Point(146, 59);
            this.txtsMaKH.Name = "txtsMaKH";
            this.txtsMaKH.Size = new System.Drawing.Size(151, 22);
            this.txtsMaKH.TabIndex = 6;
            // 
            // txtsSdt
            // 
            this.txtsSdt.Location = new System.Drawing.Point(644, 148);
            this.txtsSdt.Name = "txtsSdt";
            this.txtsSdt.Size = new System.Drawing.Size(151, 22);
            this.txtsSdt.TabIndex = 7;
            // 
            // txtsDiachi
            // 
            this.txtsDiachi.Location = new System.Drawing.Point(644, 59);
            this.txtsDiachi.Name = "txtsDiachi";
            this.txtsDiachi.Size = new System.Drawing.Size(151, 22);
            this.txtsDiachi.TabIndex = 9;
            // 
            // txtdNgaysinh
            // 
            this.txtdNgaysinh.Location = new System.Drawing.Point(146, 148);
            this.txtdNgaysinh.Name = "txtdNgaysinh";
            this.txtdNgaysinh.Size = new System.Drawing.Size(151, 22);
            this.txtdNgaysinh.TabIndex = 10;
            this.txtdNgaysinh.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtsTenkhachhang
            // 
            this.txtsTenkhachhang.Location = new System.Drawing.Point(146, 103);
            this.txtsTenkhachhang.Name = "txtsTenkhachhang";
            this.txtsTenkhachhang.Size = new System.Drawing.Size(151, 22);
            this.txtsTenkhachhang.TabIndex = 11;
            // 
            // Them
            // 
            this.Them.Location = new System.Drawing.Point(95, 227);
            this.Them.Name = "Them";
            this.Them.Size = new System.Drawing.Size(75, 23);
            this.Them.TabIndex = 12;
            this.Them.Text = "Thêm";
            this.Them.UseVisualStyleBackColor = true;
            this.Them.Click += new System.EventHandler(this.button1_Click);
            // 
            // Sua
            // 
            this.Sua.Location = new System.Drawing.Point(247, 227);
            this.Sua.Name = "Sua";
            this.Sua.Size = new System.Drawing.Size(75, 23);
            this.Sua.TabIndex = 13;
            this.Sua.Text = "Sửa";
            this.Sua.UseVisualStyleBackColor = true;
            this.Sua.Click += new System.EventHandler(this.Sua_Click);
            // 
            // Xoa
            // 
            this.Xoa.Location = new System.Drawing.Point(389, 227);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(75, 23);
            this.Xoa.TabIndex = 14;
            this.Xoa.Text = "Xóa";
            this.Xoa.UseVisualStyleBackColor = true;
            this.Xoa.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // btnBoqua
            // 
            this.btnBoqua.Location = new System.Drawing.Point(534, 227);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(75, 23);
            this.btnBoqua.TabIndex = 15;
            this.btnBoqua.Text = "Bỏ qua";
            this.btnBoqua.UseVisualStyleBackColor = true;
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // TimKiem
            // 
            this.TimKiem.Location = new System.Drawing.Point(670, 227);
            this.TimKiem.Name = "TimKiem";
            this.TimKiem.Size = new System.Drawing.Size(75, 23);
            this.TimKiem.TabIndex = 16;
            this.TimKiem.Text = "Tìm Kiếm";
            this.TimKiem.UseVisualStyleBackColor = true;
            this.TimKiem.Click += new System.EventHandler(this.TimKiem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 272);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(846, 318);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Location = new System.Drawing.Point(119, 0);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(57, 20);
            this.rdNam.TabIndex = 18;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(223, 0);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(45, 20);
            this.rdNu.TabIndex = 19;
            this.rdNu.TabStop = true;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // gbGioitinh
            // 
            this.gbGioitinh.Controls.Add(this.rdNam);
            this.gbGioitinh.Controls.Add(this.rdNu);
            this.gbGioitinh.Location = new System.Drawing.Point(525, 103);
            this.gbGioitinh.Name = "gbGioitinh";
            this.gbGioitinh.Size = new System.Drawing.Size(299, 22);
            this.gbGioitinh.TabIndex = 20;
            this.gbGioitinh.TabStop = false;
            this.gbGioitinh.Text = "Giới tính";
            // 
            // txtGhichu
            // 
            this.txtGhichu.AutoSize = true;
            this.txtGhichu.Location = new System.Drawing.Point(25, 189);
            this.txtGhichu.Name = "txtGhichu";
            this.txtGhichu.Size = new System.Drawing.Size(53, 16);
            this.txtGhichu.TabIndex = 25;
            this.txtGhichu.Text = "Ghi Chú";
            // 
            // cbKHCU
            // 
            this.cbKHCU.AutoSize = true;
            this.cbKHCU.Location = new System.Drawing.Point(146, 189);
            this.cbKHCU.Name = "cbKHCU";
            this.cbKHCU.Size = new System.Drawing.Size(64, 20);
            this.cbKHCU.TabIndex = 26;
            this.cbKHCU.Text = "KH cũ";
            this.cbKHCU.UseVisualStyleBackColor = true;
            // 
            // cbKHmoi
            // 
            this.cbKHmoi.AutoSize = true;
            this.cbKHmoi.Location = new System.Drawing.Point(247, 189);
            this.cbKHmoi.Name = "cbKHmoi";
            this.cbKHmoi.Size = new System.Drawing.Size(72, 20);
            this.cbKHmoi.TabIndex = 27;
            this.cbKHmoi.Text = "KH mới";
            this.cbKHmoi.UseVisualStyleBackColor = true;
            // 
            // cbKHvip
            // 
            this.cbKHvip.AutoSize = true;
            this.cbKHvip.Location = new System.Drawing.Point(348, 189);
            this.cbKHvip.Name = "cbKHvip";
            this.cbKHvip.Size = new System.Drawing.Size(71, 20);
            this.cbKHvip.TabIndex = 28;
            this.cbKHvip.Text = "KH VIP";
            this.cbKHvip.UseVisualStyleBackColor = true;
            // 
            // cbKHkhac
            // 
            this.cbKHkhac.AutoSize = true;
            this.cbKHkhac.Location = new System.Drawing.Point(449, 188);
            this.cbKHkhac.Name = "cbKHkhac";
            this.cbKHkhac.Size = new System.Drawing.Size(166, 20);
            this.cbKHkhac.TabIndex = 29;
            this.cbKHkhac.Text = "KH có yêu cầu đặc biệt";
            this.cbKHkhac.UseVisualStyleBackColor = true;
            // 
            // FormKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 584);
            this.Controls.Add(this.cbKHkhac);
            this.Controls.Add(this.cbKHvip);
            this.Controls.Add(this.cbKHmoi);
            this.Controls.Add(this.cbKHCU);
            this.Controls.Add(this.txtGhichu);
            this.Controls.Add(this.gbGioitinh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TimKiem);
            this.Controls.Add(this.btnBoqua);
            this.Controls.Add(this.Xoa);
            this.Controls.Add(this.Sua);
            this.Controls.Add(this.Them);
            this.Controls.Add(this.txtsTenkhachhang);
            this.Controls.Add(this.txtdNgaysinh);
            this.Controls.Add(this.txtsDiachi);
            this.Controls.Add(this.txtsSdt);
            this.Controls.Add(this.txtsMaKH);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormKhachHang";
            this.Text = "FormKhachHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbGioitinh.ResumeLayout(false);
            this.gbGioitinh.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtsMaKH;
        private System.Windows.Forms.TextBox txtsSdt;
        private System.Windows.Forms.TextBox txtsDiachi;
        private System.Windows.Forms.TextBox txtdNgaysinh;
        private System.Windows.Forms.TextBox txtsTenkhachhang;
        private System.Windows.Forms.Button Them;
        private System.Windows.Forms.Button Sua;
        private System.Windows.Forms.Button Xoa;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.Button TimKiem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.GroupBox gbGioitinh;
        private System.Windows.Forms.Label txtGhichu;
        private System.Windows.Forms.CheckBox cbKHCU;
        private System.Windows.Forms.CheckBox cbKHmoi;
        private System.Windows.Forms.CheckBox cbKHvip;
        private System.Windows.Forms.CheckBox cbKHkhac;
    }
}