using Dapper;
using QuanLyHocSinhTHPT.Helper;
using QuanLyHocSinhTHPT.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinhTHPT.Controller
{
    internal class ThongKeController
    {
        public List<DiemToanTruong> GetData()
        {
            using (var db = setupConection.ConnectionFactory())
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                return db.Query<DiemToanTruong>("daaa").ToList();
            }
        }

        //public static List<DiemThongKe> getData()
        //{
        //    DiemThongKe dtk = new DiemThongKe();
        //    List<Lop> lop = LopController.getAllDataClass();
        //    List<DiemThongKe> lstDiemTK = new List<DiemThongKe>();
        //    List<Diem> lstDiem = DiemController.getAllDataDiem();
        //    lstDiem = lstDiem.OrderBy(o => o.MaLop).ToList();
        //    string Malop = lstDiem[0].MaLop;
        //    foreach (Diem d in lstDiem)
        //    {
        //        if (Malop == d.MaLop)
        //        {
        //            dtk.MaLop = d.MaLop;
        //        }
        //        else
        //        {
        //            lstDiemTK.Add(dtk);
        //            Malop = d.MaLop;
        //            dtk = new DiemThongKe();
        //            dtk.MaLop = d.MaLop;
        //        }
        //        if (Diem.diemTB(d) >= 9 && Diem.diemTB(d) <= 10)
        //        {
        //            dtk.XuatSac++;
        //        }
        //        else if (Diem.diemTB(d) >= 8 && Diem.diemTB(d) < 9)
        //        {
        //            dtk.Gioi++;
        //        }
        //        else if (Diem.diemTB(d) >= 7 && Diem.diemTB(d) < 8)
        //        {
        //            dtk.Kha++;
        //        }
        //        else if (Diem.diemTB(d) >= 6 && Diem.diemTB(d) < 7)
        //        {
        //            dtk.TrungBinhKha++;
        //        }
        //        else if (Diem.diemTB(d) >= 5 && Diem.diemTB(d) < 6)
        //        {
        //            dtk.TrungBinh++;
        //        }
        //        else if (Diem.diemTB(d) >= 4 && Diem.diemTB(d) < 5)
        //        {
        //            dtk.Yeu++;
        //        }
        //        else if (Diem.diemTB(d) < 4)
        //        {
        //            dtk.Kem++;
        //        }
        //    }
        //    lstDiemTK.Add(dtk);
        //    return lstDiemTK;
        //}
    }
}