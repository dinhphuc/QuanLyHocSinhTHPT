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
    public class HocSinhController
    {
        public static List<HocSinh> getAllDataHS()
        {
            using (var db = setupConection.ConnectionFactory())
            {
                string s = "SELECT MaHS,HoTen,NgaySinh,DiaChi,GioiTinh,sdt,TenPhuHuynh,SDTphuHuynh,TenLop FROM dbo.HocSinh INNER JOIN dbo.Lop ON Lop.Malop = HocSinh.MaLop";
                if (db.State == ConnectionState.Closed)
                    db.Open();
                return db.Query<HocSinh>(s).ToList();
            }
        }

        public static void ShowData()
        {
        }

        public static bool ThemHS(string _MaHS, string _HoTen, string _QueQuan,
            bool _GioiTinh, DateTime _NgaySinh, string _SDTphuHuynh)
        {
            if (checkInputHS(_MaHS, _HoTen, _QueQuan, _NgaySinh, _SDTphuHuynh))
            {
                using (var db = setupConection.ConnectionFactory())
                {
                    try
                    {
                        if (db.State == ConnectionState.Closed)
                            db.Open();
                        using (var transaction = db.BeginTransaction())
                        {
                            int Insert_HS = db.Execute("Name proceduce",
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

        public static bool SuaHS(string _MaHS, string _HoTen, string _QueQuan,
            bool _GioiTinh, DateTime _NgaySinh, string _SDTphuHuynh)
        {
            if (checkInputHS(_MaHS, _HoTen, _QueQuan, _NgaySinh, _SDTphuHuynh))
            {
                using (var db = setupConection.ConnectionFactory())
                {
                    try
                    {
                        if (db.State == ConnectionState.Closed)
                            db.Open();
                        using (var transaction = db.BeginTransaction())
                        {
                            int Edit_HS = db.Execute("Name proceduce",
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

        public static bool XoaHS(string _MaHS)
        {
            if (_MaHS != "")
            {
                using (var db = setupConection.ConnectionFactory())
                {
                    try
                    {
                        if (db.State == ConnectionState.Closed)
                            db.Open();
                        using (var transaction = db.BeginTransaction())
                        {
                            int Xoa_HS = db.Execute("Name proceduce",
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

        public static bool checkInputHS(string _MaHS, string _HoTen, string _QueQuan,
             DateTime _NgaySinh, string _SDTphuHuynh)
        {
            string errMS = "";
            if (_MaHS == "") { errMS = "Trống mã học sinh"; }
            if (_HoTen == "") { errMS += "\nTrống họ tên"; }
            if (_QueQuan == "") { errMS += "\nTrống quê quán"; }
            if (_NgaySinh.Year > DateTime.Now.Year) { errMS += "\nLỗi ngày sinh"; }
            if (_SDTphuHuynh.Length > 15 || _SDTphuHuynh.Length == 0) { errMS += "\nLỗi số điện thoại"; }
            if (errMS != "")
            {
                MessageBox.Show(errMS, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}