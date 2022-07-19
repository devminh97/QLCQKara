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
    class SanPhamLogic
    {
        AccessData.ConnectData conn = new AccessData.ConnectData();
        
        public DataTable LayDSSanPham()
        {
            return conn.LấyDữLiệu("Select MaSanPham,TenSanPham,TenLoaiSP,DonGia, DonViTinh from tblSanPham a, tblLoaiSP b where a.MaLoaiSP = b.MaLoaiSP");
        }
        public DataTable LayDS()
        {
            return conn.LấyDữLiệu("Select TenSanPham, DonGia from tblSanPham");
        }
        public void ThemSanPham(SanPhamObj objSP)
        {
            string str = string.Format("INSERT INTO tblSanPham values('{0}',N'{1}','{2}','{3}',N'{4}')", objSP.MaSP,
                objSP.TenSP, objSP.MaLoai, objSP.DonGia, objSP.DVT);
            if (conn.ThựcThi(str))
                MessageBox.Show("Thêm sản phẩm thành công.", "Thông báo");
        }
        public void SuaSanPham(SanPhamObj objSP)
        {
            string str = string.Format("UPDATE tblSanPham SET TenSanPham=N'"+objSP.TenSP+"',MaLoaiSP='"+objSP.MaLoai+"',DonGia='"+objSP.DonGia+"',DonViTinh=N'"+objSP.DVT+"' where MaSanPham='"+objSP.MaSP+"'",
                           objSP.TenSP, objSP.MaLoai, objSP.DonGia, objSP.DVT, objSP.MaSP);
            if (conn.ThựcThi(str))
                MessageBox.Show("Đã sửa xong.", "Thông báo");
        }
        public bool KiemTra(SanPhamObj objSanPham)
        {
            try
            {
                if (objSanPham.TenSP == "")
                { MessageBox.Show("Chưa nhập tên sản phẩm.", "Thông báo"); return false; }
                else if (objSanPham.DonGia == "")
                { MessageBox.Show("Chưa nhập đơn giá.", "Thông báo"); return false; }
                else if (Convert.ToInt32(objSanPham.DonGia) <= 0)
                {
                    MessageBox.Show("Giá phải lớn hơn 0.", "Thông báo");
                    return false;
                }

                else if (objSanPham.DVT == "")
                {
                    MessageBox.Show("Chưa nhập đơn vị tính.", "Thông báo");
                    return false;
                }
                else
                    return true;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: "+ex);
                return false;
            }
              
        }
        public string SinhMa()
        {
            return conn.MãKếTiếp(conn.LấyMãCuối("tblSanPham", "MaSanPham"), "SP");
        }
        public void Xoa(SanPhamObj obj)
        {
            string str = "Delete from tblChiTietHoaDon where MaSanPham='" + obj.MaSP + "' "
            +"Delete from tblSanPham where MaSanPham='" + obj.MaSP + "'";
            if (conn.ThựcThi(str))
                MessageBox.Show("Đã xóa xong", "Thông báo");
        }
        public DataTable LaySPHD()
        {
            return conn.LấyDữLiệu("SELECT TenSanPham, DonGia FROM tblSanPham");
        }
        public DataTable LaySPHDtheoLoai(string Loai)
        {
            return conn.LấyDữLiệu("SELECT TenSanPham, DonViTinh, DonGia FROM tblSanPham WHERE MaLoaiSP='"+Loai+"'");
        }
        public string LayMaSanPham(string Ten)
        {
            return conn.LayDuLieuDongDauTien("SELECT MaSanPham FROM tblSanPham WHERE TenSanPham=N'"+Ten+"'");
        }
        }
    }

