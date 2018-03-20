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

namespace QuanLyHocSinhTHPT.View.VDiemHS
{
    public partial class frmDiemHS : Form
    {
        public frmDiemHS()
        {
            InitializeComponent();
        }

        private List<Diem> lstDiem;

        private int CurCl = 0, CurR = 0;
        private string IDmember;
        private string MaHS = "";
        private string HoTen = "";
        private string MaMH = "";
        private string TenMon = "";
        private string DiemMieng = "";
        private string Diem15p = "";
        private string Diem1h = "";
        private string DiemHK = "";

        public void Hienthi()
        {
            lstDiem = DiemController.getAllDataDiem();
            DataTable dt = ViewHelper.ToDataTable<Diem>(lstDiem);
            dtgIDemHS.DataSource = dt;
            dtgIDemHS.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dt.Columns["HoTen"].ColumnName = "Họ Tên";
            dt.Columns["TenMon"].ColumnName = "Môn Học";
            dt.Columns["DiemMieng"].ColumnName = "Điểm miệng";
            dt.Columns["Diem15p"].ColumnName = "Điểm 15 phút";
            dt.Columns["Diem1h"].ColumnName = "Điểm 1 tiết";
            dt.Columns["DiemHK"].ColumnName = "Điểm học kì";
            int i = 0;
            foreach (DataGridViewColumn col in dtgIDemHS.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                dtgIDemHS.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                i++;
            }
            try { dtgIDemHS.CurrentCell = dtgIDemHS[CurCl, CurR]; } catch { }
            dtgIDemHS.Refresh();
        }

        private int i = 0;

        private void dtgIDemHS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDmember = dtgIDemHS.CurrentRow.Cells[0].Value.ToString();
            CurCl = dtgIDemHS.CurrentCell.ColumnIndex;
            CurR = dtgIDemHS.CurrentCell.RowIndex;
            i = CurR;
            // show data
            txtTenHS.Text = HoTen = lstDiem[i].HoTen;
            txtTenMon.Text = TenMon = lstDiem[i].TenMon;
            txtDiemMieng.Text = DiemMieng = lstDiem[i].DiemMieng.ToString();
            txtDiem15p.Text = Diem15p = lstDiem[i].Diem15p.ToString();
            txtDiem1h.Text = Diem1h = lstDiem[i].Diem1h.ToString();
            txtDiemHK.Text = DiemHK = lstDiem[i].DiemHK.ToString();
        }

        private void frmDiemHS_Load(object sender, EventArgs e)
        {
            Hienthi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
        }
    }
}