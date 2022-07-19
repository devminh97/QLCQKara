using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MrLong_QLCaffe.report
{
    public partial class rptHoaDon : Form
    {
        string MaHD;
        public rptHoaDon(string MaHoaDon)
        {
            MaHD = MaHoaDon;
            InitializeComponent();
        }

        private void rptHoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataReport.tblHoaDon' table. You can move, or remove it, as needed.
            this.tblHoaDonTableAdapter.Fill(this.dataReport.tblHoaDon,MaHD);
            // TODO: This line of code loads data into the 'dataReport.tblThongTin' table. You can move, or remove it, as needed.
            this.tblThongTinTableAdapter.Fill(this.dataReport.tblThongTin);
            // TODO: This line of code loads data into the 'dataReport.tblChiTietHoaDon' table. You can move, or remove it, as needed.
            this.tblChiTietHoaDonTableAdapter.Fill(this.dataReport.tblChiTietHoaDon,MaHD);
            
            this.reportViewer1.RefreshReport();
        }
    }
}
