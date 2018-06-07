using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinhTHPT.Help
{
    public static class ThamSoKetNoi
    {
        public static string ServerName = "";
        public static string DatabaseName = "";
        public static string UserName = "";
        public static string PassWord = "";
        public static bool WinAuthentication = true;

        public static string StringConnect = "";

        public static void TaoChuoiKetNoi()
        {
            string temp = "";
            temp = "Data Source =" + ServerName + ";";
            temp += "Initial Catalog =" + DatabaseName + ";";
            if (WinAuthentication == true)
            {
                temp += "integrated security = true";
            }
            else
            {
                temp += "integrated security = false ; USser ID =" + UserName + ";"
                     + "Password = " + PassWord;
            }
            StringConnect = temp;
        }
    }
}