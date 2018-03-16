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

namespace QuanLyHocSinhTHPT.View.VLop
{
    public partial class frmThaoTacLop : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region
        /*

        LopController lc;
        string _ID;
        public frmThaoTacLop(string id)
        {
            InitializeComponent();
            _ID = id;
            lc = new LopController();

            //Xử lý mã Môn
            DataTable ml = sqlHelper.Query("SELECT MaLop FROM Lop");
            List<DataRow> list = ml.AsEnumerable().ToList();
            for (int i = 0; i < list.Count; i++)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = list[i].ItemArray[0].ToString();
                item.Value = list[i].ItemArray[0].ToString();
                cbMaLop.Items.Add(item);
            }
            //Xử lý mã HocSinh
            DataTable mhs = sqlHelper.Query("SELECT MaGV FROM GiaoVien");
            List<DataRow> list1 = mhs.AsEnumerable().ToList();
            for (int i = 0; i < list1.Count; i++)
            {
                ComboboxItem item1 = new ComboboxItem();
                item1.Text = list1[i].ItemArray[0].ToString();
                item1.Value = list1[i].ItemArray[0].ToString();
                cbMaGV.Items.Add(item1);
            }
            if (id == null)
            {
                cbMaLop.Enabled = true;
                return;
            }
            Lop l = new Lop();
            l = lc.GetData(id);

            txtSiSo.Text = l.ToString();
            txtViTri.Text = l.ViTri;
            for (int i = 0; i < list.Count; i++)
            {
                if (l.Malop == list[i].ItemArray[0].ToString())
                {
                    cbMaLop.SelectedIndex = i;
                   l.Malop = cbMaLop.Text;
                    break;
                }
            }
            for (int i = 0; i < list1.Count; i++)
            {
                if (l.MaGV == list1[i].ItemArray[0].ToString())
                {
                    cbMaGV.SelectedIndex = i;
                    l.MaGV = cbMaGV.Text;
                    break;
                }
            }
            //Xử lý mã lớp
        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            lc = new LopController();
            if (lc.CheckErr(cbMaLop.Text.Trim(), txtViTri.Text.Trim(), txtSiSo.Text.Trim(),cbMaGV.Text.Trim()))
            {
                if (_ID == null)
                {
                    if (lc.ThemLop(cbMaLop.Text.Trim(), txtViTri.Text.Trim(), int.Parse(txtSiSo.Text.Trim()),cbMaGV.Text.Trim()))
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
                    if (lc.SuaLop(cbMaLop.Text.Trim(), txtViTri.Text.Trim(), int.Parse(txtSiSo.Text.Trim()), cbMaGV.Text.Trim(),cbMaLop.Text.Trim()))
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

        private void cbMaGV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(_ID==null)
            e.Handled = true;
        }
        */
        #endregion
    }
}