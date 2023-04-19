using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangDoAnNhanhWP
{
    public class ClassConnection
    {
        private static string sqlStringConnection = "Data Source = DESKTOP-ACER\\NAUHTSQLSERVER; " +
                "Initial Catalog = QLCuaHangDoAnNhanh; " +
                "User ID = sa; Password = 281003";
        private static SqlConnection conn = null;
        public static SqlConnection Connection
        {
            get
            {
                if (conn == null)
                {
                    conn = new SqlConnection(sqlStringConnection);
                }
                return conn;
            }
        }
    }
}
