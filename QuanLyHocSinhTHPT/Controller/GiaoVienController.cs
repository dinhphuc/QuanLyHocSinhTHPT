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
            using (var db = setupConection.ConnectionFactory())
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                return db.Query<GiaoVien>("SELECT *FROM dbo.GiaoVien").ToList();
            }
        }

        public static void ShowData()
        {
        }

        public bool ThemGV(string _MaGV, string _HoTen, DateTime NgaySinh, bool _GioiTinh, string _Sdt, string _QueQuan)
        {
            if (checkInputGV(_MaGV, _HoTen, NgaySinh, _Sdt, _QueQuan))
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

        public bool SuaGV(string _MaGV, string _HoTen, DateTime NgaySinh, bool _GioiTinh, string _Sdt, string _QueQuan)
        {
            if (checkInputGV(_MaGV, _HoTen, NgaySinh, _Sdt, _QueQuan))
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

        public static bool checkInputGV(string _MaGV, string _HoTen, DateTime _NgaySinh, string _Sdt, string _QueQuan)
        {
            string errMS = "";
            if (_MaGV == "") { errMS = "Trống mã giáo viên"; }
            if (_HoTen == "") { errMS += "\nTrống họ tên"; }
            if (_QueQuan == "") { errMS += "\nTrống quê quán"; }
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