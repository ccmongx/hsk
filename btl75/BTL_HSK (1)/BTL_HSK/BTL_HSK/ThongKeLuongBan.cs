using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_HSK
{
    public partial class ThongKeLuongBan : Form
    {
        public ThongKeLuongBan()
        {
            InitializeComponent();
            readView();
        }

        private void readView()
        {
            string constr = ConfigurationManager.ConnectionStrings["btl_hsk"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from thongKeSoLuongDT", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cnn.Open();
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        ad.Fill(tb);
                        gvThongke.DataSource = tb;
                        gvThongke.Columns[0].HeaderText = "Mã điện thoại";
                        gvThongke.Columns[1].HeaderText = "Tên điện thoại";
                        gvThongke.Columns[2].HeaderText = "Hãng điện thoại";
                        gvThongke.Columns[3].HeaderText = "Giá bán";
                        gvThongke.Columns[4].HeaderText = "Tổng bán ra";
                    }
                }
            }
        }

        private void tbTimkiem_TextChanged(object sender, EventArgs e)
        {
            string rowFilter = string.Format("{0} like '{3}' or {1} like '{3}' or {2} like '{3}'", "sMaDT", "sTenDT", "sTenhangDT", "*" + tbTimkiem.Text + "*");
            (gvThongke.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            LocGiaKhoang f2 = new LocGiaKhoang();
            f2.Show();
        }

        private void btnInTheoNV_Click(object sender, EventArgs e)
        {
            LuongBanRaTheoNV tknv = new LuongBanRaTheoNV();
            tknv.Show();
        }

        private void btnInTke_Click(object sender, EventArgs e)
        {
            
        }
    }
}
