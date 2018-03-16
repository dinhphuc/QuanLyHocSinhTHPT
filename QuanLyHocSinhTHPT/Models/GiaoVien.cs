using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinhTHPT.Models
{
    /*
    MaGV var
    HoTen nv
    NgaySinh
    GioiTinh
    Sdt varc
    DiaChi n
    MaMon VA

     */

    public class GiaoVien
    {
        [DisplayName("Mã Giáo Viên")]
        public string MaGV { get; set; }

        [DisplayName("Họ Tên")]
        public string HoTen { get; set; }

        [DisplayName("Ngày Sinh")]
        public DateTime NgaySinh { get; set; }

        [DisplayName("Giới Tính")]
        public string GioiTinh { get; set; }

        [DisplayName("Số dt")]
        public string Sdt { get; set; }

        [DisplayName("Quê quán")]
        public string DiaChi { get; set; }

        [DisplayName("Mã Môn")]
        public string MaMon { get; set; }

        public GiaoVien(string _MaGV, string _HoTen, DateTime _NgaySinh, string _GioiTinh, string _Sdt, string _DiaChi, string _MaMon)
        {
            this.MaGV = _MaGV;
            this.HoTen = _HoTen;
            this.NgaySinh = _NgaySinh;
            this.GioiTinh = _GioiTinh;
            this.Sdt = _Sdt;
            this.DiaChi = _DiaChi;
            this.MaMon = _MaMon;
        }

        public GiaoVien()
        {
            this.MaGV = "";
            this.HoTen = "";
            this.NgaySinh = DateTime.Now;
            this.GioiTinh = "Nam";
            this.Sdt = "";
            this.DiaChi = "";
        }
    }
}