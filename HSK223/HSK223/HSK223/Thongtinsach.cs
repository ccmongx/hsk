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

namespace HSK223
{
    public partial class Thongtinsach : Form
    {
        public Thongtinsach()
        {
            InitializeComponent();
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMasach.Text = dataGridView1.CurrentRow.Cells["sMasach"].Value.ToString();
            txtTieude.Text = dataGridView1.CurrentRow.Cells["sTieude"].Value.ToString();
            iSoluong.Text = dataGridView1.CurrentRow.Cells["iSoluong"].Value.ToString();
            fDongia.Text = dataGridView1.CurrentRow.Cells["fDongia"].Value.ToString();
            txtMasach.Enabled = false;
            txtTieude.Enabled = true;
            iSoluong.Enabled = true;
            fDongia.Enabled = true;
        }

        private void Thongtinsach_Load(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["HSK223"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM vw_HienSach", cnn))
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        ad.Fill(tb);
                        dataGridView1.DataSource = tb;
                    }
                }
            }

        }

        private void fDongia_Validating(object sender, CancelEventArgs e)
        {
            if (fDongia.Text == "")
            {
                errorProvider1.SetError(fDongia, "Ban phai nhap don gia");
            }
            else
            {
                try
                {
                    int i = int.Parse(fDongia.Text);
                    if (i <= 0)
                    {
                        errorProvider1.SetError(fDongia, "Don gia phai lon hon 0");
                    }
                    else
                        errorProvider1.SetError(fDongia, "");
                }
                catch
                {
                    errorProvider1.SetError(fDongia, "Don gia phai la so!");
                }
            }
        }

        private void iSoluong_Validated(object sender, EventArgs e)
        {
            if (iSoluong.Text == "")
            {
                errorProvider2.SetError(iSoluong, "Ban phai nhap so luong");
            }
            else
            {
                try
                {
                    int i = int.Parse(iSoluong.Text);
                    if (i <= 0)
                    {
                        errorProvider2.SetError(iSoluong, "So luong phai lon hon 0");
                    }
                    else
                        errorProvider2.SetError(iSoluong, "");
                }
                catch
                {
                    errorProvider2.SetError(iSoluong, "So luong phai la so!");
                }
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["HSK223"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                try
                {
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "sp_ThemSach";
                        cmd.Parameters.AddWithValue("@masach", txtMasach.Text);
                        cmd.Parameters.AddWithValue("@tieude", txtTieude.Text);
                        cmd.Parameters.AddWithValue("@soluong", iSoluong.Text);
                        cmd.Parameters.AddWithValue("@dongia", fDongia.Text);
                        cnn.Open();
                        int i = cmd.ExecuteNonQuery();
                        cnn.Close();
                        Thongtinsach_Load(sender, e);
                        MessageBox.Show("Them thanh cong", "Insert", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Them bi loi" + ex.Message, "Insert", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }

            }

        }

        //Sua don gia
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["HSK223"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                try
                {
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "sp_SuaDonGia";
                        cmd.Parameters.AddWithValue("@masach", txtMasach.Text);
                        cmd.Parameters.AddWithValue("@tieude", txtTieude.Text);
                        cmd.Parameters.AddWithValue("@soluong", iSoluong.Text);
                        cmd.Parameters.AddWithValue("@dongia", fDongia.Text);
                        cnn.Open();
                        int i = cmd.ExecuteNonQuery();
                        cnn.Close();
                        Thongtinsach_Load(sender, e);
                        MessageBox.Show("Sua thanh cong", "Insert", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sua bi loi" + ex.Message, "Insert", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }

            }
        }

    }



}






