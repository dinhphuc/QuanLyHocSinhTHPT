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
        private string MaLop = "";
        private string TenLop = "";
        private string NiemKhoa = "";

        public void Hienthi()
        {
            lstLop = LopController.getAllDataClass();
            DataTable dt = ViewHelper.ToDataTable<Lop>(lstLop);
            dtgLopHoc.DataSource = dt;
            dtgLopHoc.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dt.Columns["Malop"].ColumnName = "Mã Lớp";
            dt.Columns["TenLop"].ColumnName = "Tên Lớp";
            dt.Columns["NiemKhoa"].ColumnName = "Niêm khóa";
            int j = 0;
            foreach (DataGridViewColumn col in dtgLopHoc.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                dtgLopHoc.Columns[j].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                j++;
            }
            try { dtgLopHoc.CurrentCell = dtgLopHoc[CurCl, CurR]; } catch { }
            //lblTongSL.Text = GetTongSobanGhi("select * from Lop").ToString();
            dtgLopHoc.Refresh();
        }

        private void frmMainLop_Load(object sender, EventArgs e)
        {
            Hienthi();
        }

        private int i = 0;

        private void dtgLopHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDmember = dtgLopHoc.CurrentRow.Cells[0].Value.ToString();
            CurCl = dtgLopHoc.CurrentCell.ColumnIndex;
            CurR = dtgLopHoc.CurrentCell.RowIndex;
            i = CurR;
            // show data
            txtID.Text = MaLop = lstLop[i].MaLop;
            txtTenMon.Text = TenLop = lstLop[i].TenLop;
            txtNiemKhoa.Text = NiemKhoa = lstLop[i].NiemKhoa;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            file.ExportToExcel(dtgLopHoc);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
        }
    }
}