using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Configuration;
using System.Data.SqlClient;

namespace BTL_HSK
{
    public partial class LocGiaKhoang : Form
    {
        public LocGiaKhoang()
        {
            InitializeComponent();
            hienDSHang();
        }

        private void btnIn2_Click(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(@"H:\fithou\HSK\btl75\BTL_HSK (1)\BTL_HSK\BTL_HSK\RPTLocGiaKhoang.rpt");
            string constr = ConfigurationManager.ConnectionStrings["btl_hsk"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "locGiaKhoang";
                    cmd.Parameters.AddWithValue("@giadau", txtGiadau.Text);
                    cmd.Parameters.AddWithValue("@giacuoi", txtGiacuoi.Text);
                    cmd.Parameters.AddWithValue("@mahang", hang.SelectedValue);
                    cnn.Open();
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        ad.Fill(tb);
                        RPTLocGiaKhoang cry3 = new RPTLocGiaKhoang();
                        cry3.SetDataSource(tb);
                        crystalReportViewer2.ReportSource = cry3;
                        crystalReportViewer2.Refresh();
                    }
                }
            }
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
            hang.DataSource = v;
            hang.DisplayMember = "sTenhangDT";
            hang.ValueMember = "iMahangDT";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(@"H:\fithou\HSK\btl75\BTL_HSK (1)\BTL_HSK\BTL_HSK\RPTLocGiaKhoang.rpt");
            string constr = ConfigurationManager.ConnectionStrings["btl_hsk"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from thongKeSoLuongDT";
                    cnn.Open();
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        ad.Fill(tb);
                        RPTLocGiaKhoang cry3 = new RPTLocGiaKhoang();
                        cry3.SetDataSource(tb);
                        crystalReportViewer2.ReportSource = cry3;
                        crystalReportViewer2.Refresh();
                    }
                }
            }
        }

        private void crystalReportViewer2_Load(object sender, EventArgs e)
        {

        }
    }
}
