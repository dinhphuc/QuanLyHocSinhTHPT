using QuanLyHocSinhTHPT.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyHocSinhTHPT.Models;
using QuanLyHocSinhTHPT.Help;

namespace QuanLyHocSinhTHPT.View.VMain
{
    public partial class LoadDataBase : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public LoadDataBase()
        {
            InitializeComponent();
            //DevExpress.LookAndFeel.DefaultLookAndFeel theme = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            //theme.LookAndFeel.SkinName = "Office 2013";
        }

        private SqlConnection myConnect;

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string sHost = txtTenMayChu.Text.Trim();
            string sDB = txtCSDL.Text.Trim();
            string sUN = txtTenDangNhap.Text.Trim();
            string sPW = txtMatKhau.Text.Trim();
            try
            {
                if (sHost == "")
                {
                    MessageBox.Show("Trống Tên Host", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ActiveControl = txtTenMayChu;
                }
                if (sDB == "")
                {
                    MessageBox.Show("Trống Tên Tên CSDL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ActiveControl = txtCSDL;
                }
                if (radXacThucSQL.Checked == true)
                {
                    if (sUN == "")
                    {
                        MessageBox.Show("Trống Tên Usename", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ActiveControl = txtTenDangNhap;
                    }
                    if (sPW == "")
                    {
                        MessageBox.Show("Trống pass", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ActiveControl = txtMatKhau;
                    }
                    Help.ThamSoKetNoi.UserName = sUN;
                    Help.ThamSoKetNoi.PassWord = sPW;
                }

                Help.ThamSoKetNoi.ServerName = sHost;
                Help.ThamSoKetNoi.DatabaseName = sDB;
                Help.ThamSoKetNoi.TaoChuoiKetNoi();

                myConnect = new SqlConnection(Help.ThamSoKetNoi.StringConnect);
                SqlCommand myCommand = new SqlCommand();
                myCommand.CommandText = "Select * from TaiKhoan";
                myCommand.CommandType = CommandType.Text;
                myCommand.CommandTimeout = 30;
                myCommand.Connection = myConnect;
                myConnect.Open();
                if (myConnect.State == ConnectionState.Open)
                {
                    ckLuu.Enabled = true;
                    MessageBox.Show("Kết Nối Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnDangNhap.Enabled = false;
                    btnLgHT.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Kết Nối không Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Kết Nối Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string padFile = "DB-info.bin";

        private void LoadDataBase_Load(object sender, EventArgs e)
        {
            btnLgHT.Enabled = false;
            ckLuu.Enabled = false;
            radXacThucWindow.Checked = true;
            txtTenDangNhap.Enabled = false;
            txtMatKhau.Enabled = false;
            file.docFileDB(padFile);
            txtTenMayChu.Text = ThamSoKetNoi.ServerName;
            txtCSDL.Text = ThamSoKetNoi.DatabaseName;
            txtTenDangNhap.Text = ThamSoKetNoi.UserName;
            txtMatKhau.Text = ThamSoKetNoi.PassWord;
        }

        private void radXacThucWindow_CheckedChanged(object sender, EventArgs e)
        {
            txtTenDangNhap.Enabled = false;
            txtMatKhau.Enabled = false;
        }

        private void radXacThucSQL_CheckedChanged(object sender, EventArgs e)
        {
            txtTenDangNhap.Enabled = true;
            txtMatKhau.Enabled = true;
        }

        private void ckLuu_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (myConnect.State == ConnectionState.Open)
                {
                    file.ghifileDB(padFile, txtTenMayChu.Text.Trim(), txtCSDL.Text.Trim(), txtTenDangNhap.Text.Trim(),
                txtMatKhau.Text.Trim());
                    lblsuccess.Text = "✓ success";
                    ckLuu.Enabled = false;
                }
                else
                {
                    lblsuccess.Text = "X error";
                }
            }
            catch
            {
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLgHT_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMaindemo lg = new frmMaindemo();
            lg.ShowDialog();
            this.Dispose();
        }

        public void changeText()
        {
            btnDangNhap.Enabled = true;
            btnLgHT.Enabled = false;
        }

        private void txtTenMayChu_KeyPress(object sender, KeyPressEventArgs e)
        {
            changeText();
        }

        private void txtCSDL_TextChanged(object sender, EventArgs e)
        {
            changeText();
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            changeText();
        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {
            changeText();
        }

        private void LoadDataBase_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }

        private void txtTenMayChu_TextChanged(object sender, EventArgs e)
        {
            changeText();
        }
    }
}