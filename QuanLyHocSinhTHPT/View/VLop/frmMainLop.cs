using QuanLyHocSinhTHPT.Controller;
using QuanLyHocSinhTHPT.Helper;
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

namespace QuanLyHocSinhTHPT.View.VLop
{
    public partial class frmMainLop : Form
    {
        public frmMainLop()
        {
            InitializeComponent();
        }

        private List<Lop> lstLop;
        private int CurCl = 0, CurR = 0;
        private string IDmember;

        public void Hienthi()
        {
            lstLop = LopController.getAllDataClass();
            DataTable dt = ViewHelper.ToDataTable<Lop>(lstLop);
            dtgLopHoc.DataSource = dt;
            dtgLopHoc.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dt.Columns["Malop"].ColumnName = "Mã Lớp";
            dt.Columns["TenLop"].ColumnName = "Tên Lớp";
            dt.Columns["LienKhoa"].ColumnName = "Liên khóa";
            foreach (DataGridViewColumn col in dtgLopHoc.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
            try { dtgLopHoc.CurrentCell = dtgLopHoc[CurCl, CurR]; } catch { }
            //lblTongSL.Text = GetTongSobanGhi("select * from Lop").ToString();
            dtgLopHoc.Refresh();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
        }
    }
}