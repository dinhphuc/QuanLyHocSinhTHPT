using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinhTHPT.Models
{
    public class Lop
    {
        [DisplayName("Mã Lớp")]
        public string MaLop { get; set; }

        [DisplayName("Tên Lớp")]
        public string TenLop { get; set; }

        [DisplayName("Niêm khóa")]
        public string NiemKhoa { get; set; }

        public Lop(string _Malop, string _TenLop, string _NiemKhoa)
        {
            this.MaLop = _Malop;
            this.TenLop = _TenLop;
            this.NiemKhoa = _NiemKhoa;
        }

        public Lop()
        {
            this.MaLop = "";
            this.TenLop = "";
            this.NiemKhoa = "";
        }
    }
}