using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinhTHPT.Models
{
    public class HocSinh
    {
        [DisplayName("Mã học sinh")]
        public string MaHS { get; set; }

        [DisplayName("Họ Tên")]
        public string HoTen { get; set; }

        [DisplayName("Quê quán")]
        public string DiaChi { get; set; }

        [DisplayName("Giới tính")]
        public bool GioiTinh { get; set; }

        [DisplayName("SDT")]
        public string Sdt { get; set; }

        [DisplayName("Ngày Sinh")]
        public DateTime NgaySinh { get; set; }

        [DisplayName("Họ Tên Phụ Huynh")]
        public string TenPhuHuynh { get; set; }

        [DisplayName("SDT Phụ Huynh")]
        public string SDTphuHuynh { get; set; }

        [DisplayName("Tên Lớp")]
        public string TenLop { get; set; }

        public HocSinh(string _MaHS, string _HoTen, string _DiaChi, bool _GioiTinh, string _Sdt, DateTime _NgaySinh, string _TenPhuHuynh, string _SDTphuHuynh, string _TenLop)
        {
            this.MaHS = _MaHS;
            this.HoTen = _HoTen;
            this.DiaChi = _DiaChi;
            this.GioiTinh = _GioiTinh;
            this.NgaySinh = _NgaySinh;
            this.TenPhuHuynh = _TenPhuHuynh;
            this.SDTphuHuynh = _SDTphuHuynh;
            this.TenLop = _TenLop;
            this.Sdt = _Sdt;
        }

        public HocSinh()
        {
            this.MaHS = "";
            this.HoTen = "";
            this.DiaChi = "";
            this.GioiTinh = true;
            this.NgaySinh = DateTime.Now;
            this.TenPhuHuynh = "";
            this.SDTphuHuynh = "";
            this.TenLop = "";
            this.Sdt = "";
        }
    }
}