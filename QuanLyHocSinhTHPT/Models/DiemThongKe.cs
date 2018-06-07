using QuanLyHocSinhTHPT.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinhTHPT.Models
{
    public class DiemThongKe
    {
        public string MaLop { get; set; }
        public int XuatSac { get; set; }
        public int Gioi { get; set; }
        public int Kha { get; set; }
        public int TrungBinhKha { get; set; }
        public int TrungBinh { get; set; }
        public int Yeu { get; set; }
        public int Kem { get; set; }

        public DiemThongKe()
        {
            MaLop = "";
            this.XuatSac = 0;
            this.Gioi = 0;
            this.Kha = 0;
            this.TrungBinhKha = 0;
            this.TrungBinh = 0;
            this.Yeu = 0;
            this.Kem = 0;
        }
    }
}