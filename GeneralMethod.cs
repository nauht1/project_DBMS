﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangDoAnNhanhWP
{
    public static class GeneralMethod
    {
        public static string LayMaTuDong(string tableName, string idColumn)
        {
            string newID = "";
            using (SqlConnection conn = ClassConnection.Connection)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_TuDongTangMaSo", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@tableName", SqlDbType.VarChar, 30).Value = tableName;
                cmd.Parameters.Add("@idColumn", SqlDbType.VarChar, 30).Value = idColumn;
                SqlParameter outputID = cmd.Parameters.Add("@newID", SqlDbType.VarChar, 10);
                outputID.Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                newID = outputID.Value.ToString();
            }
            return newID;
        }
    }
}
