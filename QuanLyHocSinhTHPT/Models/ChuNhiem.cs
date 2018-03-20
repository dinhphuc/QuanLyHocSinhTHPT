using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinhTHPT.Models
{
    public class ChuNhiem
    {
        [DisplayName("Mã Giáo Viên")]
        public string MaGV { get; set; }

        [DisplayName("Mã Lớp")]
        public string MaLop { get; set; }

        [DisplayName("Tên Giáo Viên")]
        public string HoTen { get; set; }

        [DisplayName("Tên Lớp")]
        public string TenLop { get; set; }

        [DisplayName("Năm Học")]
        public string NiemKhoa { get; set; }

        public ChuNhiem()
        {
            MaGV = "";
            MaLop = "";
            NiemKhoa = "";
            HoTen = "";
            TenLop = "";
        }

        public ChuNhiem(string _MaGV, string _MaLop, string _HoTen, string _TenLop, string _NiemKhoa)
        {
            MaGV = _MaGV;
            MaLop = _MaLop;
            NiemKhoa = _NiemKhoa;
            HoTen = _HoTen;
            TenLop = _TenLop;
        }
    }
}