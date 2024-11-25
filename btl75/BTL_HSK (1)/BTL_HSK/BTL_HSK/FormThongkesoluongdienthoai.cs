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
    public partial class FormThongkesoluongdienthoai : Form
    {
        public FormThongkesoluongdienthoai()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = ConfigurationManager.ConnectionStrings["btl_hsk"].ConnectionString;
            using (SqlConnection con = new SqlConnection(str))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_DSDTtheomahang";

                    cmd.Parameters.AddWithValue("@sTenhangDT", txtsTenhangDT.Text);//txtiGiaban la ten cái o textbox nhap vao

                    using (SqlDataAdapter ad = new SqlDataAdapter())
                    {
                        ad.SelectCommand = cmd;
                        DataTable tb = new System.Data.DataTable();
                        ad.Fill(tb);
                        CrystalReportthongkesoluongdt rpt = new CrystalReportthongkesoluongdt();// dùng crystal report tạo theo store procedure trong database
                        rpt.SetDataSource(tb);
                        crystalReportViewer1.ReportSource = rpt;
                        crystalReportViewer1.Refresh();


                    }
                }
            }
        }
    }
}
