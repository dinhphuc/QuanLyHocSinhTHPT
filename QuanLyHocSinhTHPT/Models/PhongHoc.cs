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
            MaPhong = "";
            SoPhong = "";
            SoChoToiDa = 30;
        }

        public PhongHoc(string _MaPhong, string _SoPhong, int _SoChoToiDa)
        {
            MaPhong = _MaPhong;
            SoPhong = _SoPhong;
            SoChoToiDa = _SoChoToiDa;
        }
    }
}