using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BTH_QLCHDT
{
    public partial class QLSanPham : Form
    {
        public static String constr = "Data Source=LAPTOP-75EMN83J\\SQLEXPRESS;Initial Catalog=btl_hsk;Integrated Security=True ";
        Boolean check = true;
        public QLSanPham()
        {
            InitializeComponent();
        }

        private void QLSanPham_Load(object sender, EventArgs e)
        {
            HiendsDT();
        }
        private static bool checkDuplicate(string madt, string mahang, string tendt, string soluong, string giaban)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                string procname = "kiemtra";
                using (SqlCommand sqlCommand = new SqlCommand(procname, cnn))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@sMaDT", madt);
                    sqlCommand.Parameters.AddWithValue("@iMahangDT", mahang);
                    sqlCommand.Parameters.AddWithValue("@sTenDT", tendt);
                    sqlCommand.Parameters.AddWithValue("@iSoluong", int.Parse(soluong));
                    sqlCommand.Parameters.AddWithValue("@iGiaban", int.Parse(giaban));
                    cnn.Open();
                    SqlDataReader dataReader = sqlCommand.ExecuteReader();
                    if (dataReader.Read())
                    {
                        return true;
                    }
                    else
                    {
                        //check query da execute
                        return false;
                    }
                }
            }
        }

        private void HiendsDT()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                string procname = "HiendsDT";
                using (SqlCommand cmd = new SqlCommand(procname, cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable("tbl_Dienthoai");
                        dataAdapter.Fill(dataTable);
                        DataView dataView = new DataView(dataTable);
                        dgvQLSanPham.DataSource = dataView;

                    }
                }
            }
        }

        /*private void tbMahang_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxMaHang.Text == "")
            {
                errorProvider1.SetError(textBoxMaHang, "Khong duoc bo trong!");
            }
            else errorProvider1.SetError(textBoxMaHang, "");
        }*/


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (check == true)
            { }
            SqlConnection cnn = new SqlConnection(constr);
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = @"ThemDT";

            cmd.Parameters.AddWithValue("@sMaDT", textBoxMaDT.Text);
            cmd.Parameters.AddWithValue("@imahang", textBoxMaHang.Text);
            cmd.Parameters.AddWithValue("@sTenDT", textBoxTenDT.Text);
            cmd.Parameters.AddWithValue("@iSoluong", int.Parse(textBoxSoLuong.Text));
            cmd.Parameters.AddWithValue("@iGiaban", int.Parse(textBoxGiaBan.Text));

            if (checkDuplicate(textBoxMaDT.Text, textBoxMaHang.Text, textBoxTenDT.Text, textBoxSoLuong.Text, textBoxGiaBan.Text))
            {
                MessageBox.Show("Sản phẩm đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HiendsDT();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            String madt = dgvQLSanPham.CurrentRow.Cells["sMaDT"].Value.ToString();
            SqlConnection cnn = new SqlConnection(constr);
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = @"SuathongtinDT";
            cmd.Parameters.AddWithValue("@sMaDT", madt);
            cmd.Parameters.AddWithValue("@iMahangDT", textBoxMaHang.Text);
            cmd.Parameters.AddWithValue("@sTenDT", textBoxTenDT.Text);
            cmd.Parameters.AddWithValue("@iSoluong", int.Parse(textBoxSoLuong.Text));
            cmd.Parameters.AddWithValue("@iGiaban", int.Parse(textBoxGiaBan.Text));
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HiendsDT();
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                String madt = dgvQLSanPham.CurrentRow.Cells["sMaDT"].Value.ToString();
                SqlConnection cnn = new SqlConnection(constr);
                cnn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = @"XoaDT";
                cmd.Parameters.AddWithValue("@sMaDT", madt);
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HiendsDT();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
