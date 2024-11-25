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
    public partial class FormDatHang : Form
    {
        string constr = ConfigurationManager.ConnectionStrings["btl_hsk"].ConnectionString;
        public FormDatHang()
        {
            InitializeComponent();
            hienDSKH();
            hienDSNV();
            hien();
        }

        private DataTable layDSKH()
        {
            string constr = ConfigurationManager.ConnectionStrings["btl_hsk"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from tbl_khachhang", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        ad.Fill(tb);
                        return tb;
                    }
                }
            }
        }

        private void hienDSKH()
        {
            DataTable t = layDSKH();
            DataView v = new DataView(t);
            v.Sort = "sMaKH";
            cbKhachhang.DataSource = v;
            cbKhachhang.DisplayMember = "sTenkhachhang";
            cbKhachhang.ValueMember = "sMaKH";
        }

        private DataTable layDSNV()
        {
            string constr = ConfigurationManager.ConnectionStrings["btl_hsk"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from tbl_Nhanvien", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        ad.Fill(tb);
                        return tb;
                    }
                }
            }
        }

        private void hienDSNV()
        {
            DataTable t = layDSNV();
            DataView v = new DataView(t);
            v.Sort = "iMaNV";
            cbNhanvien.DataSource = v;
            cbNhanvien.DisplayMember = "sTenNV";
            cbNhanvien.ValueMember = "iMaNV";
        }


        private void Them_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                string sqlDienthoai = "INSERT INTO tbl_DatHang (iMaNV,sMaKH,dNgaydat,sMadathang) VAlUES(@sMaNV,@sMaKH,@dNgaydat,@sMadathang)";
                SqlCommand command = new SqlCommand(sqlDienthoai, cnn);
                command.Parameters.AddWithValue("@sMaNV", cbNhanvien.SelectedValue);
                command.Parameters.AddWithValue("@sMaKH", cbKhachhang.SelectedValue);
                command.Parameters.AddWithValue("@dNgaydat", dpNgaydat.Value);
                command.Parameters.AddWithValue("@sMadathang", txtsMadathang.Text);
                

                cnn.Open();
                try
                {
                    int rowsAffected = command.ExecuteNonQuery();
                    cnn.Close();
                    MessageBox.Show("Đơn Đặt đã được thêm thành công vào cơ sở dữ liệu.");
                    hien();
                }
                catch
                {
                    MessageBox.Show("Có lỗi xảy ra khi thêm Đơn Đặt vào cơ sở dữ liệu.");
                }
            }
        }

        private void Sua_Click(object sender, EventArgs e)
        {
            string query = "UPDATE tbl_DatHang SET  sMaNv=@sMaNV,sMaKH=@sMaKH,dNgaydat=@dNgaydat where sMadathang=@sMadathang";
            using (SqlConnection connection = new SqlConnection(constr))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@sMadathang", txtsMadathang.Text);
                    command.Parameters.AddWithValue("@sMaNV", cbNhanvien.SelectedValue);
                    command.Parameters.AddWithValue("@sMaKH", cbKhachhang.SelectedValue);
                    command.Parameters.AddWithValue("@dNgaydat", dpNgaydat.Value.ToString("yyyy-mm-dd"));
                    command.Parameters.AddWithValue("@sMadathang", txtsMadathang.Text);

                    connection.Open();
                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("Dữ liệu đã được cập nhật thành công.");
                        hien();
                    }
                    catch
                    {
                        MessageBox.Show("Không thể cập nhật dữ liệu.");
                    }
                }
            }
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM tbl_DatHang WHERE sMadathang = @sMadathang";

            using (SqlConnection connection = new SqlConnection(constr))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@sMadathang", txtsMadathang.Text);
                    connection.Open();
                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("Dữ liệu đã được xóa thành công.");
                        hien();
                    }
                    catch
                    {
                        MessageBox.Show("Không thể xóa dữ liệu.");
                    }
                }
            }
        }

        private void TimKiem_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM tbl_DatHang WHERE 1 = 1";
            using (SqlConnection sqlCon = new SqlConnection(constr))
            {
                sqlCon.Open();
                if (sqlCon.State == ConnectionState.Closed)
                    return;

                if (string.IsNullOrEmpty(cbNhanvien.Text) == false)
            {
                query += " AND sMaNV LIKE '%" + cbNhanvien.SelectedValue + "%'";
            }
            if (string.IsNullOrEmpty(cbKhachhang.Text) == false)
            {
                query += " AND sMaKH LIKE '%" + cbKhachhang.SelectedValue + "%'";
            }
            if (string.IsNullOrEmpty(dpNgaydat.Text) == false)
            {
                query += " AND dNgaydat LIKE '%" + dpNgaydat.Value.ToString("yyyy-mm-dd") + "%'";
            }
            if (string.IsNullOrEmpty(txtsMadathang.Text) == false)
            {
                query += " AND sMadathang LIKE '" + txtsMadathang.Text + "'";
            }

            SqlCommand cmd = new SqlCommand(query, sqlCon);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable tbl = new DataTable();
            tbl.Load(reader);
            dataGridView1.DataSource = tbl;
            sqlCon.Close();
            Console.WriteLine(query);
        }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                cbNhanvien.Text = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                cbKhachhang.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                txtsMadathang.Text = dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                dpNgaydat.Text = dataGridView1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                //string v = dataGridView1.Rows[e.RowIndex].Cells[7].FormattedValue.ToString();

                Them.Enabled = false;
                Sua.Enabled = true;
                Xoa.Enabled = true;
                btnBoqua.Enabled = true;
                txtsMadathang.Enabled = false;
            }
        }

        private void hien()
        {
            string query = "SELECT sMadathang, sTenkhachhang, sTenNV, dNgaydat, iTongtien FROM tbl_Dathang join tbl_Nhanvien on tbl_Nhanvien.iMaNV = tbl_Dathang.iMaNV" +
                " join tbl_Khachhang on tbl_Khachhang.sMaKH = tbl_Dathang.sMaKH";

            using (SqlConnection connection = new SqlConnection(constr))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                    dataGridView1.Columns[0].HeaderText = "Mã đặt hàng";
                    dataGridView1.Columns[1].HeaderText = "Mã khách hàng";
                    dataGridView1.Columns[2].HeaderText = "Mã nhân viên";
                    dataGridView1.Columns[3].HeaderText = "Ngày đặt";
                    dataGridView1.Columns[4].HeaderText = "Tổng tiền";
                }
            }
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            txtsMadathang.Enabled = true;
            Them.Enabled = true;
            Sua.Enabled = false;
            Xoa.Enabled = false;
            btnBoqua.Enabled = false;
        }
    }
}
