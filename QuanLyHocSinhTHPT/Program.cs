using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinhTHPT
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (Helper.file.docFileDB("DB-info.bin"))
            {
                try
                {
                    Help.ThamSoKetNoi.TaoChuoiKetNoi();
                    SqlConnection myConnect;
                    myConnect = new SqlConnection(Help.ThamSoKetNoi.StringConnect);
                    SqlCommand myCommand = new SqlCommand();
                    myCommand.CommandText = "Select * from TaiKhoan";
                    myCommand.CommandType = CommandType.Text;
                    myCommand.CommandTimeout = 30;
                    myCommand.Connection = myConnect;
                    myConnect.Open();
                    if (myConnect.State == ConnectionState.Open)
                    {
                        Application.Run(new View.VMain.frmMaindemo());
                    }
                    else
                    {
                        Application.Run(new View.VMain.LoadDataBase());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Run(new View.VMain.LoadDataBase());
                }
            }
            else
            {
                Application.Run(new View.VMain.LoadDataBase());
            }
        }
    }
}