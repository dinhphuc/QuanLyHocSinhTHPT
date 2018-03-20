using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinhTHPT.Models
{
    public class PhongHoc
    {
        public string MaPhong { get; set; }
        public string SoPhong { get; set; }
        public int SoChoToiDa { get; set; }

        public PhongHoc()
        {
            this.MaPhong = "";
            this.SoPhong = "";
            this.SoChoToiDa = 30;
        }

        public PhongHoc(string _MaPhong, string _SoPhong, int _SoChoToiDa)
        {
            this.MaPhong = _MaPhong;
            this.SoPhong = _SoPhong;
            this.SoChoToiDa = _SoChoToiDa;
        }
    }
}