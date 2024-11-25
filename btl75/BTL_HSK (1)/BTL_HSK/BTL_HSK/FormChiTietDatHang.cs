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

    public partial class FormChiTietDatHang : Form
    {
        string constr = ConfigurationManager.ConnectionStrings["btl_hsk"].ConnectionString;
        public FormChiTietDatHang()
        {
            InitializeComponent();
            hienDSDT();
            hienDSDH();
            hien();
        }

        private DataTable layDSDT()
        {
            string constr = ConfigurationManager.ConnectionStrings["btl_hsk"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from tbl_Dienthoai", cnn))
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

        private void hienDSDT()
        {
            DataTable t = layDSDT();
            DataView v = new DataView(t);
            v.Sort = "sMaDT";
            cbDienthoai.DataSource = v;
            cbDienthoai.DisplayMember = "sTenDT";
            cbDienthoai.ValueMember = "sMaDT";
        }

        private DataTable layDSDH()
        {
            string constr = ConfigurationManager.ConnectionStrings["btl_hsk"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from tbl_Dathang", cnn))
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

        private void hienDSDH()
        {
            DataTable t = layDSDH();
            DataView v = new DataView(t);
            v.Sort = "sMadathang";
            cbMaDH.DataSource = v;
            cbMaDH.DisplayMember = "sMadathang";
            cbMaDH.ValueMember = "sMadathang";
        }

        private void Them_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                string sqlDienthoai = "INSERT INTO tbl_Chitietdathang (sMadathang,sMaDT,iSoluong) VAlUES(@sMadathang,@sMaDT,@iSoluong)";
                SqlCommand command = new SqlCommand(sqlDienthoai, cnn);
                command.Parameters.AddWithValue("@sMadathang", cbMaDH.SelectedValue);
                command.Parameters.AddWithValue("@sMaDT", cbDienthoai.SelectedValue);
                command.Parameters.AddWithValue("@iSoluong", txtiSoluong.Text);
                cnn.Open();
                try
                {
                    int rowsAffected = command.ExecuteNonQuery();
                    cnn.Close();
                    MessageBox.Show("Chi Tiết Đơn Đặt đã được thêm thành công vào cơ sở dữ liệu.");
                    hien();
                }
                catch
                {
                    MessageBox.Show("Có lỗi xảy ra khi thêm Chi Tiết Đơn Đặt vào cơ sở dữ liệu.");
                }
            }
            hien();
        }

        private void Sua_Click(object sender, EventArgs e)
        {
            string query = "UPDATE tbl_Chitietdathang SET iSoluong=@iSoluong where sMadathang=@sMadathang and sMaDT=@sMaDT";
            using (SqlConnection connection = new SqlConnection(constr))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@sMadathang", cbMaDH.SelectedValue);
                    command.Parameters.AddWithValue("@sMaDT", cbDienthoai.SelectedValue);
                    command.Parameters.AddWithValue("@iSoluong", txtiSoluong.Text);
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
            string query = "DELETE FROM tbl_Chitietdathang WHERE sMadathang = @sMadathang and sMaDT = @sMaDT";

            using (SqlConnection connection = new SqlConnection(constr))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@sMadathang", cbMaDH.SelectedValue);
                    command.Parameters.AddWithValue("@sMaDT", cbDienthoai.SelectedValue);
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
            hien();
        }

        private void hien()
        {
            string query = "SELECT * FROM tbl_Chitietdathang";

            using (SqlConnection connection = new SqlConnection(constr))
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

        private void TimKiem_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM tbl_Chitietdathang WHERE 1 = 1";
            using (SqlConnection sqlCon = new SqlConnection(constr))
            {
                sqlCon.Open();
                if (sqlCon.State == ConnectionState.Closed)
                    return;

                if (string.IsNullOrEmpty(cbDienthoai.Text) == false)
            {
                query += " AND sMaDT LIKE '%" + cbDienthoai.SelectedValue + "%'";
            }
            if (string.IsNullOrEmpty(cbMaDH.Text) == false)
            {
                query += " AND sMadathang LIKE '%" + cbMaDH.SelectedValue + "%'";
            }
            if (string.IsNullOrEmpty(txtiSoluong.Text) == false)
            {
                query += " AND iSoluong LIKE '" + txtiSoluong.Text + "'";
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
            txtiSoluong.Enabled = true;
            cbMaDH.Enabled = false;
            cbDienthoai.Enabled = false;

            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                cbDienthoai.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                cbMaDH.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                txtiSoluong.Text = dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();

                //string v = dataGridView1.Rows[e.RowIndex].Cells[7].FormattedValue.ToString();
                Them.Enabled = false;
                Sua.Enabled = true;
                Xoa.Enabled = true;
                btnBoqua.Enabled = true;
            }
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            cbMaDH.Enabled = true;
            cbDienthoai.Enabled = true;
            txtiSoluong.Text = "";
            Them.Enabled = true;
            Sua.Enabled = false;
            Xoa.Enabled = false;
            btnBoqua.Enabled = false;
        }

        private void FormChiTietDatHang_Load(object sender, EventArgs e)
        {

        }
    }
}
