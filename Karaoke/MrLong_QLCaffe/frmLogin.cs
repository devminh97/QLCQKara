using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using MrLong_QLCaffe.AccessData;
using MrLong_QLCaffe.layerObject;
using MrLong_QLCaffe.layerLogic;

namespace MrLong_QLCaffe
{
    public partial class frmLogin : DevComponents.DotNetBar.Office2007Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        ConnectData conn = new ConnectData();
        LoginLogic logicLogin = new LoginLogic();
        LoginObj objLogin = new LoginObj();
        private void butDangNhap_Click(object sender, EventArgs e)
        {
            DataTable tableLogin = conn.LấyDữLiệu("Select * from tblNhanVien where TenDangNhap=N'" + txtTenDangNhap.Text + "' and MatKhau=N'" + txtMatKhau.Text + "'");
            if (txtMatKhau.Equals(""))
            {
                MessageBox.Show("Mật khẩu không hợp lệ");
                txtMatKhau.Focus();
            }
            else
            if (txtTenDangNhap.Text =="")
            {
                MessageBox.Show("Tên đăng nhập không hợp lệ");
                txtMatKhau.Focus();
            }
            else
                if (tableLogin.Rows.Count == 1)
                {
                    NguoiDung.user = logicLogin.LayTTNguoiDung(txtTenDangNhap.Text);
                }
            
        }

      

        private void buttonX2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.butDangNhap.PerformClick();
            }
        }

        private void butDangNhap_Click_1(object sender, EventArgs e)
        {
            DataTable tableLogin = conn.LấyDữLiệu("Select * from tblNhanVien where TenDangNhap=N'" + txtTenDangNhap.Text + "' and MatKhau=N'" + txtMatKhau.Text + "'");
            if (txtTenDangNhap.Text == "")
            {
                MessageBox.Show("Tên đăng nhập không hợp lệ");
                txtTenDangNhap.Focus();
            }

            else
                if (txtMatKhau.Text == "")
                {
                    MessageBox.Show("Mật khẩu không hợp lệ");
                    txtMatKhau.Focus();
                }
                else
                    if (tableLogin.Rows.Count == 1)
                    {
                        NguoiDung.user = logicLogin.LayTTNguoiDung(txtTenDangNhap.Text);
                        MessageBox.Show("Chúc mừng bạn đã đăng nhập thành công");
                        DialogResult = DialogResult.OK;

                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai.\n\r\tVui lòng nhập lại");
                        txtTenDangNhap.Focus();
                    }
            
        }

        private void linkQuenPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Bạn quên mật khẩu hoặc tài khoản.\n\rVui lòng liên hệ Admin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        

       

        
    }
}