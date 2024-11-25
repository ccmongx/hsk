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
    public partial class FormDienThoai : Form
    {
        string constr = ConfigurationManager.ConnectionStrings["btl_hsk"].ConnectionString;


        public FormDienThoai()
        {
            InitializeComponent();
            hienDSHang();
            hien();
        }

        private DataTable layDSHang()
        {
            string constr = ConfigurationManager.ConnectionStrings["btl_hsk"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from tbl_HangDT", cnn))
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

        private void hienDSHang()
        {
            DataTable t = layDSHang();
            DataView v = new DataView(t);
            v.Sort = "iMahangDT";
            cbHang.DataSource = v;
            cbHang.DisplayMember = "sTenhangDT";
            cbHang.ValueMember = "iMahangDT";
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
           
            string query = "DELETE FROM tbl_Dienthoai WHERE sMaDT = @sMaDT";

            using (SqlConnection connection = new SqlConnection(constr))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@sMaDT", txtsMaDT.Text);
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

        private void Tim_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM tbl_Dienthoai WHERE 1 = 1";
            using (SqlConnection sqlCon = new SqlConnection(constr))
            {
                sqlCon.Open();
                if (sqlCon.State == ConnectionState.Closed)
                    return;
                if (string.IsNullOrEmpty(txtsMaDT.Text) == false)
                {
                    query += " AND sMaDT LIKE '%" + txtsMaDT.Text + "%'";
                }
                if (string.IsNullOrEmpty(cbHang.Text) == false)
                {
                    query += " AND iMahangDT LIKE '%" + cbHang.SelectedValue + "%'";
                }
                if (string.IsNullOrEmpty(txtsTenDT.Text) == false)
                {
                    query += " AND sTenDT LIKE '%" + txtsTenDT.Text + "%'";
                }
                if (string.IsNullOrEmpty(txtiSoluong.Text) == false)
                {
                    query += " AND iSoluong LIKE '" + txtiSoluong.Text + "'";
                }
                if (string.IsNullOrEmpty(txtiGiaban.Text) == false)
                {
                    query += " AND iGiaban LIKE '" + txtiGiaban.Text + "'";
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

        private void Sua_Click(object sender, EventArgs e)
        {
            string query = "UPDATE tbl_Dienthoai SET  iMahangDT = @iMahangDT,sTenDT=@sTenDT,iSoluong=@iSoluong,iGiaban=@iGiaban WHERE sMaDT = @sMaDT";
            using (SqlConnection connection = new SqlConnection(constr))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@sMaDT", txtiGiaban.Text);
                    command.Parameters.AddWithValue("@iMahangDT", cbHang.SelectedValue);
                    command.Parameters.AddWithValue("@sTenDT", txtsTenDT.Text);
                    command.Parameters.AddWithValue("@iSoluong", txtiSoluong.Text);
                    command.Parameters.AddWithValue("@iGiaban", txtiGiaban.Text);

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

        private void Them_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                string sqlDienthoai = "INSERT INTO tbl_Dienthoai (sMaDT,iMahangDT,sTenDT,iSoluong,iGiaban) VAlUES(@sMaDT,@iMahangDT,@sTenDT,@iSoluong,@iGiaban)";
                SqlCommand command = new SqlCommand(sqlDienthoai, cnn);
                command.Parameters.AddWithValue("@sMaDT", txtsMaDT.Text);
                command.Parameters.AddWithValue("@iMahangDT", cbHang.SelectedValue);
                command.Parameters.AddWithValue("@sTenDT", txtsTenDT.Text);
                command.Parameters.AddWithValue("@iSoluong", txtiSoluong.Text);
                command.Parameters.AddWithValue("@iGiaban", txtiGiaban.Text);

                cnn.Open();
                try
                {
                    int rowsAffected = command.ExecuteNonQuery();
                    cnn.Close();
                    MessageBox.Show("Điện thoại đã được thêm thành công vào cơ sở dữ liệu.");
                    hien();
                }
                catch
                {
                    MessageBox.Show("Có lỗi xảy ra khi thêm điện thoại vào cơ sở dữ liệu.");
                }
            }
        }

        private void hien()
        {
            string query = "SELECT sMaDT, sTenhangDT, sTenDT, iSoluong, iGiaban FROM tbl_Dienthoai join tbl_HangDT on tbl_Dienthoai.iMahangDT = tbl_HangDT.iMahangDT";

            using (SqlConnection connection = new SqlConnection(constr))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                    dataGridView1.Columns[0].HeaderText = "Mã điện thoại";
                    dataGridView1.Columns[1].HeaderText = "Hãng điện thoại";
                    dataGridView1.Columns[2].HeaderText = "Tên điện thoại";
                    dataGridView1.Columns[3].HeaderText = "Số lượng";
                    dataGridView1.Columns[4].HeaderText = "Giá bán";
                }
            }
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            txtsMaDT.Enabled = true;
            Them.Enabled = true;
            Sua.Enabled = false;
            Xoa.Enabled = false;
            btnBoqua.Enabled = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                txtsMaDT.Text = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                cbHang.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                txtsTenDT.Text = dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                txtiSoluong.Text = dataGridView1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                txtiGiaban.Text = dataGridView1.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                //string v = dataGridView1.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();

                Sua.Enabled = true;
                Xoa.Enabled = true;
                Them.Enabled = false;
                btnBoqua.Enabled = true;
                txtsMaDT.Enabled = false;

                foreach (Control c in this.Controls)
                {
                    if (c is TextBox || c is RadioButton)
                    {
                        c.Enabled = false;
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
 }
