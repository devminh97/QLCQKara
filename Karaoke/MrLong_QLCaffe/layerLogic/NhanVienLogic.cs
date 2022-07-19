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
    class NhanVienLogic
    {
        ConnectData conn = new ConnectData();
     
        
        public DataTable LayDSNhanVien()
        {
            return conn.LấyDữLiệu("Select MaNhanVien,TenNhanVien,DiaChi,SoDienThoai,NgaySinh,GioiTinh,TenDangNhap,QuyenHan from tblNhanVien");
        }
        public void ThemNhanVien(NhanVienObj objNhanVien)
        {
           
           string tv = "insert into tblNhanVien values('"+objNhanVien.MaNhanVien+"',N'"+objNhanVien.TenNhanVien+"',N'"+objNhanVien.DiaChi+"','"+objNhanVien.SoDienThoai+"','"+objNhanVien.NgaySinh+"',N'"+objNhanVien.GioiTinh+"',N'"+objNhanVien.TenDangNhap+"','123456',N'"+objNhanVien.QuyenHan+"')";
            if (conn.ThựcThi(tv))
                MessageBox.Show("Thêm nhân viên thành công.", "Thông báo");
        }
        public void SuaNhanVien(NhanVienObj objNhanVien)
        {
            string str = "UPDATE tblNhanVien SET TenNhanVien=N'"+objNhanVien.TenNhanVien+"',DiaChi=N'"+objNhanVien.DiaChi+"',SoDienThoai='"+objNhanVien.SoDienThoai+"',NgaySinh='"+objNhanVien.NgaySinh+"',GioiTinh=N'"+objNhanVien.GioiTinh+"',TenDangNhap=N'"+objNhanVien.TenDangNhap+"' where MaNhanVien='"+objNhanVien.MaNhanVien+"'";
            if (conn.ThựcThi(str))
                MessageBox.Show("Đã sửa xong.", "Thông báo");
        }
        public bool KiemTra(NhanVienObj objNhanVien)
        {
            try
            {
                if (objNhanVien.TenNhanVien == "")
                {
                    MessageBox.Show("Chưa nhập tên nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (objNhanVien.DiaChi == "")
                { MessageBox.Show("Chưa nhập địa chỉ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }
                else if (objNhanVien.SoDienThoai == "")
                {
                    MessageBox.Show("Chưa nhập số điện thoại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                else if (objNhanVien.NgaySinh == "")
                {
                    MessageBox.Show("Chưa nhập ngày sinh.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (objNhanVien.GioiTinh == "")
                {
                    MessageBox.Show("Chưa nhập giới tính.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (objNhanVien.TenDangNhap == "")
                {
                    MessageBox.Show("Chưa nhập tên đăng nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            return conn.MãKếTiếp(conn.LấyMãCuối("tblNhanVien", "MaNhanVien"), "NV");
        }
        public void Xoa(NhanVienObj  objNhanVien)
        {
            //if (conn.LayDuLieuDongDauTien("Select MaHoaDon from tblHoaDon where MaNhanVien=N'" + objNhanVien.MaNhanVien + "'") == null)
            if (conn.LayDuLieuDongDauTien("Select MaHoaDon from tblHoaDon where MaNhanVien=N'"+objNhanVien.MaNhanVien+"'") == "")
            {
                string str = "Delete from tblNhanVien where MaNhanVien='" + objNhanVien.MaNhanVien + "'";
                if (conn.ThựcThi(str))
                    MessageBox.Show("Đã xóa xong", "Thông báo");
            }
            else
            {
                MessageBox.Show("Vui lòng xóa các hóa đơn của nhân viên này trước.","Thông báo");
            }
        }
            
        }
    }

