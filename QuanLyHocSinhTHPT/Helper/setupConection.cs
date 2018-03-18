using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinhTHPT.Helper
{
    internal class setupConection
    {
        public static Func<DbConnection> ConnectionFactory = () => new SqlConnection(ConnectionString.Connection);

        public static class ConnectionString
        {
            public static string Connection = "Data Source=phucnd\\phucnd;Initial Catalog=QuanLyHSGVTHPT;Integrated Security=True";
        }
    }
}