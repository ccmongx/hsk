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

namespace Quanlybandienthoai
{
    public partial class Form1 : Form
    {
        string constr = @"Data Source=ZEIWANTANINE;Initial Catalog=Quanlybandienthoai;Integrated Security=True";


        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            string madt = txtsMaDT.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void LoadData()
        {
            string connectionString = @"Data Source=ZEIWANTANINE;Initial Catalog=Quanlybandienthoai;Integrated Security=True";
            string query = "SELECT * FROM PhoneBook";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                txtsMaDT.Text = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                txtiMahang.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                txtsTenDT.Text = dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                txtiSoluong.Text = dataGridView1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                txtiGiaban.Text = dataGridView1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                string v = dataGridView1.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();

                Sua.Enabled = true;
                Xoa.Enabled = true;

                foreach (Control c in this.Controls)
                {
                    if (c is TextBox || c is RadioButton)
                    {
                        c.Enabled = false;
                    }
                }
            }  
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
           
            string query = "DELETE FROM tbl_Dienthoai WHERE sMaDT = @sMaDT";

            using (SqlConnection connection = new SqlConnection(constr))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@sMaDT", txtiGiaban.Text);
                    command.Parameters.AddWithValue("@iMahangDT", txtiMahang.Text);
                    command.Parameters.AddWithValue("@sTenDT", txtsTenDT.Text);
                    command.Parameters.AddWithValue("@iSoluong", txtiSoluong.Text);
                    command.Parameters.AddWithValue("@iGiaban", txtiGiaban.Text);
                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Dữ liệu đã được xóa thành công.");
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa dữ liệu.");
                    }
                }
            }
        }

        private void Tim_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=ZEIWANTANINE;Initial Catalog=Quanlybandienthoai;Integrated Security=True";
            string query = "SELECT * FROM tbl_Dienthoai WHERE sMaDT = @sMaDT";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@sMaDT", txtiGiaban.Text);
                    command.Parameters.AddWithValue("@iMahangDT", txtiMahang.Text);
                    command.Parameters.AddWithValue("@sTenDT", txtsTenDT.Text);
                    command.Parameters.AddWithValue("@iSoluong", txtiSoluong.Text);
                    command.Parameters.AddWithValue("@iGiaban", txtiGiaban.Text);

                    if (string.IsNullOrEmpty(txtsMaDT.Text) == false)
                    {
                        query += " AND sHoten LIKE '%" + txtsMaDT.Text + "%'";
                    }
                    if (string.IsNullOrEmpty(txtiMahang.Text) == false)
                    {
                        query += " AND sDiachi LIKE '%" + txtiMahang.Text + "%'";
                    }
                    if (string.IsNullOrEmpty(txtsTenDT.Text) == false)
                    {
                        query += " AND sTenCoQuan LIKE '%" + txtsTenDT.Text + "%'";
                    }
                    if (string.IsNullOrEmpty(txtiSoluong.Text) == false)
                    {
                        query += " AND sDienthoai LIKE '" + txtiSoluong.Text + "'";
                    }
                    if (string.IsNullOrEmpty(txtiGiaban.Text) == false)
                    {
                        query += " AND sDienthoai LIKE '" + txtiGiaban.Text + "'";
                    }
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = dataTable;
                        MessageBox.Show("Tìm kiếm thành công.");
                    }
                    else
                    {
                        dataGridView1.DataSource = null;
                        MessageBox.Show("Không tìm thấy dữ liệu.");
                    }
                }
            }
        }

        private void Hien_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=ZEIWANTANINE;Initial Catalog=Quanlybandienthoai;Integrated Security=True";
            string query = "SELECT * FROM tbl_Dienthoai";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
            }
        }

        private void Sua_Click(object sender, EventArgs e)
        {
            string query = "UPDATE tbl_Dienthoai SET  iMahangDT = @iMahangDT,sTenDT=@sTenDT,iSoluong=@iSoluong,iGiaban=@iGiaban WHERE sMaDT = @sMaDT";
            using (SqlConnection connection = new SqlConnection(constr))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@sMaDT", txtiGiaban.Text);
                    command.Parameters.AddWithValue("@iMahangDT", txtiMahang.Text);
                    command.Parameters.AddWithValue("@sTenDT", txtsTenDT.Text);
                    command.Parameters.AddWithValue("@iSoluong", txtiSoluong.Text);
                    command.Parameters.AddWithValue("@iGiaban", txtiGiaban.Text);

                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Dữ liệu đã được cập nhật thành công.");
                    }
                    else
                    {
                        MessageBox.Show("Không thể cập nhật dữ liệu.");
                    }
                }
            }
        }

        private void inBiểuMẫu1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report report = new Report();//Report là form
            report.Show();
        }

        private void inBiểuMẫu2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report2 report = new Report2();
            report.Show();
        }

        private void inBiểuMẫuGiáTrongKhoảngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporttrongkhoang report = new Reporttrongkhoang();
            report.Show();
        }

        private void inBiểuMẫuNămThángToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportnamthang report = new Reportnamthang();
            report.Show();
        }

        private void txtInBieuMau_Click(object sender, EventArgs e)
        {

        }

        

        

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKhachHang form = new FormKhachHang();
            form.Show();
        }

        private void Them_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                string sqlDienthoai = "INSERT INTO tbl_Dienthoai (sMaDT,iMahangDT,sTenDT,iSoluong,iGiaban) VAlUES(@sMaDT,@iMahangDT,@sTenDT,@iSoluong,@iGiaban)";
                SqlCommand command = new SqlCommand(sqlDienthoai, cnn);
                command.Parameters.AddWithValue("@sMaDT", txtsMaDT.Text);
                command.Parameters.AddWithValue("@iMahangDT", txtiMahang.Text);
                command.Parameters.AddWithValue("@sTenDT", txtsTenDT.Text);
                command.Parameters.AddWithValue("@iSoluong", txtiSoluong.Text);
                command.Parameters.AddWithValue("@iGiaban", txtiGiaban.Text);

                cnn.Open();
                int rowsAffected = command.ExecuteNonQuery();
                cnn.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Điện thoại đã được thêm thành công vào cơ sở dữ liệu.");
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra khi thêm điện thoại vào cơ sở dữ liệu.");
                }
            }
        }
    }
 }
