using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using MrLong_QLCaffe.report;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using MrLong_QLCaffe.AccessData;
using MrLong_QLCaffe.layerLogic;
using MrLong_QLCaffe.layerObject;


namespace MrLong_QLCaffe
{
    public partial class frmBanHang : DevComponents.DotNetBar.Office2007Form
    {
        TienTe logicTien = new TienTe();
        HoaDonLogic logicHoaDon = new HoaDonLogic();
        ChiTietHoaDonLogic logicCTHD = new ChiTietHoaDonLogic();
        BanLogic logicBan = new BanLogic();
        SanPhamLogic logicSanPham = new SanPhamLogic();
        LoaiSPLogic logicLoaiSP = new LoaiSPLogic();
        ConnectData conn = new ConnectData();
        CTHoaDonObj objCTHD = new CTHoaDonObj();
        
        string MaSP;
        int ThoiGian = 0;
        int TienNuoc = 0;
        int TienGio = 0;
        private HoaDonObj LayTTHoaDon()
        {
            HoaDonObj objHoaDon = new HoaDonObj();
            objHoaDon.MaHoaDon = txtMaHoaDon.Text;
            objHoaDon.TenBan = txtTenBan.Text;
            return objHoaDon;
            //objHoaDon.MaHoaDon =
        }
        
        private CTHoaDonObj LayCTHD()
        {
            objCTHD.MaHoaDon = txtMaHoaDon.Text;
            objCTHD.MaSanPham = MaSP;
            objCTHD.SoLuong = numSoLuong.Value.ToString();
            return objCTHD;
        }
       
        public frmBanHang()
        {

            InitializeComponent();
        }
        private void LoadListViewBan()
        {
            DataTable tbl = logicBan.LayDanhSachBan();
            DataTable tbl1 = logicHoaDon.LayDSHoaDon();
            foreach (DataRow drw in tbl.Rows)
            {
                ListViewItem lvwitem = new ListViewItem();
                ListViewItem lvwitem2 = new ListViewItem();
                lvwitem.Text = drw[1].ToString();
                lvwitem.Tag = drw[0].ToString();
                int hinh = 0;
                foreach (DataRow row in tbl1.Rows)
                {
                    if ((row["MaBan"].ToString() == lvwitem.Tag.ToString()) && (row["TinhTien"].ToString() == "Chưa tính"))
                    {
                        lvwitem.ImageIndex = 1;
                        hinh = 1;
                    }
                }
                if (hinh == 0)
                    lvwitem.ImageIndex = 0;
                
                listViewBan.Items.Add(lvwitem);
            }
        }
        private void frmBanHang_Load(object sender, EventArgs e)
        {
            txtMaHoaDon.ReadOnly = true;
            txtNhanVien.ReadOnly = true;
            txtTenBan.ReadOnly = true;
            txtThoiGian.ReadOnly = true;

            LoadListViewBan();
           gridSanPham.DataSource = logicSanPham.LaySPHD();
           gridLoaiSP.DataSource = logicLoaiSP.LayLoaiSP();
        }
        private void AnHienTT(bool tf)
        {
            butMoBan.Enabled = !tf;
            butTinhTien.Enabled = tf;
            menuStripMoBan.Enabled = !tf;
            menuStripTinhTien.Enabled = tf;
        }

