using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH_QLCHDT
{
    internal class connection
    {
        // Đường liên kết tới sql
        private static string stringConnection = @"Data Source=LAPTOP-75EMN83J\SQLEXPRESS;Initial Catalog=btl_hsk;Integrated Security=True";

        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }

    }
}
