using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLHSK
{
    public partial class Form1 : Form
    {
        private SqlConnection con = new SqlConnection();
        private DataTable dsnv = new DataTable();
        private DataTable checknv = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            con.Open();
            string query = "Select * from tbl_NhanVien";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adt = new SqlDataAdapter();
            adt.SelectCommand = cmd;
            dsnv.Clear();
            adt.Fill(dsnv);
            if (dsnv.Rows.Count < 0)
            {
                MessageBox.Show("khong co thong tin");
            }
            else
            {
                dgv_dsnv.DataSource = dsnv;
            }
            con.Close();
        }

        private void dgv_dsnv_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(tb_ma, null);
            int index = dgv_dsnv.CurrentRow.Index;
            tb_ma.Text = dsnv.Rows[index][0].ToString();
            tb_ten.Text = dsnv.Rows[index][1].ToString();
            tb_dc.Text = dsnv.Rows[index][2].ToString();
            dtp_ns.Text = dsnv.Rows[index][3].ToString();
            tb_sdt.Text = dsnv.Rows[index][4].ToString();
            tb_lcb.Text = dsnv.Rows[index][5].ToString();
            tb_pc.Text = dsnv.Rows[index][6].ToString();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                con.Open();
                if(!String.IsNullOrEmpty(tb_ma.Text))
                {
                    string manv = tb_ma.Text;
                    string query_select = $"Select * from tbl_NhanVien where iMaNV ='{manv}'";
                    SqlCommand cmd = new SqlCommand(query_select, con);
                    SqlDataAdapter adt = new SqlDataAdapter();
                    adt.SelectCommand = cmd;
                    checknv.Clear();
                    adt.Fill(checknv);
                    if(checknv.Rows.Count > 0 )
                    {
                        errorProvider1.SetError(tb_ma, "Mã sinh viên không được để trống");
                    }
                    else
                    {
                        string query = $"insert into tblNhanVien values ('{Convert.ToInt32(tb_ma.Text)}',N'{tb_ten.Text}',N'{tb_dc.Text}','{dtp_ns.Text}','{tb_sdt.Text}','{tb_lcb.Text}','{tb_pc.Text}')";
                        SqlCommand cmd_ins = new SqlCommand(query, con);
                        cmd_ins.ExecuteNonQuery();
                    }
                    reload();
                }
                else
                {
                    errorProvider1.SetError(tb_ma, "Mã sinh viên không được để trống");
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
            loadData();
        }

        private void reload()
        {
            tb_ma.Clear();
            tb_ten.Clear();
            tb_dc.Clear();
            tb_sdt.Clear();
            tb_lcb.Clear();
            tb_pc.Clear();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            loadData();
          
        }

   /*     private void bt_them_TextChanged(object sender, EventArgs e)
        {
            bt_them.Enabled = true;
            if(String.IsNullOrEmpty(tb_ma.Text))
            {
                bt_them.Enabled = false;
            }
        }
   */
        private void tb_ma_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(tb_ma.Text))
            {
                errorProvider1.SetError(tb_ma, "Mã sinh viên không được để trống");
            }
            else
            {
                errorProvider1.SetError(tb_ma,null);
            } 
        }


        private void bt_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                con.Open();
                SqlCommand cmd = new SqlCommand("xoa_sv", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add("@ma",SqlDbType.Int).Value = Convert.ToInt32(tb_ma.Text);
                cmd.ExecuteNonQuery();
                reload();
            }
            catch ( Exception ex)
            {
                MessageBox.Show("Không xóa được !" );
            }
            finally { con.Close(); } 
            loadData();
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                con.Open();
                SqlCommand cmd = new SqlCommand("sua_nv", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add("@ma", SqlDbType.Int).Value = Convert.ToInt32(tb_ma.Text);
                cmd.Parameters.Add("@ten", SqlDbType.NVarChar).Value = (tb_ten.Text);
                cmd.Parameters.Add("@dc", SqlDbType.NVarChar).Value =(tb_dc.Text);
                cmd.Parameters.Add("@ns", SqlDbType.Date).Value = Convert.ToDateTime(dtp_ns.Text);
                cmd.Parameters.Add("@sdt", SqlDbType.VarChar).Value = (tb_sdt.Text);
                cmd.Parameters.Add("@luongcb", SqlDbType.Float).Value = Convert.ToDouble(tb_lcb.Text);
                cmd.Parameters.Add("@pc", SqlDbType.Float).Value = (tb_pc.Text);
                cmd.ExecuteNonQuery();
                reload();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
            loadData();
           
        }

        private void bt_in_Click(object sender, EventArgs e)
        {
            FormCRNhanVien form = new FormCRNhanVien();
            form.ShowDialog();
        }
    }
}