        private void ClearText()
        {
            
            txtMaHoaDon.Clear();
            txtTenBan.Clear();
            txtThoiGian.Clear();
            lblTongTien.Text = "0";
            txtNhanVien.Clear();
            lblTinhTien.Text = "0";
            lblTongTien.Text = "0";
            lblThoiGianDaSD.Text = "0";
            txtTienGio.Text = "0";
           /*
            * dataGridThucDon.DataSource = conn.LấyDữLiệu("Select TenSanPham, SoLuong,DonGia from tblSanPham a, tblChiTietHoaDon b where a.MaSanPham = b.MaSanPham and MaHoaDon =N'0'");
            dataGridThucDon.Refresh();
            */
        }
        private string MaBan;
        private void listViewBan_Click(object sender, EventArgs e)
        {
                ClearText();
                string layMaHoaDon = "Select MaHoaDon, TenBan from tblHoaDon, tblBan where tblBan.MaBan = tblHoaDon.MaBan and TenBan = N'" + listViewBan.SelectedItems[0].Text.ToString() + "' and TinhTien like N'%Chưa%'";
                string MaHoaDon = "";

                //SqlCommand cmd = new SqlCommand(layMaHoaDon, conn.Conn);
                MaHoaDon = conn.LayDuLieuDongDauTien(layMaHoaDon);
               
                if (MaHoaDon != "")
                {
                    menuStripMoBan.Enabled = false;
                    menuStripTinhTien.Enabled = true;
                    string strHD = "Select MaHoaDon, TenBan, ThoiGian, TenNhanVien From tblHoaDon hd, tblNhanVien nv, tblBan b where hd.MaNhanVien = nv.MaNhanVien and hd.MaBan = b.MaBan and MaHoaDon=N'" + MaHoaDon + "'";
                    DataTable tableHoaDon = conn.LấyDữLiệu(strHD);

                    if (MaHoaDon != null)
                    {
                        DataTable thucDonCuaBan = conn.LấyDữLiệu("Select TenSanPham, SoLuong from tblSanPham a, tblChiTietHoaDon b where a.MaSanPham = b.MaSanPham and MaHoaDon =N'" + MaHoaDon + "'");
                        dataGridThucDon.DataSource = thucDonCuaBan;                                              
                        txtMaHoaDon.Text = MaHoaDon;
                        txtTenBan.Text = listViewBan.SelectedItems[0].Text.ToString();
                        foreach (DataRow daRow in tableHoaDon.Rows)
                        {
                            txtMaHoaDon.Text = daRow["MaHoaDon"].ToString();
                            txtTenBan.Text = daRow["TenBan"].ToString();
                            txtNhanVien.Text = daRow["TenNhanVien"].ToString();
                            
                            txtThoiGian.Text = daRow["ThoiGian"].ToString();
                        }

                        AnHienTT(true);
                    }
                    else
                    {
                       ClearText();
                       
                    }
                }
                else
                {
                    AnHienTT(false);
                    DataTable thucDonCuaBan = conn.LấyDữLiệu("Select TenSanPham, SoLuong,DonGia from tblSanPham a, tblChiTietHoaDon b where a.MaSanPham = b.MaSanPham and MaHoaDon ='Mr Log'");
                    dataGridThucDon.DataSource = thucDonCuaBan;
                }
        }

        

        private void menuStripMoBan_Click(object sender, EventArgs e)
        {
            if (listViewBan.SelectedItems.Count != 0)
            {
                MaBan = conn.LayDuLieuDongDauTien("select MaBan from tblBan where TenBan=N'" + listViewBan.SelectedItems[0].Text.ToString() + "'");
                string MaNV = conn.LayDuLieuDongDauTien("select MaNhanVien from tblNhanVien where TenDangNhap=N'" + NguoiDung.user.TenDangNhap + "'");
                string MaHDon = logicHoaDon.SinhMa();
                string sql = "INSERT INTO tblHoaDon(MaHoaDon,MaBan,ThoiGian,MaNhanVien,TinhTien) values('" + MaHDon + "','" + MaBan + "','" + DateTime.Now.ToString() + "','" + MaNV + "',N'Chưa tính')";
                conn.ThựcThi(sql);            
                listViewBan.Clear();
                frmBanHang_Load(sender, e);
            }
        }

