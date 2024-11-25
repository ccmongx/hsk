using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using System.Runtime.CompilerServices;

namespace HSK82
{
    internal class Program
    {
        public static bool ADD(string connectionString, int iMaH, string sTenhang, int iSoluong, float fDongia)
        {
            string sqlInsert = "INSERT INTO tblMathang VALUEs (\r\n\t" + iMaH + ", N'" + sTenhang +
                    "', '" + iSoluong + "', N'" + fDongia + "', " + true + "\r\n)";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(sqlInsert, sqlConnection))
                {

                    sqlCommand.CommandType = CommandType.Text;
                    sqlConnection.Open();
                    int i = sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                    return i > 0;
                }

            }
        }

        public static bool Delete(string connectionString, int iMaH, string sTenhang, int iSoluong, float fDongia)
        {

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                {

                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "Delete";
                    sqlCommand.Parameters.AddWithValue("@mahang", iMaH);
                    sqlCommand.Parameters.AddWithValue("@tenhang", sTenhang);
                    sqlCommand.Parameters.AddWithValue("@soluong", iSoluong);
                    sqlCommand.Parameters.AddWithValue("@dongia", fDongia);
                    sqlConnection.Open();
                    int i = sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                    return i > 0;
                }

            }
        }

        public static bool alter(string connectionString, int iMaH)
        {

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                {

                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "alter";
                    sqlCommand.Parameters.AddWithValue("@mahang", iMaH);
                    sqlConnection.Open();
                    int i = sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                    return i > 0;
                }

            }
        }

        public static bool search(string connectionString, int iMaH)
        {

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                {

                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "alter";
                    sqlCommand.Parameters.AddWithValue("@mahang", iMaH);
                    sqlConnection.Open();
                    int i = sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                    return i > 0;
                }

            }
        }

        public static void hien(string connectionString, int iMaH, string sTenhang, int iSoluong, float fDongia)
        {
            Console.WriteLine("mahang\t\ttenhang\t\tsoluong\t\tdongia");
            Console.WriteLine(iMaH+"\t\t"+sTenhang+"\t\t"+iSoluong+"\t\t"+fDongia);
        }

        public static void nhap(string connectionString, int iMaH, string sTenhang, int iSoluong, float fDongia)
        {
            Console.WriteLine("Nhap ma hang");
            iMaH = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap ten hang");
            sTenhang = Console.ReadLine();
            Console.WriteLine("nhap so luong");
            iSoluong = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap don gia");
            fDongia = float.Parse(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            string strConnect = @"Data Source=LAPTOP-75EMN83J\SQLEXPRESS;Initial Catalog=HSK82;Integrated Security=True";
            int iMaH;
            string sTenhang;
            int iSoluong;
            float fDongia;
            int chon;
            int islmh;
            do
            {
                Console.WriteLine("Nhap so luong mat hang:");
                islmh = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Chon:");
                chon = Convert.ToInt32(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        Program.ADD(strConnect, iMaH, sTenhang, iSoluong, fDongia);
                        break;
                    case 2:
                        Program.Delete(strConnect, iMaH, sTenhang, iSoluong, fDongia);
                        break;
                    case 3:
                        Program.search(strConnect, iMaH);
                        break;
                    case 4:
                        Program.alter(strConnect, iMaH);
                        break;
                    default:
                        break;
                }
            } while (true);
        }
    }
}