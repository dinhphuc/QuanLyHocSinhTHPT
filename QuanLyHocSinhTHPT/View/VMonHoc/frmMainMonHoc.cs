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

namespace QuanLyHocSinhTHPT.View.VMonHoc
{
    public partial class frmMainMonHoc : Form
    {
        public frmMainMonHoc()
        {
            InitializeComponent();
        }

        //var
        private List<MonHoc> lstMH;

        private int CurCl = 0, CurR = 0;
        private string IDmember;
        private string MaMon = "";
        private string TenMon = "";
        private string Khoi = "";

        private void frmMainMonHoc_Load(object sender, EventArgs e)
        {
            Hienthi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
        }

        private int i = 0;

        private void dtgMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDmember = dtgMonHoc.CurrentRow.Cells[0].Value.ToString();
            CurCl = dtgMonHoc.CurrentCell.ColumnIndex;
            CurR = dtgMonHoc.CurrentCell.RowIndex;
            i = CurR;
            // show data
            txtID.Text = MaMon = lstMH[i].MaMon;
            txtKhoi.Text = TenMon = lstMH[i].TenMon;
            txtTen.Text = Khoi = lstMH[i].Khoi;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            file.ExportToExcel(dtgMonHoc);
        }

        public void Hienthi()
        {
            lstMH = MonHocController.getAllDataSubject();
            DataTable dt = ViewHelper.ToDataTable<MonHoc>(lstMH);
            dtgMonHoc.DataSource = dt;
            dtgMonHoc.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dt.Columns["MaMon"].ColumnName = "Mã Môn";
            dt.Columns["TenMon"].ColumnName = "Tên Môn";
            dt.Columns["Khoi"].ColumnName = "Khối";
            int i = 0;
            foreach (DataGridViewColumn col in dtgMonHoc.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                dtgMonHoc.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                i++;
            }
            try { dtgMonHoc.CurrentCell = dtgMonHoc[CurCl, CurR]; } catch { }
            dtgMonHoc.Refresh();
        }
    }
}