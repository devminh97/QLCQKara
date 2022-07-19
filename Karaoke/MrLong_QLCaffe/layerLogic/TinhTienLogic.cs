using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using MrLong_QLCaffe.layerObject;
using MrLong_QLCaffe.AccessData;

namespace MrLong_QLCaffe.layerLogic
{
    class TinhTienLogic
    {
        TienTe Tien = new TienTe();
        ConnectData conn = new ConnectData();

        public bool ThanhToan(HoaDonObj obj)
        {
            string ThanhToan = "UPDATE tblHoaDon SET ThoiGianRa='" + DateTime.Now.ToString() + "', TinhTien='Đã tính',Karaoke='" + obj.TienGio + "', TongTien='" + obj.TongTien + "', BangChu=N'" + Tien.ChuyenDoi(obj.TongTien) + "' WHERE MaHoaDon='" + obj.MaHoaDon + "'";
            if (conn.ThựcThi(ThanhToan))
                return true;
            else
               return false;
        }
        public bool XemHD(HoaDonObj obj)
        {
            string ThanhToan = "UPDATE tblHoaDon SET ThoiGianRa='" + DateTime.Now.ToString() + "',Karaoke='" + obj.TienGio + "', TongTien='" + obj.TongTien + "', BangChu=N'" + Tien.ChuyenDoi(obj.TongTien) + "' WHERE MaHoaDon='" + obj.MaHoaDon + "'";
            if (conn.ThựcThi(ThanhToan))
                return true;
            else
                return false;
        }
    }
}
