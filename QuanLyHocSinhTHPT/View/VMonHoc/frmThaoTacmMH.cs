using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Helpers;
using QuanLyHocSinhTHPT.Controller;
using QuanLyHocSinhTHPT.Models;
using QuanLyHocSinhTHPT.Helper;

namespace QuanLyHocSinhTHPT.View.VMonHoc
{
    public partial class frmThaoTacmMH : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region
        /*

        MonHocController mhc;
        string _ID = null;
        public frmThaoTacmMH(string id)
        {
            InitializeComponent();
            _ID = id;
            mhc = new MonHocController();
            MonHoc mh = new MonHoc();
            //Xử lý mã lớp
            DataTable dt = sqlHelper.Query("SELECT Malop FROM Lop");
            if (id == null)
            {
                txtMaMH.Enabled = true;
                return;
            }
            mh = mhc.GetData(id);
            txtMaMH.Text = mh.MaMon;
            txtTenMon.Text = mh.TenMon;
            txtHeSo.Text = mh.HeSo;
        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mhc = new MonHocController();
            if (mhc.CheckErr(txtTenMon.Text.Trim(), txtTenMon.Text.Trim(), txtHeSo.Text.Trim()))
            {
                if (_ID == null)
                {
                    if (mhc.ThemMH(txtMaMH.Text.Trim(), txtTenMon.Text.Trim(), txtHeSo.Text.Trim()))
                    {
                        MessageBox.Show("Thành Công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (mhc.SuaMH(txtMaMH.Text.Trim(), txtTenMon.Text.Trim(), txtHeSo.Text.Trim(), txtMaMH.Text.Trim()))
                    {
                        MessageBox.Show("Thành Công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void bbiSaveAndClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bbiSave_ItemClick(sender, e);
            this.Close();
        }

        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        */
        #endregion
    }
}