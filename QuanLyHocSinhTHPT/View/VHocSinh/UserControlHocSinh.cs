using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyHocSinhTHPT.Models;
using QuanLyHocSinhTHPT.Controller;
using QuanLyHocSinhTHPT.Helper;

namespace QuanLyHocSinhTHPT.View.VHocSinh
{
    public partial class UserControlHocSinh : UserControl
    {
        public UserControlHocSinh()
        {
            InitializeComponent();
        }

        private List<HocSinh> lstHS;

        public void Hienthi()
        {
            lstHS = HocSinhController.getAllDataHS();
            DataTable dt = ViewHelper.ToDataTable<HocSinh>(lstHS);
            dtgHocSinh.DataSource = dt;
            dtgHocSinh.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dt.Columns["MaHS"].ColumnName = "Mã HS";
            dt.Columns["HoTen"].ColumnName = "Họ Tên";
            dt.Columns["NgaySinh"].ColumnName = "Ngày Sinh";
            dt.Columns["DiaChi"].ColumnName = "Địa Chỉ";
            dt.Columns["GioiTinh"].ColumnName = "Giới Tính (Nữ ✓/nam)";
            dt.Columns["HoTenPhuHuynh"].ColumnName = "Tên Phụ Huynh";
            dt.Columns["SDTphuHuynh"].ColumnName = "SDT Phụ Huynh";
            dt.Columns["MaLop"].ColumnName = "Mã Lớp";
            int i = 0;
            foreach (DataGridViewColumn col in dtgHocSinh.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                dtgHocSinh.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                i++;
            }
            try { dtgHocSinh.CurrentCell = dtgHocSinh[CurCl, CurR]; } catch { }

            //lblTongSL.Text = GetTongSobanGhi("select * from HocSinh").ToString();
            dtgHocSinh.Refresh();
        }

        private int CurCl = 0, CurR = 0;
        private string _Query = "select * from HocSinh";
        private string IDmember;

        private void UserControlHocSinh_Load(object sender, EventArgs e)
        {
            Hienthi();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
        }
    }
}