        private void butTinhTien_Click(object sender, EventArgs e)
        {
            /*
             * 
            if (logicHoaDon.TinhTien(LayTTHoaDon()) == true)
            {
                if (MessageBox.Show("Đã tính tiền bàn: " + LayTTHoaDon().TenBan + ".\n\rBạn muốn in hóa đơn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    rptHoaDon frm = new rptHoaDon(LayTTHoaDon().MaHoaDon);
                    frm.ShowDialog();
                }
                listViewBan.Clear();
                frmBanHang_Load(sender, e);

                ClearText();

            }
             */
            if (txtMaHoaDon.Text != "")
            {
                frmThanhToan frm = new frmThanhToan(txtTenBan.Text,lblTinhTien.Text,txtTienGio.Text,txtMaHoaDon.Text);
                frm.ShowDialog();
                listViewBan.Clear();
                ClearText();
                frmBanHang_Load(sender, e);
            }

        }

        private void menuStripTinhTien_Click(object sender, EventArgs e)
        {
            butTinhTien.PerformClick();         

        }

        private void butMoBan_Click(object sender, EventArgs e)
        {
            menuStripMoBan.PerformClick();
        }

       
       

        private void gridLoaiSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                string TenLoai = gridLoaiSP.Rows[e.RowIndex].Cells[0].Value.ToString();
                string MaLoai = logicLoaiSP.LayMaLoai(TenLoai);
                gridSanPham.DataSource = logicSanPham.LaySPHDtheoLoai(MaLoai);
            }

        }

        private void gridSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>-1)
            {
                string TenSP = gridSanPham.Rows[e.RowIndex].Cells[0].Value.ToString();
                MaSP = logicSanPham.LayMaSanPham(TenSP);
            }
        }

        private void butThem_Click(object sender, EventArgs e)
        {
            if ((txtMaHoaDon.Text != "")&&(LayCTHD().MaSanPham!=""))
            {
                logicCTHD.ThemSanPham(LayCTHD());
            }
            dataGridThucDon.DataSource = logicCTHD.LayDSSanPhamDangGoi(LayCTHD());
            numSoLuong.Value = 1;
        }

        private void butGiam_Click(object sender, EventArgs e)
        {
            if ((txtMaHoaDon.Text != "") && (LayCTHD().MaSanPham != ""))
            {
                logicCTHD.GiamSanPham(LayCTHD());
            }
            dataGridThucDon.DataSource = logicCTHD.LayDSSanPhamDangGoi(LayCTHD());
            numSoLuong.Value = 1;
        }

        private void butXoa_Click(object sender, EventArgs e)
        {
            if (txtMaHoaDon.Text != "")
            {
                logicCTHD.Xoa(LayCTHD());
            }
            dataGridThucDon.DataSource = logicCTHD.LayDSSanPhamDangGoi(LayCTHD());
        }

        private void dataGridThucDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                string TenSP = dataGridThucDon.Rows[e.RowIndex].Cells[0].Value.ToString();
                MaSP = logicSanPham.LayMaSanPham(TenSP);
            }
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            txtTGHT.Text = DateTime.Now.ToString();
            if (txtMaHoaDon.Text != "")
            {
                TimeSpan diff = DateTime.Parse(txtTGHT.Text) - DateTime.Parse(txtThoiGian.Text); 
                ThoiGian = diff.Hours* 60 + diff.Minutes; 
                lblThoiGianDaSD.Text = ThoiGian.ToString() + " phút";
                TienGio = logicHoaDon.LayGiaPhong(txtTenBan.Text) / 60 * ThoiGian;
                TienGio = (int)logicTien.RutGonTien(TienGio);
                txtTienGio.Text = String.Format("{0:0,0}",TienGio);
                TienNuoc = logicCTHD.TinhTienNuoc(txtMaHoaDon.Text);
                lblTongTien.Text = String.Format("{0:0,0}", TienNuoc);
                lblTinhTien.Text = String.Format("{0:0,0}",(TienNuoc + TienGio));

            }
            else
            {
                ClearText();
            }
        }

        

        private void label2_Click(object sender, EventArgs e)
        {
            //txtTienGio.Text = logicHoaDon.LayGiaPhong(txtTenBan.Text).ToString();
        }

        

       
       

       

       

       
        


        
       

        

        

      

      
    }
}