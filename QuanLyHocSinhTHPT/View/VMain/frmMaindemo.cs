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

namespace QuanLyHocSinhTHPT.View.VMain
{
    public partial class frmMaindemo : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMaindemo()
        {
            InitializeComponent();
        }

        private TaiKhoan nd;

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

        private void btnLogin_ItemClick(object sender, ItemClickEventArgs e)
        {
            nd = new TaiKhoan();
            frmLogin login = new frmLogin();
            login.ShowDialog();
            nd = SingletonData.Getlates().nguoidung;
            if (nd != null)
            {
                btnLogin.Enabled = false;
                menuQuanLy.Visible = true;
            }
        }

        private bool ExitsForm(Form form)
        {
            foreach (var child in MdiChildren)
            {
                if (child.Name == form.Name)
                {
                    child.Activate();
                    return true;
                }
            }
            return false;
        }

        private void btnGiaoVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            var formGV = new VGiaoVien.frmMainGiaoVien();
            if (ExitsForm(formGV)) return;
            formGV.MdiParent = this;
            formGV.Show();
        }

        private void btnHocSinh_ItemClick(object sender, ItemClickEventArgs e)
        {
            var formHS = new VHocSinh.frmMainHocSinh();
            if (ExitsForm(formHS)) return;
            formHS.MdiParent = this;
            formHS.Show();
        }

        private void barMonHoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            var formMonHoc = new VMonHoc.frmMainMonHoc();
            if (ExitsForm(formMonHoc)) return;
            formMonHoc.MdiParent = this;
            formMonHoc.Show();
        }

        private void barLopHoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frmlopHoc = new VLop.frmMainLop();
            if (ExitsForm(frmlopHoc)) return;
            frmlopHoc.MdiParent = this;
            frmlopHoc.Show();
        }

        private void barPhongHoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frmPhongHoc = new VPhongHoc.frmMainPhongHoc();
            if (ExitsForm(frmPhongHoc)) return;
            frmPhongHoc.MdiParent = this;
            frmPhongHoc.Show();
        }

        private void barChuNhiem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frmChuNhiem = new VChuNhiem.frmMainChuNhiem();
            if (ExitsForm(frmChuNhiem)) return;
            frmChuNhiem.MdiParent = this;
            frmChuNhiem.Show();
        }

        private void barDiemHS_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frmDiemHS = new VDiemHS.frmDiemHS(null, 2);
            if (ExitsForm(frmDiemHS)) return;
            frmDiemHS.MdiParent = this;
            frmDiemHS.Show();
        }

        public void Disable()
        {
            menuQuanLy.Visible = false;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Disable();
        }

        private void btnThongkeDiem_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private void btnPhanlop_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frmPhanLop = new VPhongHoc.frmPhongLop();
            if (ExitsForm(frmPhanLop)) return;
            frmPhanLop.MdiParent = this;
            frmPhanLop.Show();
        }
    }
}