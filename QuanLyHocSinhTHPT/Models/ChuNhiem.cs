using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinhTHPT.Models
{
    internal class ChuNhiem
    {
        [DisplayName("Mã Giáo Viên")]
        public string MaGV { get; set; }

        [DisplayName("Mã Lớp")]
        public string MaLop { get; set; }

        [DisplayName("Năm Học")]
        public string NamHoc { get; set; }
    }
}