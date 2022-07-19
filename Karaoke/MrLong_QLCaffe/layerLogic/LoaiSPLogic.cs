using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MrLong_QLCaffe.AccessData;
using MrLong_QLCaffe.layerObject;
using System.Windows.Forms;

namespace MrLong_QLCaffe.layerLogic
{
    class LoaiSPLogic
    {
        ConnectData Conn = new ConnectData();
        LoaiSPObj objLoai = new LoaiSPObj();
        public DataTable LayDanhSachLoai()
        {
            return Conn.LấyDữLiệu("Select *from tblLoaiSP");
        }
        public DataTable LayLoaiSP()
        {
            return Conn.LấyDữLiệu("SELECT TenLoaiSP FROM tblLoaiSP");
        }
        public void ThemLoai(LoaiSPObj objLoai )
        {
            string sql = "INSERT INTO tblLoaiSP values('"+objLoai.MaLoaiSP+"',N'"+objLoai.TenLoaiSP+"')";
            if (Conn.ThựcThi(sql))
                MessageBox.Show("Thêm loại thành công","Thông báo",MessageBoxButtons.OK);
        }
        //Sửa kv
        public bool SuaLoai(LoaiSPObj objLoai )
        {
            string sql = "UPDATE tblLoaiSP SET TenLoaiSP=N'"+objLoai.TenLoaiSP+"' where MaLoaiSP=N'"+objLoai.MaLoaiSP+"'";
            if (Conn.ThựcThi(sql))
            {
                MessageBox.Show("Đã sửa xong", "Thông báo", MessageBoxButtons.OK);
                return true;
            }
            else return false;
        }
        //Xóa khu vực
        public bool XoaLoai(LoaiSPObj objLoai)
        {
            string sql = "Delete from tblSanPham where MaLoaiSP=N'" + objLoai.MaLoaiSP + "' Delete from tblLoaiSP where MaLoaiSP=N'" + objLoai.MaLoaiSP + "'";
            if (Conn.ThựcThi(sql))
            {
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                return true;
            }
            else return false;
        }
        public string MaTiep()
        {
            return Conn.MãKếTiếp(Conn.LấyMãCuối("tblLoaiSP","MaLoaiSP"), "L");
        }
        public string LayMaLoai(string TenLoai)
        {
            return Conn.LayDuLieuDongDauTien("SELECT MaLoaiSP FROM tblLoaiSP WHERE TenLoaiSP=N'"+TenLoai+"'");
        }
        
    }
}
