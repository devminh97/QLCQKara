using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MrLong_QLCaffe.AccessData;
using MrLong_QLCaffe.layerObject;
using System.Windows.Forms;

namespace MrLong_QLCaffe.layerLogic
{
    class BanLogic
    {
        ConnectData Conn = new ConnectData();
        BanObj ban = new BanObj();
        public DataTable LayDanhSachBan()
        {
            return Conn.LấyDữLiệu("Select MaBan, TenBan, TenKhuVuc from tblBan a, tblKhuVuc b where a.MaKhuVuc = b.MaKhuVuc");
        }
        public DataTable Layban()
        {
            return Conn.LấyDữLiệu("SELECT * FROM tblBan");
        }
        public void ThemBan(BanObj ban)
        {
            string sql = "INSERT INTO tblBan values('"+ban.MaBan+"',N'"+ban.TenBan+"','"+ban.MaKhuVuc+"')";
            if (Conn.ThựcThi(sql))
                MessageBox.Show("Thêm bàn thành công","Thông báo",MessageBoxButtons.OK);
        }
        //Sửa ban
        public bool SuaBan(BanObj ban)
        {
            string sql = "UPDATE tblBan SET TenBan=N'"+ban.TenBan+"', MaKhuVuc='"+ban.MaKhuVuc+"' where MaBan=N'"+ban.MaBan+"'";
            if (Conn.ThựcThi(sql))
            {
                MessageBox.Show("Sửa bàn thành công", "Thông báo", MessageBoxButtons.OK);
                return true;
            }
            else return false;
        }
      
        public bool XoaBan(BanObj Ban)
        {
            string sql = "Delete from tblHoaDon where MaBan=N'" + Ban.MaBan+ "' Delete from tblBan where MaBan=N'" + Ban.MaBan + "'";
            if (Conn.ThựcThi(sql))
            {
                MessageBox.Show("Xóa bàn thành công", "Thông báo", MessageBoxButtons.OK);
                return true;
            }
            else return false;
        }
        public string MaTiep()
        {
            return Conn.MãKếTiếp(Conn.LấyMãCuối("tblBan","MaBan"),"BAN");
        }
       
        
    }
}
