using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MrLong_QLCaffe.AccessData;
using MrLong_QLCaffe.layerLogic;
using MrLong_QLCaffe.layerObject;

namespace MrLong_QLCaffe
{
    public partial class frmMain : Form
    {
        
        private void MoCuaSo(Form form)
        {
            foreach (Form frm in MdiChildren)
                if (frm.Name == form.Name)
                {
                    form.Dispose();
                    frm.Activate();
                    return;
                }
            form.MdiParent = this;
            form.Show();
        }
        private void HienThiMenuNguoiDung(string QuyenHan)
        {
            if (QuyenHan == "Nhân viên")
            {
                /*
                 * stripNhanVien.Enabled = false;
                   stripKhuVuc.Enabled = false;
                   stripLoaiSP.Enabled = false;
                   menuThongKE.Enabled = false;
                   menuXemHoaDon.Enabled = false;
                   stripBan.Enabled = false;
                   stripSanPham.Enabled = false;
                 */
                thôngTinToolStripMenuItem.Enabled = false;
                stripNhapLieu.Enabled = false;
                stripHoaDon.Enabled = false;
                
                frmBanHang a = new frmBanHang();
                a.MdiParent = this;
                
                a.Show();
            }
            else
            {
                
            }
        }
        public frmMain()
        {
            InitializeComponent();
        }
        
        
        private void frmMain_Load(object sender, EventArgs e)
        {
            skinEngine1.ApplyMainBuiltInSkin();
           
            frmLogin flg = new frmLogin();
            flg.ShowDialog();
            if (flg.DialogResult == DialogResult.OK)
            {
                HienThiMenuNguoiDung(NguoiDung.user.QuyenHan);
            }
            toolStripStatusLabel1.Text = "Đang đăng nhập: "+NguoiDung.user.TenNhanVien+"";
            thoigianstatus.Text = "Thời gian đăng nhập: " + DateTime.Now.ToShortTimeString() + "";

        }

        private void stripSanPham_Click(object sender, EventArgs e)
        {
            MoCuaSo(new frmSanPham());
        }

        private void stripLoaiSP_Click(object sender, EventArgs e)
        {
            MoCuaSo(new frmLoaiSP());
        }

        private void stripBan_Click(object sender, EventArgs e)
        {
            MoCuaSo(new frmBan());
        }

        private void stripKhuVuc_Click(object sender, EventArgs e)
        {
            MoCuaSo(new frmKhuVuc());
        }

        private void bánHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MoCuaSo(new frmBanHang());
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // MoCuaSo(new report.frmRep());
        }

        private void stripNhanVien_Click(object sender, EventArgs e)
        {
            MoCuaSo(new frmNhanVien());
        }

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoCuaSo(new frmBanHang());
        }

        private void xemHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoCuaSo(new frmHoaDon());
        }

        private void menuThongKE_Click(object sender, EventArgs e)
        {
            
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoCuaSo(new frmChangePass());
        }

        private void skin1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            skinEngine1.ApplyAdditionalBuiltInSkins(1);
        }

        private void skin2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            skinEngine1.ApplyAdditionalBuiltInSkins(2);
        }

        private void skin3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            skinEngine1.ApplyAdditionalBuiltInSkins(0);
        }

        private void skinĐầuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            skinEngine1.ApplyMainBuiltInSkin();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            timer1.Interval = 100;
            toolTimeHT.Text = "Bây giờ là: " + DateTime.Now.ToLongTimeString();
      
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoCuaSo(new frmCaiDat());
        }

        private void thốngKêBáoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoCuaSo(new report.rptThongKe());
        }

       
       

       
    }
}
