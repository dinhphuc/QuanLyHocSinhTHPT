using QuanLyHocSinhTHPT.Controller;
using QuanLyHocSinhTHPT.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyHocSinhTHPT.View.VDiemHS
{
    public partial class frmMainThongKe : Form
    {
        public frmMainThongKe()
        {
            InitializeComponent();
        }

        private void frmMainThongKe_Load(object sender, EventArgs e)
        {
            //charDiemHS.ChartAreas[0].AxisX.Maximum = 30;
            //charDiemHS.ChartAreas[0].AxisX.Minimum = 0;
            //charDiemHS.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;
            //charDiemHS.ChartAreas["ChartArea1"].CursorX.IsUserSelectionEnabled = true;
            //List<DiemThongKe> lstdtk = ThongKeController.getData();
            //foreach (DiemThongKe dtk in lstdtk)
            //{
            //    this.charDiemHS.Series["XuatSac"].Points.AddXY(dtk.MaLop, dtk.XuatSac);
            //    this.charDiemHS.Series["Gioi"].Points.AddXY(dtk.MaLop, dtk.Gioi);
            //    this.charDiemHS.Series["Kha"].Points.AddXY(dtk.MaLop, dtk.Kha);
            //    this.charDiemHS.Series["TrungBinhKha"].Points.AddXY(dtk.MaLop, dtk.TrungBinhKha);
            //    this.charDiemHS.Series["TrungBinh"].Points.AddXY(dtk.MaLop, dtk.TrungBinh);
            //    this.charDiemHS.Series["Yeu"].Points.AddXY(dtk.MaLop, dtk.Yeu);
            //    this.charDiemHS.Series["Kem"].Points.AddXY(dtk.MaLop, dtk.Kem);
            //}
        }
    }
}