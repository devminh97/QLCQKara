using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MrLong_QLCaffe.layerObject;
using MrLong_QLCaffe.layerLogic;

namespace MrLong_QLCaffe
{
    public partial class frmThanhToan : Form
    {
        string Ten;
        string Tien;
        string MaHoaDon;
        string TienGio;
        HoaDonObj objHD = new HoaDonObj();
        private HoaDonObj GetHoaDon()
        {
            objHD.MaHoaDon = MaHoaDon;
            objHD.TongTien = decimal.Parse(Tien);
            objHD.TienGio = decimal.Parse(TienGio);
            return objHD;
        }
        public frmThanhToan(string TenPhong, string SoTien, string TienGi, string MaHD)
        {
            Ten = TenPhong;
            Tien = SoTien;
            MaHoaDon = MaHD;
            TienGio = TienGi;
            InitializeComponent();
        }
        
        private void frmThanhToan_Load(object sender, EventArgs e)
        {
            lblPhong.Text = Ten;
            lblTien.Text = String.Format("{0:0,0}",double.Parse(Tien));
        }

        private void butIn_Click(object sender, EventArgs e)
        {
            if (logicTinhTien.ThanhToan(GetHoaDon()) == true)
            {
                report.rptHoaDon a = new MrLong_QLCaffe.report.rptHoaDon(MaHoaDon);
                a.ShowDialog();
                this.Close();
            }
        }

        private void butHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        TinhTienLogic logicTinhTien = new TinhTienLogic();
        private void butKhongIn_Click(object sender, EventArgs e)
        {
            if (logicTinhTien.ThanhToan(GetHoaDon()) == true)
                this.Close();
        }

        private void butXemHD_Click(object sender, EventArgs e)
        {
            if (logicTinhTien.XemHD(GetHoaDon()) == true)
            {
                report.rptHoaDon a = new MrLong_QLCaffe.report.rptHoaDon(MaHoaDon);
                a.ShowDialog();
            }
        }

       
    }
}
