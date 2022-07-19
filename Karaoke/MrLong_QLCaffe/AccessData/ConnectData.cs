using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Windows.Forms;
using MrLong_QLCaffe.layerObject;
namespace MrLong_QLCaffe.AccessData
{
    class NguoiDung
    {
        public static LoginObj user = new LoginObj();
    }
    class ConnectData
    {
        
        
        public SqlConnection Conn;
        private SqlDataAdapter aDapter;
        private DataTable dataTable;
        //Tạo kết nối
        public ConnectData()
        {
            Connect();
        }
        public void Connect()
        {
          //  string strConn = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\NDL_Data\MrLong_QLCaffe.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            string strConn =Properties.Settings.Default.MrLong_QLCaffeConnectionString.ToString();
            try
            {
                Conn = new SqlConnection(strConn);
                Conn.Open();
                Conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        public DataTable LấyDữLiệu(string CâuTruyVấn)
        {
            aDapter = new SqlDataAdapter(CâuTruyVấn, Conn);
            dataTable = new DataTable();
            aDapter.Fill(dataTable);
            return dataTable;            
        }
        public bool ThựcThi(string truyVấn)
        {
            if (DòngThựcThi(truyVấn) > 0)
                return true;
            return false;
        }
        public int DòngThựcThi(string TruyVấn)
        {
            int dongThucThi = 0;
            try
            {
                if (Conn.State == ConnectionState.Closed)
                    Conn.Open();
                SqlCommand cmd = new SqlCommand(TruyVấn, Conn);
                dongThucThi = (int)cmd.ExecuteNonQuery();
                Conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: "+ex.Message);
            }
            return dongThucThi;
        }
        //Lấy mã cuối cùng và sinh mã kế tiếp.
        public string LấyMãCuối(string Bảng, string Cột)
        {
            try
            {
                string sql = "Select Top 1 " + Cột + " from " + Bảng + " Order By " + Cột + " DESC";
                LấyDữLiệu(sql);
                return dataTable.Rows[0][Cột].ToString();
            }
            catch (Exception ex)
            {
                return "000000";
            }

        }
            
        public string MãKếTiếp(string MãCuối, string TiềnTố)
        {
            int MãKếTiếp = int.Parse(MãCuối.Remove(0, TiềnTố.Length)) + 1;
            int lengthNumerID = MãCuối.Length - TiềnTố.Length;
            string zeroNumber = "";
            for (int i = 1; i <= lengthNumerID; i++)
            {
                if (MãKếTiếp < Math.Pow(10, i))
                {
                    for (int j = 1; j <= lengthNumerID - i; i++)
                    {
                        zeroNumber += "0";
                    }
                    return TiềnTố + zeroNumber + MãKếTiếp.ToString();
                }
            }
            return TiềnTố + MãKếTiếp;

        }
        public bool KiểmTraCombo(ComboBox TênCombo, string cộtGiáTrị, string GiáTrị)
        {
            Conn.Close();
            Conn.Open();
            string tv = "Select * from " + TênCombo + " where " + cộtGiáTrị + "=N'" + GiáTrị + "'";
            SqlCommand cmd = new SqlCommand(tv, Conn);
            if (cmd.ExecuteScalar() == null)
            {
                return false;
            }
            else { return true; }
        }
        public bool KiểmTraCóKhông(string Bảng, string Cột, string GiáTrị)
        {
            if(Conn.State == ConnectionState.Closed)
            Conn.Open();
            string strTV="Select "+Cột+" from "+Bảng+" where "+Cột+"=N'"+GiáTrị+"'";
            SqlCommand cmd = new SqlCommand(strTV,Conn);
            if(cmd.ExecuteScalar() != null)
            return true;
            return false;
        }
        public void LoadComBoBox(ComboBox TênComBo, string Bảng, string CộtHiểnThị, string CộtGiáTrị)
        {
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();
            TênComBo.DataSource = LấyDữLiệu("Select * from " + Bảng + "");
            TênComBo.DisplayMember = CộtHiểnThị;
            TênComBo.ValueMember = CộtGiáTrị;
            TênComBo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            TênComBo.AutoCompleteSource = AutoCompleteSource.ListItems;
            Conn.Close();
        }
        public int DemSoDong(string truyvan)
        {

            DataTable table = LấyDữLiệu(truyvan);
            return table.Rows.Count;
        }
        public int LaySoLuong(string TruyVan)
        {
            Conn.Close();
            Conn.Open();
            SqlCommand cmd = new SqlCommand(TruyVan, Conn);
            if (cmd.ExecuteScalar() != null)
                return (int)cmd.ExecuteScalar();
            else
                return 0;
        }

        public string LayDuLieuDongDauTien(string truyvan)
        {
            Conn.Close();
            Conn.Open();
            SqlCommand com = new SqlCommand(truyvan, Conn);
            if (com.ExecuteScalar() != null)
            {
                return (string)com.ExecuteScalar();
            }
            else
                return "";
               
            
        }
        public int LayTongTien(string truyvan)
        {
            try
            {
                Conn.Close();
                Conn.Open();
                SqlCommand com = new SqlCommand(truyvan, Conn);
                return (int)com.ExecuteScalar();
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}
