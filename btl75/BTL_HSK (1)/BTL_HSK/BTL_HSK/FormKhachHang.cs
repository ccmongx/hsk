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
    public partial class FormKhachHang : Form
    {
        string constr = ConfigurationManager.ConnectionStrings["btl_hsk"].ConnectionString;
        public FormKhachHang()
        {
            InitializeComponent();
            hien();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                string sqlDienthoai = "INSERT INTO tbl_khachhang (sMaKH,sTenkhachhang,dNgaysinh,sDiachi,sGioitinh,sSdt) VAlUES(@sMaKH,@sTenkhachhang,@dNgaysinh,@sDiachi,@sGioitinh,@sSdt)";
                SqlCommand command = new SqlCommand(sqlDienthoai, cnn);
                command.Parameters.AddWithValue("@sMaKH", txtsMaKH.Text);
                command.Parameters.AddWithValue("@sTenkhachhang", txtsTenkhachhang.Text);
                command.Parameters.AddWithValue("@dNgaysinh", txtdNgaysinh.Text);
                command.Parameters.AddWithValue("@sDiachi", txtsDiachi.Text);
                command.Parameters.AddWithValue("@sSdt", txtsSdt.Text);
                if (rdNam.Checked == true)
                    command.Parameters.AddWithValue("@sGioitinh", "Nam");
                else if (rdNu.Checked == true)
                    command.Parameters.AddWithValue("@sGioitinh", "Nu");
                cnn.Open();

                try
                {
                    int rowsAffected = command.ExecuteNonQuery();
                    cnn.Close();
                    MessageBox.Show("Khách hàng đã được thêm thành công vào cơ sở dữ liệu.");
                    hien();
                }
                catch
                {
                    MessageBox.Show("Không thể thêm khách hàng.");
                }
            }
        }

        private void Sua_Click(object sender, EventArgs e)
        {
            string query = "UPDATE tbl_khachhang SET sTenkhachhang=@sTenkhachhang,dNgaysinh=@dNgaysinh,sDiachi=@sDiachi,sGioitinh=@sGioitinh,sSdt=@sSdt where sMaKH=@sMaKH";
            using (SqlConnection connection = new SqlConnection(constr))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@sMaKH", txtsMaKH.Text);
                    command.Parameters.AddWithValue("@sTenkhachhang", txtsTenkhachhang.Text);
                    command.Parameters.AddWithValue("@dNgaysinh", txtdNgaysinh.Text);
                    command.Parameters.AddWithValue("@sDiachi", txtsDiachi.Text);
                    if (rdNam.Checked == true)
                        command.Parameters.AddWithValue("@sGioitinh", "Nam");
                    else if (rdNu.Checked == true)
                        command.Parameters.AddWithValue("@sGioitinh", "Nu");
                    connection.Open();
                    command.Parameters.AddWithValue("@sSdt", txtsSdt.Text);
                    try
                    {
                        int result = command.ExecuteNonQuery();
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
            string query = "DELETE FROM tbl_khachhang WHERE sMaKH = @sMaKH";

            using (SqlConnection connection = new SqlConnection(constr))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@sMaKH", txtsMaKH.Text);
                    connection.Open();
                    try
                    {
                        int result = command.ExecuteNonQuery();
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
            string connectionString = @"Data Source=LAPTOP-75EMN83J\SQLEXPRESS;Initial Catalog=btl_hsk;Integrated Security=True";
            string query = "SELECT * FROM tbl_khachhang WHERE 1 = 1";
            using (SqlConnection sqlCon = new SqlConnection(constr))
            {
                sqlCon.Open();
                if (sqlCon.State == ConnectionState.Closed)
                    return;

                if (string.IsNullOrEmpty(txtsMaKH.Text) == false)
            {
                query += " AND sMaKH LIKE '%" + txtsMaKH.Text + "%'";
            }
            if (string.IsNullOrEmpty(txtsTenkhachhang.Text) == false)
            {
                query += " AND sTenkhachhang LIKE '%" + txtsTenkhachhang.Text + "%'";
            }
            if (string.IsNullOrEmpty(txtdNgaysinh.Text) == false)
            {
                query += " AND dNgaysinh LIKE '%" + txtdNgaysinh.Text + "%'";
            }
            if (string.IsNullOrEmpty(txtsDiachi.Text) == false)
            {
                query += " AND sDiachi LIKE '" + txtsDiachi.Text + "'";
            }
            if (string.IsNullOrEmpty(gbGioitinh.Text) == false)
            {
                if (rdNam.Checked == true)
                    query += " AND sGioitinh LIKE 'Nam' or sGioitinh LIKE 'nam'";
                else if (rdNu.Checked == true)
                    query += " AND sGioitinh LIKE 'Nu' sGioitinh LIKE 'nam'";
            }
            if (string.IsNullOrEmpty(txtsSdt.Text) == false)
            {
                query += " AND sSdt LIKE '%" + txtsSdt.Text + "%'";
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

        private void hien()
        {
            string query = "SELECT * FROM tbl_khachhang";

            using (SqlConnection connection = new SqlConnection(constr))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                    dataGridView1.Columns[0].HeaderText = "Mã khách hàng";
                    dataGridView1.Columns[1].HeaderText = "Tên khách hàng";
                    dataGridView1.Columns[2].HeaderText = "Ngày sinh";
                    dataGridView1.Columns[3].HeaderText = "Địa chỉ";
                    dataGridView1.Columns[4].HeaderText = "Giới tính";
                    dataGridView1.Columns[5].HeaderText = "Số điện thoại";
                }
            }
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            txtsMaKH.Enabled = true;
            Sua.Enabled = false;
            Xoa.Enabled = false;
            Them.Enabled = true;
            btnBoqua.Enabled = false;
            btnBoqua.Enabled = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                txtsMaKH.Text = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                txtsTenkhachhang.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                txtdNgaysinh.Text = dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                txtsDiachi.Text = dataGridView1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                if (dataGridView1.Rows[e.RowIndex].Cells[4].FormattedValue.ToString() == "Nam" || dataGridView1.Rows[e.RowIndex].Cells[4].FormattedValue.ToString() == "nam")
                    rdNam.Checked = true;
                else
                    rdNu.Checked = true;
                txtsSdt.Text = dataGridView1.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
                //string v = dataGridView1.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();

                Sua.Enabled = true;
                Xoa.Enabled = true;
                Them.Enabled = false;
                btnBoqua.Enabled = true;
                txtsMaKH.Enabled = false;
            }
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {

        }
    }
}
