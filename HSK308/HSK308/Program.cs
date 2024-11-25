using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace HSK308
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string constr = "Data Source=LAPTOP-75EMN83J\\SQLEXPRESS;Initial Catalog=hsk_QLRP;Integrated Security=True";
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    do
                    {
                        string sMaRap; string sTenRap; string sDiaChi; string sSDT; int iSoPhong; int iTongSoGhe;
                    Console.WriteLine("1.them\n2.sua\n3.xoa\n4.xem danh sach");
                    int a = Convert.ToInt32(Console.ReadLine());
                    switch (a)
                    {
                        case 1:
                            Console.WriteLine("NhapMaRap:");
                            sMaRap = Console.ReadLine();
                            Console.WriteLine("NhapTenRap");
                            sTenRap = Console.ReadLine();
                            Console.WriteLine("NhapDiaChi");
                            sDiaChi = Console.ReadLine();
                            Console.WriteLine("NhapSDT");
                            sSDT = Console.ReadLine();
                            Console.WriteLine("NhapSoPhong");
                            iSoPhong = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("NhapTongSoGhe");
                            iTongSoGhe = Convert.ToInt32(Console.ReadLine());
                            bool i = Program.them(constr, sMaRap, sTenRap, sDiaChi, sSDT, iSoPhong, iTongSoGhe);
                            if (i) Console.WriteLine("Them Thanh cong");
                            else Console.WriteLine("Khong thanh cong");
                            Program.hien(constr);
                            break;
                        case 2:
                            Console.WriteLine("NhapMaRap:");
                                sMaRap = Console.ReadLine();
                                Console.WriteLine("NhapTenRap");
                                sTenRap = Console.ReadLine();
                                Console.WriteLine("NhapDiaChi");
                                sDiaChi = Console.ReadLine();
                                Console.WriteLine("NhapSDT");
                                sSDT = Console.ReadLine();
                                Console.WriteLine("NhapSoPhong");
                                iSoPhong = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("NhapTongSoGhe");
                                iTongSoGhe = Convert.ToInt32(Console.ReadLine());
                                bool s = Program.sua(constr, sMaRap, sTenRap);
                                if (s) Console.WriteLine("Them Thanh cong");
                                else Console.WriteLine("Khong thanh cong");
                                Program.hien(constr);
                    break;
                            case 3:
                                Console.WriteLine("NhapMaRap:");
                    sMaRap = Console.ReadLine();
                    Console.WriteLine("NhapTenRap");
                    sTenRap = Console.ReadLine();
                    Console.WriteLine("NhapDiaChi");
                    sDiaChi = Console.ReadLine();
                    Console.WriteLine("NhapSDT");
                    sSDT = Console.ReadLine();
                    Console.WriteLine("NhapSoPhong");
                    iSoPhong = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("NhapTongSoGhe");
                    iTongSoGhe = Convert.ToInt32(Console.ReadLine());
                    bool x = Program.xoa(constr, sMaRap);
                    if (x) Console.WriteLine("Them Thanh cong");
                    else Console.WriteLine("Khong thanh cong");
                    Program.hien(constr);
                    break;
                }

            } while (true) ;
        }

    }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }

        public static bool them(string constr, string sMaRap, string sTenRap, string sDiaChi, string sSDT, int iSoPhong, int iTongSoGhe)
        {
            string sqlInsert = "insert into tblRap(sMaRap,sTenRap,sDiaChi,sSDT,iSoPhong,iTongSoGhe)" +
                "values ('" + sMaRap + "',N'" + sTenRap + "',N'" + sDiaChi + "',N'" + sSDT + "','" + iSoPhong + "','" + iTongSoGhe + "')";
                using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(sqlInsert, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }

        public static bool sua(string constr, string sMaRap, string sTenRap)
        {
            string sqlUpdate = "Update SinhVien set sTenRap = '" + sTenRap + "' WHERE sMaRap = '" + sMaRap + "'";
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(sqlUpdate, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }

        public static bool xoa(string constr, string sMaRap)
        {
            string sqlDelete = "Delete FROM tblRap WHERE sMaRap = '" + sMaRap + "'";

            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(sqlDelete, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }
        public static void hien(string constr)
        {

            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("select*from tblRap", cnn))
                {
                    cnn.Open();
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}", rd["sMaRap"], rd["sTenRap"], rd["sDiaChi"], rd["sSDT"], rd["iSoPhong"], rd["iTongSoGhe"]);
                            
                        }
                        rd.Close();
                    }
                    cnn.Close();
                }

            }
        }
    }
}

