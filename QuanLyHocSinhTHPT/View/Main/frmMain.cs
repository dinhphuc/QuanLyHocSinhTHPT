using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using QuanLyHocSinhTHPT.View;
using QuanLyHocSinhTHPT.Helper;
using QuanLyHocSinhTHPT.Models;

namespace QuanLyHocSinhTHPT.View.Main
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private void disableAll()
        {
            btnQuanLyGiaoVien.Enabled = false;
            btnQuanLyHoc.Enabled = false;
            btnQuanLyHS.Enabled = false;
            btnQuanLyLopHoc.Enabled = false;
            btnQuanLyMonHoc.Enabled = false;
        }

        public frmMain()
        {
            InitializeComponent();
            disableAll();
        }

        private TaiKhoan nd;

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            nd = new TaiKhoan();
            frmLogin login = new frmLogin();
            login.ShowDialog();
            nd = SingletonData.Getlates().nguoidung;
            if (nd != null)
            {
                btnLogin.Enabled = false;
                lblNguoiDung.Caption = nd.TenTaiKhoan;
                btnQuanLyGiaoVien.Enabled = true;
                btnQuanLyHoc.Enabled = true;
                btnQuanLyHS.Enabled = true;
                btnQuanLyLopHoc.Enabled = true;
                btnQuanLyMonHoc.Enabled = true;
            }
        }

        private void btnQuanLyGiaoVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            VGiaoVien.frmGaioVien frm = new VGiaoVien.frmGaioVien();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnQuanLyHS_ItemClick(object sender, ItemClickEventArgs e)
        {
            VHocSinh.frmHocSinh frm = new VHocSinh.frmHocSinh();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnQuanLyMonHoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            VMonHoc.frmMonHoc frm = new VMonHoc.frmMonHoc();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnQuanLyLopHoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            VLop.frmLop frm = new VLop.frmLop();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnQuanLyHoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            VHoc.frmHoc frm = new VHoc.frmHoc();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void ChangeDb_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadDataBase frm = new LoadDataBase();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void pageBanQuyen_ItemClick(object sender, ItemClickEventArgs e)
        {
            Support.frmBanQuyen frm = new Support.frmBanQuyen();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}