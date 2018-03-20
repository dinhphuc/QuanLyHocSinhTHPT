using Dapper;
using QuanLyHocSinhTHPT.Helper;
using QuanLyHocSinhTHPT.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinhTHPT.Controller
{
    internal class TaiKhoanController
    {
        public static List<TaiKhoan> getAllDataTaiKhoan()
        {
            string s = "SELECT * FROM dbo.TaiKhoan";
            using (var db = setupConection.ConnectionFactory())
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                return db.Query<TaiKhoan>(s).ToList();
            }
        }
    }
}