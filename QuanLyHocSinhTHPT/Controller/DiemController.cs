using Dapper;
using QuanLyHocSinhTHPT.Helper;
using QuanLyHocSinhTHPT.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinhTHPT.Controller
{
    public class DiemController
    {
        public static List<Diem> getAllDataDiem()
        {
            string query = "SELECT Diem.MaHS,MaMH,DiemMieng,Diem15p,Diem1h,DiemHK,HoTen,TenMon FROM (dbo.Diem INNER JOIN dbo.HocSinh ON HocSinh.MaHS = Diem.MaHS)INNER JOIN dbo.MonHoc ON MonHoc.MaMon = Diem.MaMH";
            using (var db = setupConection.ConnectionFactory())
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                return db.Query<Diem>(query).ToList();
            }
        }

        public bool ThemDiem(string _MaMH, string _MaHS, double _DiemMieng, double _Diem15p, double _Diem1h, double _DiemHK)
        {
            if (checkInputGV(_DiemMieng, _Diem15p, _Diem1h, _DiemHK))
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

        public bool SuaGV(string _MaMH, string _MaHS, double _DiemMieng, double _Diem15p, double _Diem1h, double _DiemHK)
        {
            if (checkInputGV(_DiemMieng, _Diem15p, _Diem1h, _DiemHK))
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

        public static bool checkInputGV(double _DiemMieng, double _Diem15p, double _Diem1h, double _DiemHK)
        {
            string errMS = "";
            if (_DiemMieng > 10 || _DiemMieng < 0) { errMS = "Sai Điểm miệng"; }
            if (_Diem15p > 10 || _Diem15p < 0) { errMS = "Sai Điểm 15p"; }
            if (_Diem1h > 10 || _Diem1h < 0) { errMS = "Sai Điểm 1 tiết"; }
            if (_DiemHK > 10 || _DiemHK < 0) { errMS = "Sai Điểm Học kỳ"; }

            if (errMS != "")
            {
                MessageBox.Show(errMS, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}