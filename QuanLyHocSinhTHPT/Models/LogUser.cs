using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinhTHPT.Models
{
    public class LogUser
    {
        public string TenTaiKhoan { get; set; }
        public DateTime TimeLogin { get; set; }
        public string ThaoTac { get; set; }

        public LogUser()
        {
            TenTaiKhoan = "";
            TimeLogin = DateTime.Now;
            ThaoTac = "";
        }

        public LogUser(string _TenTaiKhoan, DateTime _TimeLogin, string _ThaoTac)
        {
            TenTaiKhoan = _TenTaiKhoan;
            TimeLogin = _TimeLogin;
            ThaoTac = _ThaoTac;
        }
    }
}