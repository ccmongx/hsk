using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_HSK
{
    public partial class QuanLyCuaHangDienThoai : Form
    {
        public QuanLyCuaHangDienThoai()
        {
            InitializeComponent();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKhachHang formKhachHang = new FormKhachHang();
            formKhachHang.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNhanVien formNhanVien = new FormNhanVien();
            formNhanVien.Show();
        }

        private void điệnThoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDienThoai formDienThoai = new FormDienThoai();
            formDienThoai.Show();
        }

        private void đặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void đơnĐặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDatHang formDatHang = new FormDatHang();
            formDatHang.Show();
        }

        private void chiTiếtĐơnĐặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChiTietDatHang formChiTietDatHang = new FormChiTietDatHang();
            formChiTietDatHang.Show();
        }

        private void đơnĐặtHàngTheoThángNămToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportnamthang reportnamthang = new Reportnamthang();
            reportnamthang.Show();
        }

        private void danhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCRNhanVien formCRNhanVien = new FormCRNhanVien();
            formCRNhanVien.Show();
        }

        private void danhSáchĐiệnThoạiTheoHãngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formhiendienthoaitheomahang formhiendienthoaitheomahang = new Formhiendienthoaitheomahang();
            formhiendienthoaitheomahang.Show();
        }

        private void thốngKêLượngBánRaTheoGiáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LocGiaKhoang locGiaKhoang = new LocGiaKhoang();
            locGiaKhoang.Show();
        }

        private void thốngKêLượngBánRaTheoNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LuongBanRaTheoNV luongBanRaTheoNV = new LuongBanRaTheoNV();
            luongBanRaTheoNV.Show();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKeLuongBan thongKeLuongBan = new ThongKeLuongBan();
            thongKeLuongBan.Show();
        }

        private void QuanLyCuaHangDienThoai_Load(object sender, EventArgs e)
        {

        }
    }
}
