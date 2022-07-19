using System;
using System.Collections.Generic;
using System.Text;
using MrLong_QLCaffe.AccessData;
using MrLong_QLCaffe.layerObject;
using System.Data;

namespace MrLong_QLCaffe.layerLogic
{

    class reportHoaDonLogic
    {
        ConnectData conn = new ConnectData();
        public DataTable LayDSSP()
        {
            string str = "Select TenSanPham, SoLuong from tblHoaDon a, tblChiTietHoaDon b, tblSanPham p where b.MaSanPham = p.MaSanPham and a.MaHoaDon = b.MaHoaDon";
            return conn.LấyDữLiệu(str);

        }
        public DataTable LayHD()
        {
            string str = "Select * from tblHoaDon";
            return conn.LấyDữLiệu(str);
        }
    }
}
