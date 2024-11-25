using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH_QLCHDT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void quảnLýSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLSanPham QLSanPham = new QLSanPham(); //Khởi tạo đối tượng
            QLSanPham.Show(); //Hiển thị
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLKhachHang QLKhachHang = new QLKhachHang(); //Khởi tạo đối tượng
            QLKhachHang.ShowDialog(); //Hiển thị

        }

            private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void qLNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLNhanVien qLNhanVien = new QLNhanVien(); //Khởi tạo đối tượng
            qLNhanVien.ShowDialog(); //Hiển thị

        }

        private void qLHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLHoaDon qLHoaDon = new QLHoaDon(); //Khởi tạo đối tượng
            qLHoaDon.ShowDialog(); //Hiển thị

        }
    }
}
