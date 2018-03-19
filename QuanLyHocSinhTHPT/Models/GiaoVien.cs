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
    TenMon VA

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
        public bool GioiTinh { get; set; }

        [DisplayName("Số dt")]
        public string Sdt { get; set; }

        [DisplayName("Quê quán")]
        public string DiaChi { get; set; }

        [DisplayName("Mã Môn")]
        public string TenMon { get; set; }

        public GiaoVien(string _MaGV, string _HoTen, DateTime _NgaySinh, bool _GioiTinh, string _Sdt, string _DiaChi, string _TenMon)
        {
            this.MaGV = _MaGV;
            this.HoTen = _HoTen;
            this.NgaySinh = _NgaySinh;
            this.GioiTinh = _GioiTinh;
            this.Sdt = _Sdt;
            this.DiaChi = _DiaChi;
            this.TenMon = _TenMon;
        }

        public GiaoVien()
        {
            this.MaGV = "";
            this.HoTen = "";
            this.NgaySinh = DateTime.Now;
            this.GioiTinh = true;
            this.Sdt = "";
            this.DiaChi = "";
        }
    }
}