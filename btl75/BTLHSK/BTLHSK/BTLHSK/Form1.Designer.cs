namespace BTLHSK
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_ma = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_ten = new System.Windows.Forms.TextBox();
            this.tb_sdt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_dc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_in = new System.Windows.Forms.Button();
            this.dgv_dsnv = new System.Windows.Forms.DataGridView();
            this.ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ns = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtp_ns = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_lcb = new System.Windows.Forms.TextBox();
            this.tb_pc = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsnv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên :";
            // 
            // tb_ma
            // 
            this.tb_ma.Location = new System.Drawing.Point(143, 69);
            this.tb_ma.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_ma.Name = "tb_ma";
            this.tb_ma.Size = new System.Drawing.Size(209, 26);
            this.tb_ma.TabIndex = 1;
            this.tb_ma.Validating += new System.ComponentModel.CancelEventHandler(this.tb_ma_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày sinh :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Họ tên :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(270, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(396, 40);
            this.label4.TabIndex = 4;
            this.label4.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // tb_ten
            // 
            this.tb_ten.Location = new System.Drawing.Point(143, 107);
            this.tb_ten.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_ten.Name = "tb_ten";
            this.tb_ten.Size = new System.Drawing.Size(209, 26);
            this.tb_ten.TabIndex = 5;
            // 
            // tb_sdt
            // 
            this.tb_sdt.Location = new System.Drawing.Point(143, 214);
            this.tb_sdt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_sdt.Name = "tb_sdt";
            this.tb_sdt.Size = new System.Drawing.Size(209, 26);
            this.tb_sdt.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Địa chỉ :";
            // 
            // tb_dc
            // 
            this.tb_dc.Location = new System.Drawing.Point(143, 141);
            this.tb_dc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_dc.Name = "tb_dc";
            this.tb_dc.Size = new System.Drawing.Size(209, 26);
            this.tb_dc.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Sô điện thoại :";
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(68, 336);
            this.bt_them.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(84, 29);
            this.bt_them.TabIndex = 11;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.Location = new System.Drawing.Point(212, 336);
            this.bt_sua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(84, 29);
            this.bt_sua.TabIndex = 12;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.Location = new System.Drawing.Point(68, 373);
            this.bt_xoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(84, 29);
            this.bt_xoa.TabIndex = 13;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_in
            // 
            this.bt_in.Location = new System.Drawing.Point(212, 373);
            this.bt_in.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_in.Name = "bt_in";
            this.bt_in.Size = new System.Drawing.Size(84, 29);
            this.bt_in.TabIndex = 14;
            this.bt_in.Text = "In DS";
            this.bt_in.UseVisualStyleBackColor = true;
            this.bt_in.Click += new System.EventHandler(this.bt_in_Click);
            // 
            // dgv_dsnv
            // 
            this.dgv_dsnv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_dsnv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dsnv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma,
            this.ten,
            this.dc,
            this.ns,
            this.sdt,
            this.luong,
            this.pc});
            this.dgv_dsnv.Location = new System.Drawing.Point(412, 52);
            this.dgv_dsnv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_dsnv.Name = "dgv_dsnv";
            this.dgv_dsnv.RowHeadersWidth = 51;
            this.dgv_dsnv.RowTemplate.Height = 24;
            this.dgv_dsnv.Size = new System.Drawing.Size(1125, 739);
            this.dgv_dsnv.TabIndex = 15;
            this.dgv_dsnv.Click += new System.EventHandler(this.dgv_dsnv_Click);
            // 
            // ma
            // 
            this.ma.DataPropertyName = "iMaNV";
            this.ma.HeaderText = "Mã nhân viên";
            this.ma.MinimumWidth = 6;
            this.ma.Name = "ma";
            // 
            // ten
            // 
            this.ten.DataPropertyName = "sTenNV";
            this.ten.HeaderText = "Họ và tên";
            this.ten.MinimumWidth = 6;
            this.ten.Name = "ten";
            // 
            // dc
            // 
            this.dc.DataPropertyName = "sDiachi";
            this.dc.HeaderText = "Địa chỉ";
            this.dc.MinimumWidth = 6;
            this.dc.Name = "dc";
            // 
            // ns
            // 
            this.ns.DataPropertyName = "dNgaysinh";
            this.ns.HeaderText = "Ngày sinh";
            this.ns.MinimumWidth = 6;
            this.ns.Name = "ns";
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "sSdt";
            this.sdt.HeaderText = "Số điện thoại";
            this.sdt.MinimumWidth = 6;
            this.sdt.Name = "sdt";
            // 
            // luong
            // 
            this.luong.DataPropertyName = "fLuongCB";
            this.luong.HeaderText = "Lương";
            this.luong.MinimumWidth = 6;
            this.luong.Name = "luong";
            // 
            // pc
            // 
            this.pc.DataPropertyName = "fPhuCap";
            this.pc.HeaderText = "Phụ cấp";
            this.pc.MinimumWidth = 6;
            this.pc.Name = "pc";
            // 
            // dtp_ns
            // 
            this.dtp_ns.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ns.Location = new System.Drawing.Point(143, 177);
            this.dtp_ns.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtp_ns.Name = "dtp_ns";
            this.dtp_ns.Size = new System.Drawing.Size(209, 26);
            this.dtp_ns.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Phụ cấp : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Lương cơ bản :";
            // 
            // tb_lcb
            // 
            this.tb_lcb.Location = new System.Drawing.Point(143, 282);
            this.tb_lcb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_lcb.Name = "tb_lcb";
            this.tb_lcb.Size = new System.Drawing.Size(209, 26);
            this.tb_lcb.TabIndex = 19;
            // 
            // tb_pc
            // 
            this.tb_pc.Location = new System.Drawing.Point(143, 248);
            this.tb_pc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_pc.Name = "tb_pc";
            this.tb_pc.Size = new System.Drawing.Size(209, 26);
            this.tb_pc.TabIndex = 20;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1559, 834);
            this.Controls.Add(this.tb_pc);
            this.Controls.Add(this.tb_lcb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtp_ns);
            this.Controls.Add(this.dgv_dsnv);
            this.Controls.Add(this.bt_in);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_dc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_sdt);
            this.Controls.Add(this.tb_ten);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_ma);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân Viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsnv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_ma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_ten;
        private System.Windows.Forms.TextBox tb_sdt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_dc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_in;
        private System.Windows.Forms.DataGridView dgv_dsnv;
        private System.Windows.Forms.DateTimePicker dtp_ns;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_lcb;
        private System.Windows.Forms.TextBox tb_pc;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn dc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ns;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn luong;
        private System.Windows.Forms.DataGridViewTextBoxColumn pc;
    }
}

