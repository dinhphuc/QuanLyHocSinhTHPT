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
    public class PhongLopController
    {
        public static List<PhongLop> GetAllDataRoomClass()
        {
            using (var db = setupConection.ConnectionFactory())
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                return db.Query<PhongLop>("EXEC dbo.GetDataRoomClass").ToList();
            }
        }
        public static bool InsertRoomClass(string _ID, string _MaPhong, string _MaLop, string _KipHoc, string _HocKyNamHoc)
        {
            if (checkInputRoomClass(_ID, _KipHoc, _HocKyNamHoc))
            {
                int InsRoomClass = -1;
                using (var db = setupConection.ConnectionFactory())
                {
                    try
                    {
                        if (db.State == ConnectionState.Closed)
                            db.Open();
                        using (var transaction = db.BeginTransaction())
                        {
                             InsRoomClass = db.Execute("InsertRoomClass",
                                new
                                {
                                    @ID = _ID,
                                    @MaPhong = _MaPhong,
                                    @MaLop = _MaLop,
                                    @KipHoc = _KipHoc,
                                    @HocKyNamHoc = _HocKyNamHoc
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
                if (InsRoomClass >= 1) return true;
                else return false;
            }
            return false;
        }

        public static bool EditRoomClass(string _ID, string _MaPhong, string _MaLop, string _KipHoc, string _HocKyNamHoc)
        {
            if (checkInputRoomClass(_ID, _KipHoc, _HocKyNamHoc))
            {
                int EditRoom = -1;
                using (var db = setupConection.ConnectionFactory())
                {
                    try
                    {
                        if (db.State == ConnectionState.Closed)
                            db.Open();
                        using (var transaction = db.BeginTransaction())
                        {
                             EditRoom = db.Execute("EditRoomClass",
                                new
                                {
                                    @ID = _ID,
                                    @MaPhong = _MaPhong,
                                    @MaLop = _MaLop,
                                    @KipHoc = _KipHoc,
                                    @HocKyNamHoc = _HocKyNamHoc
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
                if (EditRoom >= 1) return true;
                else return false;
            }
            return false;
        }

        public static bool DelRoomClass(string _ID)
        {
            if (_ID != "")
            {
                int delRoomClass = -1;
                using (var db = setupConection.ConnectionFactory())
                {
                    try
                    {
                        if (db.State == ConnectionState.Closed)
                            db.Open();
                        using (var transaction = db.BeginTransaction())
                        {
                            delRoomClass = db.Execute("DelRoomClass",
                                new
                                {
                                    @ID = _ID
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
                if (delRoomClass >= 1) return true;
                else return false;
            }
            return false;
        }

        public static bool checkInputRoomClass(string _ID, string _KipHoc, string _KyHoc)
        {
            string errMS = "";
            if (_ID.Trim() == "") { errMS = "Trống Mã"; }
            if (_KipHoc.Trim() == "") { errMS = "Trống kíp học"; }
            if (_KyHoc.Trim() == "") { errMS += "\nTrống kỳ học"; }
            if (errMS != "")
            {
                MessageBox.Show(errMS, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}