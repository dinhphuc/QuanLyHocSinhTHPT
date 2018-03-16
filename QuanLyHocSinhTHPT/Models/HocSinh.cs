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
        public string GioiTinh { get; set; }

        [DisplayName("Ngày Sinh")]
        public string NgaySinh { get; set; }

        [DisplayName("SDT Phụ Huynh")]
        public string SDTphuHuynh { get; set; }

        public HocSinh(string _MaHS, string _HoTen, string _DiaChi, string _GioiTinh, string _NgaySinh, string _SDTphuHuynh)
        {
            this.MaHS = _MaHS;
            this.HoTen = _HoTen;
            this.DiaChi = _DiaChi;
            this.GioiTinh = _GioiTinh;
            this.NgaySinh = _NgaySinh;
            this.SDTphuHuynh = _SDTphuHuynh;
        }

        public HocSinh()
        {
            this.MaHS = "";
            this.HoTen = "";
            this.DiaChi = "";
            this.GioiTinh = "";
            this.NgaySinh = "";
            this.SDTphuHuynh = "";
        }
    }
}