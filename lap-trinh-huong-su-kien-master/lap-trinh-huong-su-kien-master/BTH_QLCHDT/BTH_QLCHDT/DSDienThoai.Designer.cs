namespace BTH_QLCHDT
{
    partial class DSDienThoai
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            errorCheck = new ErrorProvider(components);
            lbMahang = new Label();
            lbMaDT = new Label();
            lbTenDT = new Label();
            ldSoluong = new Label();
            lbGiaban = new Label();
            tbMahang = new TextBox();
            tbMaDT = new TextBox();
            tbSoluong = new TextBox();
            tbGiaban = new TextBox();
            tbTenDT = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnReset = new Button();
            btnThoat = new Button();
            dgvDienthoai = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)errorCheck).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDienthoai).BeginInit();
            SuspendLayout();
            // 
            // errorCheck
            // 
            errorCheck.ContainerControl = this;
            // 
            // lbMahang
            // 
            lbMahang.AutoSize = true;
            lbMahang.Location = new Point(16, 29);
            lbMahang.Margin = new Padding(2, 0, 2, 0);
            lbMahang.Name = "lbMahang";
            lbMahang.Size = new Size(130, 20);
            lbMahang.TabIndex = 0;
            lbMahang.Text = "Nhập mã hãng ĐT";
            // 
            // lbMaDT
            // 
            lbMaDT.AutoSize = true;
            lbMaDT.Location = new Point(17, 62);
            lbMaDT.Margin = new Padding(2, 0, 2, 0);
            lbMaDT.Name = "lbMaDT";
            lbMaDT.Size = new Size(93, 20);
            lbMaDT.TabIndex = 1;
            lbMaDT.Text = "Nhập mã ĐT";
            // 
            // lbTenDT
            // 
            lbTenDT.AutoSize = true;
            lbTenDT.Location = new Point(17, 94);
            lbTenDT.Margin = new Padding(2, 0, 2, 0);
            lbTenDT.Name = "lbTenDT";
            lbTenDT.Size = new Size(93, 20);
            lbTenDT.TabIndex = 2;
            lbTenDT.Text = "Nhập tên ĐT";
            // 
            // ldSoluong
            // 
            ldSoluong.AutoSize = true;
            ldSoluong.Location = new Point(17, 126);
            ldSoluong.Margin = new Padding(2, 0, 2, 0);
            ldSoluong.Name = "ldSoluong";
            ldSoluong.Size = new Size(107, 20);
            ldSoluong.TabIndex = 3;
            ldSoluong.Text = "Nhập số lượng";
            // 
            // lbGiaban
            // 
            lbGiaban.AutoSize = true;
            lbGiaban.Location = new Point(17, 160);
            lbGiaban.Margin = new Padding(2, 0, 2, 0);
            lbGiaban.Name = "lbGiaban";
            lbGiaban.Size = new Size(99, 20);
            lbGiaban.TabIndex = 4;
            lbGiaban.Text = "Nhập giá bán";
            // 
            // tbMahang
            // 
            tbMahang.Location = new Point(154, 24);
            tbMahang.Margin = new Padding(2);
            tbMahang.Name = "tbMahang";
            tbMahang.Size = new Size(204, 27);
            tbMahang.TabIndex = 0;
            tbMahang.Validating += tbMahang_Validating;
            // 
            // tbMaDT
            // 
            tbMaDT.Location = new Point(154, 58);
            tbMaDT.Margin = new Padding(2);
            tbMaDT.Name = "tbMaDT";
            tbMaDT.Size = new Size(204, 27);
            tbMaDT.TabIndex = 1;
            tbMaDT.Validating += tbMaDT_Validating;
            // 
            // tbSoluong
            // 
            tbSoluong.Location = new Point(154, 122);
            tbSoluong.Margin = new Padding(2);
            tbSoluong.Name = "tbSoluong";
            tbSoluong.Size = new Size(205, 27);
            tbSoluong.TabIndex = 3;
            tbSoluong.Validating += tbSoluong_Validating;
            // 
            // tbGiaban
            // 
            tbGiaban.Location = new Point(154, 160);
            tbGiaban.Margin = new Padding(2);
            tbGiaban.Name = "tbGiaban";
            tbGiaban.Size = new Size(204, 27);
            tbGiaban.TabIndex = 4;
            tbGiaban.Validating += tbGiaban_Validating;
            // 
            // tbTenDT
            // 
            tbTenDT.Location = new Point(154, 91);
            tbTenDT.Margin = new Padding(2);
            tbTenDT.Name = "tbTenDT";
            tbTenDT.Size = new Size(205, 27);
            tbTenDT.TabIndex = 2;
            tbTenDT.Validating += tbTenDT_Validating;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(21, 204);
            btnThem.Margin = new Padding(2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(90, 27);
            btnThem.TabIndex = 5;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(161, 202);
            btnSua.Margin = new Padding(2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(90, 27);
            btnSua.TabIndex = 6;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(306, 204);
            btnXoa.Margin = new Padding(2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(90, 27);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(442, 204);
            btnReset.Margin = new Padding(2);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(90, 27);
            btnReset.TabIndex = 8;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(574, 202);
            btnThoat.Margin = new Padding(2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(90, 27);
            btnThoat.TabIndex = 9;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // dgvDienthoai
            // 
            dgvDienthoai.AllowUserToAddRows = false;
            dgvDienthoai.AllowUserToDeleteRows = false;
            dgvDienthoai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDienthoai.Location = new Point(21, 254);
            dgvDienthoai.Margin = new Padding(2);
            dgvDienthoai.Name = "dgvDienthoai";
            dgvDienthoai.RowHeadersWidth = 62;
            dgvDienthoai.RowTemplate.Height = 33;
            dgvDienthoai.Size = new Size(843, 306);
            dgvDienthoai.TabIndex = 10;
            // 
            // DSDienThoai
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 569);
            Controls.Add(dgvDienthoai);
            Controls.Add(btnThoat);
            Controls.Add(btnReset);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(tbTenDT);
            Controls.Add(tbGiaban);
            Controls.Add(tbSoluong);
            Controls.Add(tbMaDT);
            Controls.Add(tbMahang);
            Controls.Add(lbGiaban);
            Controls.Add(ldSoluong);
            Controls.Add(lbTenDT);
            Controls.Add(lbMaDT);
            Controls.Add(lbMahang);
            Margin = new Padding(2, 2, 2, 2);
            Name = "DSDienThoai";
            Text = "Quản lý sản phẩm điện thoại";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)errorCheck).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDienthoai).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ErrorProvider errorCheck;
        private DataGridView dgvDienthoai;
        private Button btnThoat;
        private Button btnReset;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox tbTenDT;
        private TextBox tbGiaban;
        private TextBox tbSoluong;
        private TextBox tbMaDT;
        private TextBox tbMahang;
        private Label lbGiaban;
        private Label ldSoluong;
        private Label lbTenDT;
        private Label lbMaDT;
        private Label lbMahang;
    }
}