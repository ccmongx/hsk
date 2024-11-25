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
    public partial class LuongBanRaTheoNV : Form
    {
        public LuongBanRaTheoNV()
        {
            InitializeComponent();
            hienDSNV();
            hien();
        }

        private void hien()
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(@"H:\fithou\HSK\btl75\BTL_HSK (1)\BTL_HSK\BTL_HSK\RPTLuongBanRaTheoNV.rpt");
            string constr = ConfigurationManager.ConnectionStrings["btl_hsk"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "luongBanTheoNV";
                    cmd.Parameters.AddWithValue("@manv", cbNhanvien.SelectedValue);
                    cnn.Open();
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        ad.Fill(tb);
                        RPTLuongBanRaTheoNV rptTheoNV = new RPTLuongBanRaTheoNV();
                        rptTheoNV.SetDataSource(tb);
                        crystalReportViewer1.ReportSource = rptTheoNV;
                        crystalReportViewer1.Refresh();
                    }
                }
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            hien();
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
    }
}
