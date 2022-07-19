using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using MrLong_QLCaffe.AccessData;
using MrLong_QLCaffe.layerLogic;
using MrLong_QLCaffe.layerObject;

namespace MrLong_QLCaffe
{
    public partial class frmHoaDon : DevComponents.DotNetBar.Office2007Form
    {
        HoaDonLogic logHoaDon = new HoaDonLogic();
        HoaDonObj objHoaDon = new HoaDonObj();
        BanLogic logBan = new BanLogic();
        NhanVienLogic logNhanVien = new NhanVienLogic();
        ConnectData conn = new ConnectData();
        private HoaDonObj LayHoaDon()
        {
            objHoaDon.MaHoaDon = txtMaHoaDon.Text;
            return objHoaDon;
        }
        public frmHoaDon()
        {
            InitializeComponent();
        }
        private void Readol()
        {
            
            txtMaHoaDon.ReadOnly = true;
            cboNhanVien.Enabled = false;
            cboTenBan.Enabled = false;
            dateTimeHD.Enabled = false;
        }


        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            Readol();
            conn.LoadComBoBox(cboTenBan, "tblBan", "TenBan", "MaBan");
            conn.LoadComBoBox(cboNhanVien, "tblNhanVien", "TenNhanVien", "MaNhanVien");
            colTenBan.DataSource = logBan.LayDanhSachBan();
            colTenBan.DisplayMember = "TenBan";
            colTenBan.ValueMember = "MaBan";
            colMaNhanVien.DataSource = logNhanVien.LayDSNhanVien();
            colMaNhanVien.DisplayMember = "TenNhanVien";
            colMaNhanVien.ValueMember = "MaNhanVien";

            gridHoaDon.DataSource = logHoaDon.LayDSHoaDon();
            
        }

        private void gridHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          if(e.RowIndex >0) 
          {
                txtMaHoaDon.Text = gridHoaDon.Rows[e.RowIndex].Cells[0].Value.ToString();
                cboTenBan.SelectedValue = gridHoaDon.Rows[e.RowIndex].Cells[1].Value.ToString();
                dateTimeHD.Text = gridHoaDon.Rows[e.RowIndex].Cells[2].Value.ToString();

                cboNhanVien.SelectedValue = gridHoaDon.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void butXoa_Click(object sender, EventArgs e)
        {
            logHoaDon.Xoa(LayHoaDon());
            frmHoaDon_Load(sender, e);
        }

        

      
    }
}