using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinhTHPT.Models
{
    public class Diem
    {
        [DisplayName("Mã HS")]
        public string MaHS { get; set; }
        public string TenLop { get; set; }

        [DisplayName("Tên HS")]
        public string HoTen { get; set; }

        [DisplayName("Mã Môn Học")]
        public string MaMH { get; set; }

        [DisplayName("Tên Môn Học")]
        public string TenMon { get; set; }

        [DisplayName("Điểm miệng")]
        public double DiemMieng { get; set; }

        [DisplayName("Điểm 15 phút")]
        public double Diem15p { get; set; }

        [DisplayName("Điểm một tiết")]
        public double Diem1h { get; set; }

        [DisplayName("Điểm Học kì")]
        public double DiemHK { get; set; }

        public Diem(string _MaMH, string _MaHS, double _DiemMieng, double _Diem15p, double _Diem1h, double _DiemHK)
        {
            this.MaMH = _MaMH;
            this.MaHS = _MaHS;
            this.DiemMieng = _DiemMieng;
            this.Diem15p = _Diem15p;
            this.Diem1h = _Diem1h;
            this.DiemHK = _DiemHK;
        }

        public Diem()
        {
            this.MaMH = "";
            this.MaHS = "";
            this.DiemMieng = 0.0;
            this.Diem15p = 0.0;
            this.Diem1h = 0.0;
            this.DiemHK = 0.0;
        }

        public static double diemTB(Diem d)
        {
            return (d.DiemMieng + d.Diem15p + d.Diem1h * 2 + d.DiemHK * 3) / 7;
        }
    }
}