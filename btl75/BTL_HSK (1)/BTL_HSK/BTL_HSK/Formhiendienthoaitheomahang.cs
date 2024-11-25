using CrystalDecisions.CrystalReports.Engine;
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
    public partial class Formhiendienthoaitheomahang : Form
    {
        public Formhiendienthoaitheomahang()
        {
            InitializeComponent();
        }

        private void In_Click(object sender, EventArgs e)
        {
            string str = ConfigurationManager.ConnectionStrings["btl_hsk"].ConnectionString;
            using (SqlConnection con = new SqlConnection(str))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_DSDTtheomahang";

                    cmd.Parameters.AddWithValue("@sTenhangDT", txtiMahangDT.Text);//txtiGiaban la ten cái o textbox nhap vao
                    con.Open();
                    using (SqlDataAdapter ad = new SqlDataAdapter())
                    {
                        ad.SelectCommand = cmd;
                        DataTable tb = new System.Data.DataTable();
                        ad.Fill(tb);
                        CrystalReporthienthongtintheomahang rpt = new CrystalReporthienthongtintheomahang();// dùng crystal report tạo theo store procedure trong database
                        rpt.SetDataSource(tb);
                        crystalReportViewer1.ReportSource = rpt;
                        crystalReportViewer1.Refresh();
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Formhiendienthoaitheomahang_Load(object sender, EventArgs e)
        {

        }
    }
}
