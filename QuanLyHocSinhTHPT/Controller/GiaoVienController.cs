using QuanLyHocSinhTHPT.Helper;
using QuanLyHocSinhTHPT.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace QuanLyHocSinhTHPT.Controller
{
    public class GiaoVienController
    {
        public static List<GiaoVien> getAllDataGV()
        {
            string query = "SELECT MaGV,HoTen,NgaySinh,GioiTinh,Sdt,DiaChi,TenMon FROM dbo.GiaoVien INNER JOIN dbo.MonHoc ON MonHoc.MaMon = GiaoVien.MaMon";
            using (var db = setupConection.ConnectionFactory())
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                return db.Query<GiaoVien>(query).ToList();
            }
        }

        public static void ShowData()
        {
        }

        public static bool ThemGV(string _MaGV, string _HoTen, DateTime _NgaySinh, bool _GioiTinh, string _Sdt, string _DiaChi, string _TenMon)
        {
            if (checkInputGV(_MaGV, _HoTen, _NgaySinh, _Sdt, _DiaChi))
            {
                int Insert_GV;
                using (var db = setupConection.ConnectionFactory())
                {
                    try
                    {
                        if (db.State == ConnectionState.Closed)
                            db.Open();
                        using (var transaction = db.BeginTransaction())
                        {
                            Insert_GV = db.Execute("sp_InsGiaoVien",
                                new
                                {
                                    MaGV = _MaGV,
                                    HoTen = _HoTen,
                                    NgaySinh = _NgaySinh,
                                    GioiTinh = _GioiTinh,
                                    Sdt = _Sdt,
                                    DiaChi = _DiaChi,
                                    MaMon = _TenMon
                                },
                                commandType: CommandType.StoredProcedure,
                                transaction: transaction);
                            transaction.Commit();
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return false;
                    }
                }
                if (Insert_GV == 1) return true;
                else return false;
            }
            return false;
        }

        public static bool SuaGV(string _MaGV, string _HoTen, DateTime _NgaySinh, bool _GioiTinh, string _Sdt, string _DiaChi, string _TenMon)
        {
            if (checkInputGV(_MaGV, _HoTen, _NgaySinh, _Sdt, _DiaChi))
            {
                int Edit_GV;
                using (var db = setupConection.ConnectionFactory())
                {
                    try
                    {
                        if (db.State == ConnectionState.Closed)
                            db.Open();
                        using (var transaction = db.BeginTransaction())
                        {
                            Edit_GV = db.Execute("sp_UpdateGiaoVien",
                                  new
                                  {
                                      MaGV = _MaGV,
                                      HoTen = _HoTen,
                                      NgaySinh = _NgaySinh,
                                      GioiTinh = _GioiTinh,
                                      Sdt = _Sdt,
                                      DiaChi = _DiaChi,
                                      MaMon = _TenMon
                                  },
                                  commandType: CommandType.StoredProcedure,
                                  transaction: transaction);
                            transaction.Commit();
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return false;
                    }
                }
                if (Edit_GV == 1) return true;
                else return false;
            }
            return false;
        }

        public bool XoaGV(string _MaGV)
        {
            if (_MaGV != "")
            {
                using (var db = setupConection.ConnectionFactory())
                {
                    try
                    {
                        if (db.State == ConnectionState.Closed)
                            db.Open();
                        using (var transaction = db.BeginTransaction())
                        {
                            int Insert_GV = db.Execute("Name proceduce",
                                new
                                {
                                    //para
                                },
                                commandType: CommandType.StoredProcedure,
                                transaction: transaction);
                            transaction.Commit();
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return false;
                    }
                }
                return true;
            }
            return false;
        }

        public static bool checkInputGV(string _MaGV, string _HoTen, DateTime _NgaySinh, string _Sdt, string _DiaChi)
        {
            string errMS = "";
            if (_MaGV == "") { errMS = "Trống mã giáo viên"; }
            if (_HoTen == "") { errMS += "\nTrống họ tên"; }
            if (_DiaChi == "") { errMS += "\nTrống quê quán"; }
            if (_NgaySinh.Year > DateTime.Now.Year) { errMS += "\nLỗi ngày sinh"; }
            if (_Sdt.Length > 15 || _Sdt.Length == 0) { errMS += "\nLỗi số điện thoại"; }
            if (errMS != "")
            {
                MessageBox.Show(errMS, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}