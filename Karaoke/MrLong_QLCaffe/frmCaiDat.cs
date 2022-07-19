using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using MrLong_QLCaffe.layerLogic;
using MrLong_QLCaffe.layerObject;

namespace MrLong_QLCaffe
{
    public partial class frmCaiDat : DevComponents.DotNetBar.Office2007Form
    {
        public frmCaiDat()
        {
            InitializeComponent();
        }

        ThongTinObj obj = new ThongTinObj();
        ThongTinLogic logicTT = new ThongTinLogic();
        private ThongTinObj GetThongTin()
        {
            obj.TenQuan = txtTenQuan.Text;
            obj.SDT = txtSDT.Text;
            obj.DC = txtDC.Text;
            obj.LoiChuc = txtLoiChuc.Text;
            return obj;
        }

        private void butLuu_Click(object sender, EventArgs e)
        {
            if (logicTT.Luu(GetThongTin()))
            {MessageBox.Show("Đã lưu thành công","Thông báo");
            }
        }

        private void butHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCaiDat_Load(object sender, EventArgs e)
        {
            
            
        }
    }
}