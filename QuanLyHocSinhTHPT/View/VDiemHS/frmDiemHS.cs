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
        string _MaHS;
        int _state;
        public frmDiemHS(string MaHS,int state)
        {
            InitializeComponent();
            _MaHS = MaHS;
            _state = state;
        }

        private List<Diem> lstDiem;

        private int CurCl = 0, CurR = 0;
        private string IDmember;
        private string MaHS = "";
        private string HoTen = "";
        private string MaMH = "";
        private string TenMon = "";
        private double DiemMieng = 0;
        private double Diem15p = 0;
        private double Diem1h = 0;
        private double DiemHK = 0;

        public void Hienthi()
        {
            if(_state==1)
            {
                lstDiem = DiemController.getAllDataDiem(_MaHS);
            }
            else
            {
                lstDiem = DiemController.getAllDataDiem();
            }
            DataTable dt = ViewHelper.ToDataTable<Diem>(lstDiem);
            dtgIDemHS.DataSource = dt;
            dtgIDemHS.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dt.Columns["HoTen"].ColumnName = "Họ Tên";
            dt.Columns["TenMon"].ColumnName = "Môn Học";
            dt.Columns["TenLop"].ColumnName = "Tên Lớp";
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
            MaHS = lstDiem[i].MaHS;
            MaMH = lstDiem[i].MaMH;
            txtDiemMieng.Text = lstDiem[i].DiemMieng.ToString();
            DiemMieng = lstDiem[i].DiemMieng;
            txtDiem15p.Text = lstDiem[i].Diem15p.ToString();
            Diem15p = lstDiem[i].Diem15p;
            txtDiem1h.Text = lstDiem[i].Diem1h.ToString();
            Diem1h = lstDiem[i].Diem1h;
            txtDiemHK.Text = lstDiem[i].DiemHK.ToString();
            DiemHK = lstDiem[i].DiemHK;
        }

        private void frmDiemHS_Load(object sender, EventArgs e)
        {
            Hienthi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (IDmember != null)
            {
                frmThaoTacDiem frm = new frmThaoTacDiem(MaMH, MaHS, DiemMieng, Diem15p, Diem1h, DiemHK, 2);
                frm.ShowDialog(); Hienthi();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 Bản ghi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (IDmember != null)
            {
                if (IDmember == "KHDEL")
                {
                    MessageBox.Show("Không thể xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (MessageBox.Show("Bạn có muốn xóa dữ liệu đã chọn", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (DiemController.XoaDiem(MaHS,MaMH))
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); Hienthi();
                        IDmember = null;
                    }
                    else
                    {
                        MessageBox.Show("Xóa Không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 Bản ghi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            file.ExportToExcel(dtgIDemHS);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThaoTacDiem frm = new frmThaoTacDiem(null, null, 0, 0, 0, 0, 1);
            frm.ShowDialog(); Hienthi();
        }
    }
}