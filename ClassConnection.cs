using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangDoAnNhanhWP
{
    public class ClassConnection
    {
        private static string sqlStringConnection = "Data Source = DESKTOP-ACER\\NAUHTSQLSERVER; " +
                "Initial Catalog = QLCuaHangDoAnNhanh; " +
                "User ID = sa; Password = 281003";
        public static SqlConnection Connection
        {
            get
            {
                return new SqlConnection(sqlStringConnection);
            }
        }
    }
}
