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

namespace BTLHSK
{
    public partial class FormCRNhanVien : Form
    {
        public FormCRNhanVien()
        {
            InitializeComponent();
        }

        private void FormCRNhanVien_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            con.Open();
            string query = "Select * from tbl_NhanVien";
            SqlCommand cmd=new SqlCommand(query, con);
            SqlDataAdapter adt=new SqlDataAdapter(cmd);
            DataTable dt=new DataTable();
            adt.Fill(dt);
            CrystalReportNhanVien crp=new CrystalReportNhanVien();
            crp.SetDataSource(dt);
            crp_nhanvien.ReportSource = crp;
        }
    }
}
