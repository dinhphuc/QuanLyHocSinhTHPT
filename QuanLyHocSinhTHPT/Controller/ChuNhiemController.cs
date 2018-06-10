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
    public class ChuNhiemController
    {
        public static List<ChuNhiem> getAllDataChuNhiem()
        {
            string s = "SELECT ChuNhiem.MaGV,ChuNhiem.MaLop,NiemKhoa,TenLop,dbo.GiaoVien.HoTen FROM (dbo.ChuNhiem INNER JOIN dbo.Lop ON Lop.Malop = ChuNhiem.MaLop)INNER JOIN dbo.GiaoVien ON GiaoVien.MaGV = ChuNhiem.MaGV";
            using (var db = setupConection.ConnectionFactory())
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                return db.Query<ChuNhiem>(s).ToList();
            }
        }

        public static void ShowData()
        {
        }

        public static  bool ThemCN(string _MaGV, string _MaLop, string _NamHoc)
        {
            if (checkInputCN(_NamHoc))
            {
                using (var db = setupConection.ConnectionFactory())
                {
                    try
                    {
                        if (db.State == ConnectionState.Closed)
                            db.Open();
                        using (var transaction = db.BeginTransaction())
                        {
                            int Insert_CN = db.Execute("sp_insChuNhiem",
                                new
                                {
                                    MaGV=_MaGV,
                                    MaLop=_MaLop,
                                    NamHoc=_NamHoc
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

        public  static bool SuaCN(string _MaGV, string _MaLop, string _NamHoc)
        {
            if (checkInputCN( _NamHoc))
            {
                using (var db = setupConection.ConnectionFactory())
                {
                    try
                    {
                        if (db.State == ConnectionState.Closed)
                            db.Open();
                        using (var transaction = db.BeginTransaction())
                        {
                            int Edit_CN = db.Execute("sp_UpdateChuNhiem",
                                new
                                {
                                    MaGV = _MaGV,
                                    MaLop = _MaLop,
                                    NamHoc = _NamHoc
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

        public static  bool XoaCN(string _MaGV, string _MaLop)
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
                            int del_CN = db.Execute("sp_DelChuNhiem",
                                new
                                {
                                    MaGV = _MaGV,
                                    MaLop = _MaLop,
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

        public static bool checkInputCN(string _NamHoc)
        {
            string errMS = "";
            if (_NamHoc.Trim() == "") { errMS += "\nTrống năm học"; }
            if (errMS != "")
            {
                MessageBox.Show(errMS, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}