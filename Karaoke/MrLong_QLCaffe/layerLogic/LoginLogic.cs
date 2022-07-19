using System;
using System.Collections.Generic;
using System.Text;
using MrLong_QLCaffe.AccessData;
using MrLong_QLCaffe.layerObject;
using System.Data;

namespace MrLong_QLCaffe.layerLogic
{
    class LoginLogic
    {
       
        private ConnectData conn = new ConnectData();
        private LoginObj objLogin = new LoginObj();
        public LoginObj LayTTNguoiDung(string TenDangNhap)
        {
            string tv = "Select * from tblNhanVien where TenDangNhap=N'"+TenDangNhap+"'";
            DataRow rowNguoiDung = conn.LấyDữLiệu(tv).Rows[0];
           
            objLogin.DiaChi = rowNguoiDung["DiaChi"].ToString();
            objLogin.GioiTinh = rowNguoiDung["GioiTinh"].ToString();
            objLogin.MatKhau = rowNguoiDung["MatKhau"].ToString();
            objLogin.NgaySinh = rowNguoiDung["NgaySinh"].ToString();          
            objLogin.SoDienThoai = rowNguoiDung["SoDienThoai"].ToString();
            objLogin.TenNhanVien = rowNguoiDung["TenNhanVien"].ToString();
            objLogin.TenDangNhap = rowNguoiDung["TenDangNhap"].ToString();
           
            objLogin.QuyenHan = rowNguoiDung["QuyenHan"].ToString();
            return objLogin;
        }
    }
}
