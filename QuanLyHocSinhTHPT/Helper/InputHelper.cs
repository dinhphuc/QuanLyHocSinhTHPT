using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyHocSinhTHPT.Helper;
using QuanLyHocSinhTHPT.Models;

namespace QuanLyHocSinhTHPT.Helper
{
    class InputHelper
    {
        public static int InputINT(string msg, string err)
        {
            string Err = string.Format("{0}, Vui lòng nhập lại", err);
            int ret;
            bool ok;
            do
            {
                ok = int.TryParse(msg, out ret);
                if (!ok)
                    MessageBox.Show(Err, "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (ret <= 0)
                {
                    MessageBox.Show("Sai Giá trị, Vui Lòng nhập lại", "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else ok = true;
            } while (!ok);
            return ret;
        }
        public static string InputSTR(string msg, string err, int MIN = int.MinValue, int MAX = int.MaxValue)
        {
            string ret;
            bool ok;
            do
            {
                ret = msg;
                if (ret.Length < MIN || ret.Length > MAX)
                {
                    ok = false;
                    MessageBox.Show("Quá độ dài, Vui Lòng nhập lại", "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else ok = true;
            } while (!ok);
            return ret;
        }
        public static DateTime InputDT(string msg, string err, DateTime dtMin, DateTime dtMax)
        {
            DateTime ret;
            bool ok;
            do
            {
                ok = DateTime.TryParse(msg, out ret);
                if (!ok)
                    MessageBox.Show("Sai định dạng, Vui lòng nhập lại", "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (ret < dtMin || ret > dtMax)
                {
                    ok = false;
                    MessageBox.Show("Không nằm trong khoảng, Vui lòng nhập lại", "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else ok = true;
            } while (!ok);
            return ret;
        }
    }
}
