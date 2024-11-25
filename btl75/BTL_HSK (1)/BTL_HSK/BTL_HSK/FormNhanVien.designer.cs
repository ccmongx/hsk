
namespace BTL_HSK
{
    partial class FormNhanVien
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.Them = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtsMaNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtsDiachi = new System.Windows.Forms.TextBox();
            this.txtsTenNV = new System.Windows.Forms.TextBox();
            this.Sua = new System.Windows.Forms.Button();
            this.Xoa = new System.Windows.Forms.Button();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.TimKiem = new System.Windows.Forms.Button();
            this.txtfPhuCap = new System.Windows.Forms.TextBox();
            this.txtfLuongCB = new System.Windows.Forms.TextBox();
            this.txtsSdt = new System.Windows.Forms.TextBox();
            this.txtdNgaysinh = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btlhskDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btl_hskDataSet1 = new BTL_HSK.btl_hskDataSet1();
            this.dataSetNhanVien = new BTL_HSK.DataSetNhanVien();
            this.dataSetNhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblNhanvienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_NhanvienTableAdapter = new BTL_HSK.DataSetNhanVienTableAdapters.tbl_NhanvienTableAdapter();
            this.tblNhanvienBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btlhskDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btl_hskDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetNhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNhanvienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNhanvienBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Nhân Viên";
            // 
            // Them
            // 
            this.Them.Location = new System.Drawing.Point(88, 194);
            this.Them.Name = "Them";
            this.Them.Size = new System.Drawing.Size(75, 23);
            this.Them.TabIndex = 2;
            this.Them.Text = "Thêm";
            this.Them.UseVisualStyleBackColor = true;
            this.Them.Click += new System.EventHandler(this.Them_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 223);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(923, 274);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtsMaNV
            // 
            this.txtsMaNV.Location = new System.Drawing.Point(122, 27);
            this.txtsMaNV.Name = "txtsMaNV";
            this.txtsMaNV.Size = new System.Drawing.Size(131, 22);
            this.txtsMaNV.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên Nhân Viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Địa Chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ngày Sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(287, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Số Điện Thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(287, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Lương Cơ Bản";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(560, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Phụ Cấp";
            // 
            // txtsDiachi
            // 
            this.txtsDiachi.Location = new System.Drawing.Point(122, 135);
            this.txtsDiachi.Name = "txtsDiachi";
            this.txtsDiachi.Size = new System.Drawing.Size(131, 22);
            this.txtsDiachi.TabIndex = 16;
            // 
            // txtsTenNV
            // 
            this.txtsTenNV.Location = new System.Drawing.Point(122, 82);
            this.txtsTenNV.Name = "txtsTenNV";
            this.txtsTenNV.Size = new System.Drawing.Size(131, 22);
            this.txtsTenNV.TabIndex = 17;
            // 
            // Sua
            // 
            this.Sua.Location = new System.Drawing.Point(259, 194);
            this.Sua.Name = "Sua";
            this.Sua.Size = new System.Drawing.Size(75, 23);
            this.Sua.TabIndex = 18;
            this.Sua.Text = "Sửa";
            this.Sua.UseVisualStyleBackColor = true;
            this.Sua.Click += new System.EventHandler(this.Sua_Click);
            // 
            // Xoa
            // 
            this.Xoa.Location = new System.Drawing.Point(420, 194);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(75, 23);
            this.Xoa.TabIndex = 19;
            this.Xoa.Text = "Xóa";
            this.Xoa.UseVisualStyleBackColor = true;
            this.Xoa.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // btnBoqua
            // 
            this.btnBoqua.Location = new System.Drawing.Point(577, 194);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(75, 23);
            this.btnBoqua.TabIndex = 20;
            this.btnBoqua.Text = "Bỏ qua";
            this.btnBoqua.UseVisualStyleBackColor = true;
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // TimKiem
            // 
            this.TimKiem.Location = new System.Drawing.Point(733, 194);
            this.TimKiem.Name = "TimKiem";
            this.TimKiem.Size = new System.Drawing.Size(75, 23);
            this.TimKiem.TabIndex = 21;
            this.TimKiem.Text = "Tìm Kiếm";
            this.TimKiem.UseVisualStyleBackColor = true;
            this.TimKiem.Click += new System.EventHandler(this.TimKiem_Click);
            // 
            // txtfPhuCap
            // 
            this.txtfPhuCap.Location = new System.Drawing.Point(628, 25);
            this.txtfPhuCap.Name = "txtfPhuCap";
            this.txtfPhuCap.Size = new System.Drawing.Size(131, 22);
            this.txtfPhuCap.TabIndex = 22;
            // 
            // txtfLuongCB
            // 
            this.txtfLuongCB.Location = new System.Drawing.Point(391, 135);
            this.txtfLuongCB.Name = "txtfLuongCB";
            this.txtfLuongCB.Size = new System.Drawing.Size(131, 22);
            this.txtfLuongCB.TabIndex = 23;
            // 
            // txtsSdt
            // 
            this.txtsSdt.Location = new System.Drawing.Point(391, 82);
            this.txtsSdt.Name = "txtsSdt";
            this.txtsSdt.Size = new System.Drawing.Size(131, 22);
            this.txtsSdt.TabIndex = 25;
            // 
            // txtdNgaysinh
            // 
            this.txtdNgaysinh.Location = new System.Drawing.Point(391, 28);
            this.txtdNgaysinh.Name = "txtdNgaysinh";
            this.txtdNgaysinh.Size = new System.Drawing.Size(100, 22);
            this.txtdNgaysinh.TabIndex = 26;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.AutoSize = true;
            this.txtGhiChu.Location = new System.Drawing.Point(560, 60);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(107, 16);
            this.txtGhiChu.TabIndex = 28;
            this.txtGhiChu.Text = "Thông tin ghi chú";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.DataSource = this.btlhskDataSet1BindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(563, 85);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(350, 87);
            this.dataGridView2.TabIndex = 29;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // btlhskDataSet1BindingSource
            // 
            this.btlhskDataSet1BindingSource.DataSource = this.btl_hskDataSet1;
            this.btlhskDataSet1BindingSource.Position = 0;
            // 
            // btl_hskDataSet1
            // 
            this.btl_hskDataSet1.DataSetName = "btl_hskDataSet1";
            this.btl_hskDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetNhanVien
            // 
            this.dataSetNhanVien.DataSetName = "DataSetNhanVien";
            this.dataSetNhanVien.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetNhanVienBindingSource
            // 
            this.dataSetNhanVienBindingSource.DataSource = this.dataSetNhanVien;
            this.dataSetNhanVienBindingSource.Position = 0;
            // 
            // tblNhanvienBindingSource
            // 
            this.tblNhanvienBindingSource.DataMember = "tbl_Nhanvien";
            this.tblNhanvienBindingSource.DataSource = this.dataSetNhanVienBindingSource;
            // 
            // tbl_NhanvienTableAdapter
            // 
            this.tbl_NhanvienTableAdapter.ClearBeforeFill = true;
            // 
            // tblNhanvienBindingSource1
            // 
            this.tblNhanvienBindingSource1.DataMember = "tbl_Nhanvien";
            this.tblNhanvienBindingSource1.DataSource = this.dataSetNhanVien;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(954, 85);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(154, 87);
            this.richTextBox1.TabIndex = 30;
            this.richTextBox1.Text = "";
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 498);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtdNgaysinh);
            this.Controls.Add(this.txtsSdt);
            this.Controls.Add(this.txtfLuongCB);
            this.Controls.Add(this.txtfPhuCap);
            this.Controls.Add(this.TimKiem);
            this.Controls.Add(this.btnBoqua);
            this.Controls.Add(this.Xoa);
            this.Controls.Add(this.Sua);
            this.Controls.Add(this.txtsTenNV);
            this.Controls.Add(this.txtsDiachi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtsMaNV);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Them);
            this.Controls.Add(this.label1);
            this.Name = "FormNhanVien";
            this.Text = "FormNhanVien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btlhskDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btl_hskDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetNhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNhanvienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNhanvienBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Them;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtsMaNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtsDiachi;
        private System.Windows.Forms.TextBox txtsTenNV;
        private System.Windows.Forms.Button Sua;
        private System.Windows.Forms.Button Xoa;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.Button TimKiem;
        private System.Windows.Forms.TextBox txtfPhuCap;
        private System.Windows.Forms.TextBox txtfLuongCB;
        private System.Windows.Forms.TextBox txtsSdt;
        private System.Windows.Forms.TextBox txtdNgaysinh;
        private System.Windows.Forms.Label txtGhiChu;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource dataSetNhanVienBindingSource;
        private DataSetNhanVien dataSetNhanVien;
        private System.Windows.Forms.BindingSource tblNhanvienBindingSource;
        private DataSetNhanVienTableAdapters.tbl_NhanvienTableAdapter tbl_NhanvienTableAdapter;
        private System.Windows.Forms.BindingSource btlhskDataSet1BindingSource;
        private btl_hskDataSet1 btl_hskDataSet1;
        private System.Windows.Forms.BindingSource tblNhanvienBindingSource1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}