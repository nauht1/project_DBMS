using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data;

namespace QLCuaHangDoAnNhanhWP
{
    public class ClassConnection
    {
        //Connection string dành cho các form chỉ liên quan đến khách hàng: frmMonAn, frmDHTrucTuyen
        //nó sẽ mở kết nối đến tài khoản mặc định dành cho tất cả các khách hàng khi vào hệ thống
        public static string GetKH_ConnectionString()
        {
            return "Data Source = .\\NAUHTSQLSERVER; Initial Catalog = QLCuaHangDoAnNhanh; " +
                "User ID = Default_Account_KH; Password = 123456";
        }
        //Connection string khi các nhân viên đăng nhập
        public static string GetConnectionString(string username, string password)
        {
            return $"Data Source = .\\NAUHTSQLSERVER; Initial Catalog = QLCuaHangDoAnNhanh; " +
                $"User ID = {username}; Password = {password}";
        }
        //Connection string để kiểm tra các tài khoản trước khi đăng nhập 
        public static string GetDefault_ConnectionString()
        {
            return "Data Source= .\\NAUHTSQLSERVER; Initial Catalog = QLCuaHangDoAnNhanh; Integrated Security=True";
        }
    }
}
