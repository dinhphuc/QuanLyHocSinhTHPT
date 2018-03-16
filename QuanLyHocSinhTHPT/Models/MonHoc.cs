using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinhTHPT.Models
{
    public class MonHoc
    {
        [DisplayName("Mã Môn Học")]
        public string MaMon { get; set; }

        [DisplayName("Tên")]
        public string TenMon { get; set; }

        [DisplayName("Khối")]
        public string Khoi { get; set; }

        public MonHoc(string _MaMon, string _TenMon, string _Khoi)
        {
            this.MaMon = _MaMon;
            this.TenMon = _TenMon;
            this.Khoi = _Khoi;
        }

        public MonHoc()
        {
            this.MaMon = "";
            this.TenMon = "";
            this.Khoi = "";
        }
    }
}