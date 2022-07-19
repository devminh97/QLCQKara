using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MrLong_QLCaffe.AccessData;
using MrLong_QLCaffe.layerObject;


namespace MrLong_QLCaffe.layerLogic
{
    class ChiTietHoaDonLogic
    {
        ConnectData conn = new ConnectData();
        HoaDonObj objHoaDon = new HoaDonObj();
        CTHoaDonObj objCTHoaDon = new CTHoaDonObj();
        
        public DataTable LayDSSanPhamDangGoi(CTHoaDonObj a)
        {
           return conn.LấyDữLiệu("Select TenSanPham,SoLuong from tblSanPham a, tblChiTietHoaDon b where a.MaSanPham = b.MaSanPham and MaHoaDon = N'"+a.MaHoaDon.ToString()+"'");
        }
        
        public void ThemSanPham(CTHoaDonObj obj)
        {
            int SoLuong = conn.LaySoLuong("SELECT SoLuong FROM tblChiTietHoaDon WHERE MaHoaDon='" + obj.MaHoaDon + "' and MaSanPham='" + obj.MaSanPham + "'");
            if (SoLuong > 0)
            {
                int TongSL = int.Parse(obj.SoLuong) + SoLuong;
                string up = "UPDATE tblChiTietHoaDon SET SoLuong='"+TongSL+"' WHERE MaHoaDon ='"+obj.MaHoaDon+"' and MaSanPham='"+obj.MaSanPham+"'";
                conn.ThựcThi(up);
            }
            else
            {
           string tv = "insert into tblChiTietHoaDon values('"+obj.MaHoaDon+"',N'"+obj.MaSanPham+"','"+obj.SoLuong+"')";
           conn.ThựcThi(tv);
           }
        }
        public void GiamSanPham(CTHoaDonObj obj)
        {

            int SoLuong = conn.LaySoLuong("SELECT SoLuong FROM tblChiTietHoaDon WHERE MaHoaDon='" + obj.MaHoaDon + "' and MaSanPham='" + obj.MaSanPham + "'");
            if (SoLuong <= int.Parse(obj.SoLuong))
            {
                MessageBox.Show("Số lượng giảm quá lớn","Thông báo");
            }
            else
            if (SoLuong > 0)
            {
                int TongSL = SoLuong - int.Parse(obj.SoLuong);
                string up = "UPDATE tblChiTietHoaDon SET SoLuong='" + TongSL + "' WHERE MaHoaDon ='" + obj.MaHoaDon + "' and MaSanPham='" + obj.MaSanPham + "'";
                conn.ThựcThi(up);
            }
 
        }
        
       
        public void Xoa(CTHoaDonObj objCTHD)
        {
            string str = "Delete from tblChiTietHoaDon where MaSanPham='" + objCTHD.MaSanPham + "' and SoLuong ='"+objCTHD.SoLuong+"' ";
            conn.ThựcThi(str);           
        }
        public int TinhTienNuoc(string MaHD)
        {
            string tinhTien = "Select SUM(SoLuong*DonGia) as TongTien from tblChiTietHoaDon a, tblSanPham b where a.MaSanPham = b.MaSanPham and MaHoaDon = '" + MaHD + "'";
            return conn.LayTongTien(tinhTien);
        }
            
        }
    }

