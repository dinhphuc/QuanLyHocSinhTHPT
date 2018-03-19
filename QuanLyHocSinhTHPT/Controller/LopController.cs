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
    public class LopController
    {
        public static List<Lop> getAllDataClass()
        {
            using (var db = setupConection.ConnectionFactory())
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                return db.Query<Lop>("SELECT *FROM dbo.Lop").ToList();
            }
        }

        public static void ShowData()
        {
        }

        public bool InsertClass(string _Malop, string _TenLop, string _NiemKhoa)
        {
            if (checkInputClass(_Malop, _TenLop, _NiemKhoa))
            {
                using (var db = setupConection.ConnectionFactory())
                {
                    try
                    {
                        if (db.State == ConnectionState.Closed)
                            db.Open();
                        using (var transaction = db.BeginTransaction())
                        {
                            int Insert_Class = db.Execute("Name proceduce",
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

        public bool EditClass(string _Malop, string _TenLop, string _NiemKhoa)
        {
            if (checkInputClass(_Malop, _TenLop, _NiemKhoa))
            {
                using (var db = setupConection.ConnectionFactory())
                {
                    try
                    {
                        if (db.State == ConnectionState.Closed)
                            db.Open();
                        using (var transaction = db.BeginTransaction())
                        {
                            int Edit_Class = db.Execute("Name proceduce",
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

        public bool DelClass(string _Malop)
        {
            if (_Malop != "")
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

        public static bool checkInputClass(string _Malop, string _TenLop, string _NiemKhoa)
        {
            string errMS = "";
            if (_Malop.Trim() == "") { errMS = "Trống mã lớp"; }
            if (_TenLop.Trim() == "") { errMS += "\nTrống tên lớp"; }
            if (_NiemKhoa.Trim() == "") { errMS += "\nTrống niêm khóa"; }
            if (errMS != "")
            {
                MessageBox.Show(errMS, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}