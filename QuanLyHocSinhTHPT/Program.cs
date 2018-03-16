using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinhTHPT
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (Helper.file.docFileDB("DB-info.bin"))
            {
                Helper.ThamSoKetNoi.TaoChuoiKetNoi();
                Application.Run(new View.Main.frmMain());
            }
            else
            {
                Application.Run(new View.Main.LoadDataBase());
            }
        }
    }
}
