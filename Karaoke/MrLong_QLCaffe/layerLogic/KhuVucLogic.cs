using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MrLong_QLCaffe.AccessData;
using MrLong_QLCaffe.layerObject;
using System.Windows.Forms;

namespace MrLong_QLCaffe.layerLogic
{
    class KhuVucLogic
    {
        ConnectData Conn = new ConnectData();
        KhuVucObj kv = new KhuVucObj();
        public DataTable LayDanhSachKhuVuc()
        {
            return Conn.LấyDữLiệu("Select *from tblKhuVuc");
        }
        public void ThemKhuVuc(KhuVucObj kv)
        {
            string sql = "INSERT INTO tblKhuVuc values('"+kv.MaKhuVuc+"',N'"+kv.TenKhuVuc+"','"+kv.GiaPhong+"')";
            if (Conn.ThựcThi(sql))
                MessageBox.Show("Thêm khu vực thành công","Thông báo",MessageBoxButtons.OK);
        }
        //Sửa kv
        public bool SuaKhuVuc(KhuVucObj kv)
        {
            string sql = "UPDATE tblKhuVuc SET TenKhuVuc=N'" + kv.TenKhuVuc + "', GiaPhong='" + kv.GiaPhong + "' where MaKhuVuc=N'" + kv.MaKhuVuc + "'";
            if (Conn.ThựcThi(sql))
            {
                MessageBox.Show("Sửa khu vực thành công", "Thông báo", MessageBoxButtons.OK);
                return true;
            }
            else return false;
        }
        //Xóa khu vực
        public bool XoaKhuVuc(KhuVucObj khuvuc)
        {
            string sql = "Delete from tblKhuVuc where MaKhuVuc=N'" + khuvuc.MaKhuVuc + "' Delete from tblBan where MaKhuVuc=N'" + khuvuc.MaKhuVuc + "'";
            if (Conn.ThựcThi(sql))
            {
                MessageBox.Show("Xóa khu vực thành công", "Thông báo", MessageBoxButtons.OK);
                return true;
            }
            else return false;
        }
        public string MaTiep()
        {
            return Conn.MãKếTiếp(Conn.LấyMãCuối("tblKhuVuc","MaKhuVuc"), "KV");
        }
        
    }
}
