using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MrLong_QLCaffe.AccessData;
using MrLong_QLCaffe.layerLogic;
using MrLong_QLCaffe.layerObject;


namespace MrLong_QLCaffe
{
    public partial class frmChangePass : Form
    {
        public frmChangePass()
        {
            InitializeComponent();
        }
        ChangePassLogic logicChangePass = new ChangePassLogic();
        ChangePassObj objChangePass = new ChangePassObj();
        private ChangePassObj objChanger()
        {
            objChangePass.Moi = txtMoi1.Text;
            return objChangePass;
        }
        private void frmChangePass_Load(object sender, EventArgs e)
        {
           // this.Cursor = new Cursor("1.cur");
            label4.Visible = false;
            label5.Visible = false;
        }

        private void butOK_Click(object sender, EventArgs e)
        {
           if((txtCu.Text == "") || (txtMoi1.Text == "") || (txtMoi2.Text == ""))
           { MessageBox.Show("Vui lòng điền đầy đủ."); }
            else
               if (txtCu.Text != NguoiDung.user.MatKhau)
            {
                MessageBox.Show("Mật khẩu cũ không đúng. Vui lòng nhập lại");
                txtCu.Focus();
            }
            else
                if (txtMoi1.Text != txtMoi2.Text)
                {
                    MessageBox.Show("2 lần mật khẩu mới không giống nhau");
                }
                else
                {
                    logicChangePass.ChangePass(objChanger());
                    label4.Visible = false;
                    label5.Visible = false;
                }
        }

        private void txtMoi2_TextChanged(object sender, EventArgs e)
        {
            if (txtMoi1.Text == txtMoi2.Text)
            {
                
                label4.Visible = true;
            }
        }

        private void butCance_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMoi1_TextChanged(object sender, EventArgs e)
        {
            label5.Visible = true;
        }

    }
}
