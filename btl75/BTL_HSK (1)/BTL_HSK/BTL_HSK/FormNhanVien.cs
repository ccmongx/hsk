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
    public partial class FormNhanVien : Form
    {
        string constr = ConfigurationManager.ConnectionStrings["btl_hsk"].ConnectionString;
        public FormNhanVien()
        {
            InitializeComponent();
            hien();
        }

        private void Them_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                string sqlDienthoai = "INSERT INTO tbl_Nhanvien (sMaNV,sTenNV,dNgaysinh,sDiachi,fLuongCB,sSdt,fPhuCap) VAlUES(@sMaNV,@sTenNV,@dNgaysinh,@sDiachi,@fLuongCB,@sSdt,@fPhuCap)";
                SqlCommand command = new SqlCommand(sqlDienthoai, cnn);
                command.Parameters.AddWithValue("@sMaNV", txtsMaNV.Text);
                command.Parameters.AddWithValue("@sTenNV", txtsTenNV.Text);
                command.Parameters.AddWithValue("@dNgaysinh", txtdNgaysinh.Text);
                command.Parameters.AddWithValue("@sDiachi", txtsDiachi.Text);
                command.Parameters.AddWithValue("@fLuongCB", txtfLuongCB.Text);
                command.Parameters.AddWithValue("@sSdt", txtsSdt.Text);
                command.Parameters.AddWithValue("@fPhuCap", txtfPhuCap.Text);

                cnn.Open();
                try
                {
                    int rowsAffected = command.ExecuteNonQuery();
                    cnn.Close();
                    MessageBox.Show("Nhân Viên đã được thêm thành công vào cơ sở dữ liệu.");
                    hien();
                }
                catch
                {
                    MessageBox.Show("Có lỗi xảy ra khi thêm Nhân Viên vào cơ sở dữ liệu.");
                }
                if (string.IsNullOrEmpty(dataGridView2.Text))
                {
                    Them.Enabled = false;
                }
                else
                {
                    Them.Enabled = true;
                }

            }
        }

        private void Sua_Click(object sender, EventArgs e)
        {
            string query = "UPDATE tbl_Nhanvien SET sTenNV=@sTenNV,dNgaysinh=@dNgaysinh,sDiachi=@sDiachi,fLuongCB=@fLuongCB,sSdt,fPhuCap=@fPhuCap where sMaNV=@sMaNV";
            using (SqlConnection connection = new SqlConnection(constr))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@sMaNV", txtsMaNV.Text);
                    command.Parameters.AddWithValue("@sTenNV", txtsTenNV.Text);
                    command.Parameters.AddWithValue("@dNgaysinh", txtdNgaysinh.Text);
                    command.Parameters.AddWithValue("@sDiachi", txtsDiachi.Text);
                    command.Parameters.AddWithValue("@fLuongCB", txtfLuongCB.Text);
                    command.Parameters.AddWithValue("@sSdt", txtsSdt.Text);
                    command.Parameters.AddWithValue("@fPhuCap", txtfPhuCap.Text);

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
            string query = "DELETE FROM tbl_Nhanvien WHERE sMaNV = @sMaNV";

            using (SqlConnection connection = new SqlConnection(constr))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@sMaNV", txtsMaNV.Text);
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
            string query = "SELECT * FROM tbl_Nhanvien WHERE 1 = 1";
            using (SqlConnection sqlCon = new SqlConnection(constr))
            {
                sqlCon.Open();
                if (sqlCon.State == ConnectionState.Closed)
                    return;

                if (string.IsNullOrEmpty(txtsMaNV.Text) == false)
            {
                query += " AND sMaNV LIKE '%" + txtsMaNV.Text + "%'";
            }
            if (string.IsNullOrEmpty(txtsTenNV.Text) == false)
            {
                query += " AND sTenNV LIKE '%" + txtsTenNV.Text + "%'";
            }
            if (string.IsNullOrEmpty(txtdNgaysinh.Text) == false)
            {
                query += " AND dNgaysinh LIKE '%" + txtdNgaysinh.Text + "%'";
            }
            if (string.IsNullOrEmpty(txtsDiachi.Text) == false)
            {
                query += " AND sDiachi LIKE '" + txtsDiachi.Text + "'";
            }
            if (string.IsNullOrEmpty(txtfLuongCB.Text) == false)
            {
                query += " AND fLuongCB LIKE '" + txtfLuongCB.Text + "'";
            }
            if (string.IsNullOrEmpty(txtsSdt.Text) == false)
            {
                query += " AND sSdt LIKE '%" + txtsSdt.Text + "%'";
            }
            if (string.IsNullOrEmpty(txtfPhuCap.Text) == false)
            {
                query += " AND fPhuCap LIKE '%" + txtfPhuCap.Text + "%'";
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
                txtsMaNV.Text = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                txtsTenNV.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                txtdNgaysinh.Text = dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                txtsDiachi.Text = dataGridView1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                txtsSdt.Text = dataGridView1.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                txtfLuongCB.Text = dataGridView1.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
                txtfPhuCap.Text = dataGridView1.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
                //string v = dataGridView1.Rows[e.RowIndex].Cells[7].FormattedValue.ToString();

                Sua.Enabled = true;
                Xoa.Enabled = true;
                Them.Enabled = false;
                btnBoqua.Enabled = true;
                txtsMaNV.Enabled = false;
            }
        }

        private void hien()
        {
            string query = "SELECT * FROM tbl_Nhanvien";

            using (SqlConnection connection = new SqlConnection(constr))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                    dataGridView1.Columns[0].HeaderText = "Mã nhân viên";
                    dataGridView1.Columns[1].HeaderText = "Tên nhân viên";
                    dataGridView1.Columns[2].HeaderText = "Địa chỉ";
                    dataGridView1.Columns[3].HeaderText = "Ngày sinh";
                    dataGridView1.Columns[4].HeaderText = "Số điện thoại";
                    dataGridView1.Columns[5].HeaderText = "Lương";
                    dataGridView1.Columns[6].HeaderText = "Phụ cấp";
                }
            }
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            txtsMaNV.Enabled = true;
            Them.Enabled = true;
            Sua.Enabled = false;
            Xoa.Enabled = false;
            btnBoqua.Enabled = false;
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetNhanVien.tbl_Nhanvien' table. You can move, or remove it, as needed.
            this.tbl_NhanvienTableAdapter.Fill(this.dataSetNhanVien.tbl_Nhanvien);

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
         

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=LAPTOP-75EMN83J\\SQLEXPRESS;Initial Catalog=btl_hsk;Integrated Security=True");
            string query = "SELECT * FROM tblThongTin";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView2.DataSource = dataTable;

/*            if (dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView2.CurrentRow.Selected = true;
                ID.Text = dataGridView2.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                sThongTin.Text = dataGridView2.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();

                Sua.Enabled = true;
                Xoa.Enabled = true;
                Them.Enabled = false;
                btnBoqua.Enabled = true;
*/            }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
/*            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-75EMN83J\\SQLEXPRESS;Initial Catalog=btl_hsk;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tblThongTin", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
*/
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(richTextBox1.Text))
            {
                Them.Enabled = false;
            }
            else
            {
                Them.Enabled = true;
            }
        }
    }
    
    }
