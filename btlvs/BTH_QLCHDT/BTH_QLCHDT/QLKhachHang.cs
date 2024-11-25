using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH_QLCHDT
{
    public partial class QLKhachHang : Form
    {
        public static String constr = "Data Source=LAPTOP-75EMN83J\\SQLEXPRESS;Initial Catalog=btl_hsk;Integrated Security=True ";
        Boolean check = true;
        public QLKhachHang()
        {
            InitializeComponent();
        }

        private void textBoxTenDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void QLKhachHang_Load(object sender, EventArgs e)
        {
            HiendsKH();
        }

        private void HiendsKH()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                string procname = "HiendsKH";
                using (SqlCommand cmd = new SqlCommand(procname, cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable("tbl_khachhang");
                        dataAdapter.Fill(dataTable);
                        DataView dataView = new DataView(dataTable);
                        dgvQLKhachHang.DataSource = dataView;

                    }
                }
            }
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            /*            string sql = "insert into tbl_khachhang values " +
                "( '" + textBoxMaKH.Text + "', '" + textBoxTenKH.Text + "',  '" + textBoxNgaySinhKH.Text + "'," +
                "  '" + textBoxDiaChiKH.Text + "',  '" + textBoxGioiTinhKH.Text + "',  '" + textBoxSDT.Text + "' )";
                        fct.Command(sql);
                        QLKhachHang_Load(sender, e);

            */
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            /*            string sql = "update tbl_khachhang set " +
                "sMaKH = '" + textBoxMaKH.Text + "', sTenkhachhang = '" + textBoxTenKH.Text + "',  dNgaysinh = '" + textBoxNgaySinhKH.Text + "'," +
                " sDiachi =  '" + textBoxDiaChiKH.Text + "', sGioitinh =  '" + textBoxGioiTinhKH.Text + "' " + "', sSdt =  '" + textBoxSDT.Text + "' " +
                "where sMaKH = '" + textBoxMaKH.Text + "' ";

                        fct.Command(sql);
                        QLKhachHang_Load(sender, e);
            */
        }

        private void dgvQLKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*            textBoxMaKH.Text = dgvQLKhachHang.SelectedRows[0].Cells[0].Value.ToString();
                        textBoxTenKH.Text = dgvQLKhachHang.SelectedRows[0].Cells[1].Value.ToString();
                        textBoxNgaySinhKH.Text = dgvQLKhachHang.SelectedRows[0].Cells[2].Value.ToString();
                        textBoxDiaChiKH.Text = dgvQLKhachHang.SelectedRows[0].Cells[3].Value.ToString();
                        textBoxGioiTinhKH.Text = dgvQLKhachHang.SelectedRows[0].Cells[4].Value.ToString();
                        textBoxSDT.Text = dgvQLKhachHang.SelectedRows[0].Cells[5].Value.ToString();        }
            */
        }
    }
}
