using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MrLong_QLCaffe.AccessData;
using MrLong_QLCaffe.layerObject;

namespace MrLong_QLCaffe.layerLogic
{
    
    class ThongTinLogic
    {
        ConnectData conn = new ConnectData();
        public bool Luu(ThongTinObj objTT)
        {
            string sql = "UPDATE tblThongTin SET TenQuan=N'"+objTT.TenQuan+"', SoDienThoai='"+objTT.SDT+"', DiaChi=N'"+objTT.DC+"', LoiChuc=N'"+objTT.LoiChuc+"' WHERE ID='1'";
            if (conn.ThựcThi(sql))
                return true;
            else
                return false;
        }
    }
}
