using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MrLong_QLCaffe.AccessData;
using MrLong_QLCaffe.layerObject;
using System.Windows.Forms;
namespace MrLong_QLCaffe.layerLogic
{
    class ChangePassLogic
    {
        ConnectData Conn = new ConnectData();
        //ChangePassObj obj = new ChangePassObj();
        public void ChangePass(ChangePassObj obj)
        {
            string Chang = "Update tblNhanVien set MatKhau = N'"+obj.Moi+"' where TenDangNhap = N'"+NguoiDung.user.TenDangNhap.ToString()+"'";
            Conn.ThựcThi(Chang);
            MessageBox.Show("Đã thay đổi", "Thông báo", MessageBoxButtons.OK);
        }
    }
}
