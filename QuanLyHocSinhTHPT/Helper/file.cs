using QuanLyHocSinhTHPT.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinhTHPT.Helper
{
    internal class file
    {
        public static bool docFileDB(string pad)
        {
            if (File.Exists(pad))
            {
                StreamReader stw = null;
                try
                {
                    stw = new StreamReader(pad);
                    MaHoaString.key = "z3r0.IT";
                    ThamSoKetNoi.ServerName = MaHoaString.Decrypt(stw.ReadLine());
                    ThamSoKetNoi.DatabaseName = MaHoaString.Decrypt(stw.ReadLine());
                    ThamSoKetNoi.UserName = MaHoaString.Decrypt(stw.ReadLine());
                    ThamSoKetNoi.PassWord = MaHoaString.Decrypt(stw.ReadLine());
                    stw.Close();
                    stw.Dispose();
                    return true;
                }
                catch
                {
                    stw.Dispose();
                    return false;
                }
            }
            return false;
        }

        public static void ghifileDB(string pad, string Host, string Db, string uName, string pass)
        {
            MaHoaString.key = "z3r0.IT";
            StreamWriter stw = new StreamWriter(pad);
            stw.WriteLine("{0}", MaHoaString.Encrypt(Host));
            stw.WriteLine("{0}", MaHoaString.Encrypt(Db));
            stw.WriteLine("{0}", MaHoaString.Encrypt(uName));
            stw.WriteLine("{0}", MaHoaString.Encrypt(pass));
            stw.Close();
        }

        public static TaiKhoan docFileLG(string pad)
        {
            if (File.Exists(pad))
            {
                StreamReader stw = null;
                try
                {
                    stw = new StreamReader(pad);
                    MaHoaString.key = "HuyenTrang";
                    TaiKhoan ac = new TaiKhoan(MaHoaString.Decrypt(stw.ReadLine()),
                        MaHoaString.Decrypt(stw.ReadLine()));
                    stw.Close();
                    stw.Dispose();
                    return ac;
                }
                catch
                {
                    stw.Dispose();
                    return null;
                }
            }
            return null;
        }

        public static void ghifileLG(string pad, string uName, string pass)
        {
            MaHoaString.key = "HuyenTrang";
            StreamWriter stw = new StreamWriter(pad);
            stw.WriteLine("{0}", MaHoaString.Encrypt(uName));
            stw.WriteLine("{0}", MaHoaString.Encrypt(pass));
            stw.Close();
        }

        public static void XoaFile(string pad)
        {
            if (File.Exists(pad))
            {
                File.Delete(pad);
            }
            else
            {
                return;
            }
        }
    }
}