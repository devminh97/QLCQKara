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
    class HoaDonLogic
    {
        ConnectData conn = new ConnectData();
     
        
        public DataTable LayDSPhieuChuaTinh()
        {
            return conn.LấyDữLiệu("Select * from tblHoaDon where TinhTien =N'Chưa tính'");
        }
        public DataTable LayDSHoaDon()
        {
            return conn.LấyDữLiệu("Select MaHoaDon,MaBan, ThoiGian,MaNhanVien,TinhTien, Karaoke, TongTien from tblHoaDon");
        }
        public void ThemHoaDon(HoaDonObj objHoaDon)
        {

            string tv = "insert into tblHoaDon values('" + SinhMa() + "',)";
            if (conn.ThựcThi(tv))
                MessageBox.Show("Thêm nhân viên thành công.", "Thông báo");
        }
        
        public DataTable SanPhamCuaPhieu()
        {
            string str = "Select TenSanPham, SoLuong from tblHoaDon a, tblChiTietHoaDon b, tblSanPham p where b.MaSanPham = p.MaSanPham and a.MaHoaDon = b.MaHoaDon and a.MaHoaDon='HD000002'";
            return conn.LấyDữLiệu(str);
        }
       
        public string SinhMa()
        {
            return conn.MãKếTiếp(conn.LấyMãCuối("tblHoaDon", "MaHoaDon"), "HD");
        }
        public void Xoa(HoaDonObj  objHD)
        {
            string str = "Delete from tblChiTietHoaDon where MaHoaDon='" +objHD.MaHoaDon+ "' "
            +"Delete from tblHoaDon where MaHoaDon='" + objHD.MaHoaDon + "'";
            if (conn.ThựcThi(str))
                MessageBox.Show("Đã xóa xong", "Thông báo");
        }
        public bool TinhTien(HoaDonObj obj)
        {
            string tt = "Update tblHoaDon Set TinhTien=N'Đã tính', ThoiGianRa='"+DateTime.Now.ToString()+"' where MaHoaDon=N'"+obj.MaHoaDon+"'";
            
            if (conn.ThựcThi(tt))
            {
                return true;
            }
            else
            { return false; }
        }

        public int LayGiaPhong(string TênBàn)
        {
            string LayGiaPhong = "SELECT GiaPhong FROM tblKhuVuc a, tblBan b WHERE a.MaKhuVuc = b.MaKhuVuc and TenBan =N'"+TênBàn+"' ";
            return conn.LayTongTien(LayGiaPhong);
                
        }
       
        }
    }

