﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyHocSinhTHPT.Helper;
using QuanLyHocSinhTHPT.Models;
using Dapper;
using QuanLyHocSinhTHPT.Controller;

namespace QuanLyHocSinhTHPT.View.Main
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private string padFile = "LgData.bin";

        private void frmLogin_Load(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            ckLuu.Checked = true;
            try
            {
                TaiKhoan ac = new TaiKhoan();
                ac = file.docFileLG(padFile);
                txtUserName.Text = ac.TenTaiKhoan;
                txtPassWord.Text = ac.Matkhau;
            }
            catch
            { }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private List<TaiKhoan> lstTK;

        private void btnDangNhap_Click_1(object sender, EventArgs e)
        {
            lstTK = TaiKhoanController.getAllDataTaiKhoan();
            try
            {
                foreach (TaiKhoan tk in lstTK)
                {
                    if (tk.TenTaiKhoan == txtUserName.Text.Trim() && tk.Matkhau == txtPassWord.Text.Trim())
                    {
                        SingletonData.Getlates().nguoidung = new TaiKhoan() { TenTaiKhoan = txtUserName.Text };
                        MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (ckLuu.Checked)
                        {
                            file.ghifileLG(padFile, txtUserName.Text.Trim(),
                            txtPassWord.Text.Trim());
                            lblLuu.Text = "✓ success";
                            ckLuu.Enabled = false;
                            btnDangNhap.Enabled = true;
                        }
                        else
                        {
                            lblLuu.Text = "X error";
                        }
                        this.Close();
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SingletonData.Getlates().nguoidung = null;
            MessageBox.Show("Đăng nhập thất bại. Xem lại tài khoản hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}