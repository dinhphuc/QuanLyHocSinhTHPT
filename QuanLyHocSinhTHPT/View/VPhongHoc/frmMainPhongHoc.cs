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

namespace QuanLyHocSinhTHPT.View.VPhongHoc
{
    public partial class frmMainPhongHoc : Form
    {
        public frmMainPhongHoc()
        {
            InitializeComponent();
        }

        //var
        private List<PhongHoc> lstPhong;

        private int CurCl = 0, CurR = 0;
        private string IDmember;
        private string MaPhong = "";
        private string SoPhong = "";
        private string SoChoToiDa = "";

        private void frmMainPhongHoc_Load(object sender, EventArgs e)
        {
            Hienthi();
        }

        private int i = 0;

        private void dtgPhongHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDmember = dtgPhongHoc.CurrentRow.Cells[0].Value.ToString();
            CurCl = dtgPhongHoc.CurrentCell.ColumnIndex;
            CurR = dtgPhongHoc.CurrentCell.RowIndex;
            i = CurR;
            // show data
            txtMaPhong.Text = MaPhong = lstPhong[i].MaPhong;
            txtSoPhong.Text = SoPhong = lstPhong[i].SoPhong;
            txtSoChoToiDa.Text = SoChoToiDa = lstPhong[i].SoChoToiDa.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        public void Hienthi()
        {
            lstPhong = PhongHocController.getAllDataRoom();
            DataTable dt = ViewHelper.ToDataTable<PhongHoc>(lstPhong);
            dtgPhongHoc.DataSource = dt;
            dtgPhongHoc.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dt.Columns["MaPhong"].ColumnName = "Mã Phòng";
            dt.Columns["SoPhong"].ColumnName = "Tên Phòng";
            dt.Columns["SoChoToiDa"].ColumnName = "Số chỗ tối đa";
            int i = 0;
            foreach (DataGridViewColumn col in dtgPhongHoc.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                dtgPhongHoc.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                i++;
            }
            try { dtgPhongHoc.CurrentCell = dtgPhongHoc[CurCl, CurR]; } catch { }
            dtgPhongHoc.Refresh();
        }
    }
}