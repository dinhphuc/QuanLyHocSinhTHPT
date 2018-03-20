using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using QuanLyHocSinhTHPT.Models;
using QuanLyHocSinhTHPT.Helper;
using System.Windows.Forms;
using System.Data;

namespace QuanLyHocSinhTHPT.Controller
{
    public class PhongHocController
    {
        public static List<PhongHoc> getAllDataRoom()
        {
            using (var db = setupConection.ConnectionFactory())
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                return db.Query<PhongHoc>("SELECT *FROM dbo.PhongHoc").ToList();
            }
        }

        public static void ShowData()
        {
        }

        public bool InsertRoom(string _MaPhong, string _SoPhong, int _SoChoToiDa)
        {
            if (checkInputRoom(_MaPhong, _SoPhong, _SoChoToiDa))
            {
                using (var db = setupConection.ConnectionFactory())
                {
                    try
                    {
                        if (db.State == ConnectionState.Closed)
                            db.Open();
                        using (var transaction = db.BeginTransaction())
                        {
                            int Insert_Room = db.Execute("Name proceduce",
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

        public bool EditRoom(string _MaPhong, string _SoPhong, int _SoChoToiDa)
        {
            if (checkInputRoom(_MaPhong, _SoPhong, _SoChoToiDa))
            {
                using (var db = setupConection.ConnectionFactory())
                {
                    try
                    {
                        if (db.State == ConnectionState.Closed)
                            db.Open();
                        using (var transaction = db.BeginTransaction())
                        {
                            int EditRoom = db.Execute("Name proceduce",
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

        public bool DelRoom(string _MaPhong)
        {
            if (_MaPhong != "")
            {
                using (var db = setupConection.ConnectionFactory())
                {
                    try
                    {
                        if (db.State == ConnectionState.Closed)
                            db.Open();
                        using (var transaction = db.BeginTransaction())
                        {
                            int DelRoom = db.Execute("Name proceduce",
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

        public static bool checkInputRoom(string _MaPhong, string _SoPhong, int _SoChoToiDa)
        {
            string errMS = "";
            if (_MaPhong.Trim() == "") { errMS = "Trống mã giáo phòng"; }
            if (_SoPhong.Trim() == "") { errMS += "\nTrống số phòng"; }
            if (_SoChoToiDa > 50 || _SoChoToiDa < 0) { errMS += "\nSố chỗ tối đa không hợp lệ"; }
            if (errMS != "")
            {
                MessageBox.Show(errMS, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}