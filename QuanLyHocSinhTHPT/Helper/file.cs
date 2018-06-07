using QuanLyHocSinhTHPT.Help;
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
            TaiKhoan ac = new TaiKhoan(); ;
            if (File.Exists(pad))
            {
                StreamReader stw = null;
                try
                {
                    stw = new StreamReader(pad);
                    MaHoaString.key = "HuyenTrang";
                    ac = new TaiKhoan(MaHoaString.Decrypt(stw.ReadLine()),
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
            return ac;
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

        /// <summary>
        /// Exports the datagridview values to Excel.
        /// </summary>
        public static void ExportToExcel(DataGridView dtgr)
        {
            // Creating a Excel object.
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            try
            {
                worksheet = workbook.ActiveSheet;

                worksheet.Name = "ExportedFromDatGrid";

                int cellRowIndex = 1;
                int cellColumnIndex = 1;

                //Loop through each row and read value from each column.
                for (int i = -1; i < dtgr.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dtgr.Columns.Count; j++)
                    {
                        // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check.
                        if (cellRowIndex == 1)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dtgr.Columns[j].HeaderText;
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dtgr.Rows[i].Cells[j].Value.ToString();
                        }
                        cellColumnIndex++;
                    }
                    cellColumnIndex = 1;
                    cellRowIndex++;
                }
                worksheet.Columns.AutoFit();
                //Getting the location and file name of the excel to save from user.
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 2;

                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    MessageBox.Show("Export Successful");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                excel.Quit();
                workbook = null;
                excel = null;
            }
        }
    }
}