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

namespace QuanLyHocSinhTHPT.View.VChuNhiem
{
    public partial class frmMainChuNhiem : Form
    {
        public frmMainChuNhiem()
        {
            InitializeComponent();
        }

        //var
        private List<ChuNhiem> lstCN;

        private int CurCl = 0, CurR = 0;
        private string IDmember;
        private string MaGV = "";
        private string MaLop = "";
        private string TenLop = "";
        private string NiemKhoa = "";

        public void Hienthi()
        {
            lstCN = ChuNhiemController.getAllDataChuNhiem();
            DataTable dt = ViewHelper.ToDataTable<ChuNhiem>(lstCN);
            dtgChuNhiem.DataSource = dt;
            dtgChuNhiem.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dt.Columns["MaGV"].ColumnName = "Mã GV";
            dt.Columns["HoTen"].ColumnName = "Họ Tên Giáo viên";
            dt.Columns["TenLop"].ColumnName = "Tên Lớp";
            dt.Columns["NiemKhoa"].ColumnName = "Niêm Khóa";
            int i = 0;
            foreach (DataGridViewColumn col in dtgChuNhiem.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                dtgChuNhiem.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                i++;
            }
            try { dtgChuNhiem.CurrentCell = dtgChuNhiem[CurCl, CurR]; } catch { }
            dtgChuNhiem.Refresh();
        }

        private void frmMainChuNhiem_Load(object sender, EventArgs e)
        {
            Hienthi();
        }

        private int i = 0;

        private void dtgChuNhiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dtgChuNhiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDmember = dtgChuNhiem.CurrentRow.Cells[0].Value.ToString();
            CurCl = dtgChuNhiem.CurrentCell.ColumnIndex;
            CurR = dtgChuNhiem.CurrentCell.RowIndex;
            i = CurR;
            // show data
            cbTenGV.Text = MaGV = lstCN[i].MaGV;
            cbTenLop.Text = TenLop = lstCN[i].HoTen;
            txtNamHoc.Text = NiemKhoa = lstCN[i].NiemKhoa;
            MaLop = lstCN[i].MaLop;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            frmThaoTacChuNhiem frmSua = new frmThaoTacChuNhiem(MaGV, MaLop, txtNamHoc.Text, 1);
            frmSua.ShowDialog();
            Hienthi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThaoTacChuNhiem frmThem = new frmThaoTacChuNhiem(null, null, null, 0);
            frmThem.ShowDialog();
            Hienthi();
        }
    }
}