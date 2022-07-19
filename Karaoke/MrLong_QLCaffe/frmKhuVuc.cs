using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using MrLong_QLCaffe.layerLogic;
using MrLong_QLCaffe.AccessData;
using MrLong_QLCaffe.layerObject;


namespace MrLong_QLCaffe
{
    public partial class frmKhuVuc : DevComponents.DotNetBar.Office2007Form
    {
        KhuVucLogic a = new KhuVucLogic();
        ConnectData conn = new ConnectData();
        public frmKhuVuc()
        {
            InitializeComponent();
        }
        

        
        private void frmKhuVuc_Load(object sender, EventArgs e)
        {
            dataGridKhuVuc.DataSource = a.LayDanhSachKhuVuc();
            HienThiNutLuu(false);
            txtMaKV.Enabled = false;
            dataGridKhuVuc.ReadOnly = true;
        }
        private void HienThiNutLuu(bool True_or_Fales)
        {
            butSua.Enabled = !True_or_Fales;
            butXoa.Enabled = !True_or_Fales;
            butLuu.Visible = True_or_Fales;
            butKhongLuu.Visible = True_or_Fales;
            dataGridKhuVuc.Enabled = !True_or_Fales;
            txtTenKV.Enabled = True_or_Fales;
            txtGiaPhong.Enabled = True_or_Fales;
        }

        private void butThem_Click(object sender, EventArgs e)
        {
            HienThiNutLuu(true);
            txtTenKV.Text = "";
            txtGiaPhong.Text = "";
            txtTenKV.Focus();  
            //Lấy mã Tiếp và đưa lên textbox
            txtMaKV.Text = a.MaTiep();
        }

        private void butLuu_Click(object sender, EventArgs e)
        {
            KhuVucObj kvobj = new KhuVucObj();
                    kvobj.MaKhuVuc = txtMaKV.Text;
                    kvobj.TenKhuVuc = txtTenKV.Text;
                    kvobj.GiaPhong = txtGiaPhong.Text;
            if (butThem.Enabled == true)
            {
                if (txtTenKV.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập tên khu vực.", "Thông báo", MessageBoxButtons.OK);
                    txtTenKV.Focus();
                }
                else
                    if (conn.KiểmTraCóKhông("tblKhuVuc", "TenKhuVuc", txtTenKV.Text) == true)
                    {
                        MessageBox.Show("Tên này đã có, vui lòng nhập tên khác","Thông báo");
                        txtTenKV.Clear();
                        txtTenKV.Focus();
                    }
                    else
                    {
                        a.ThemKhuVuc(kvobj);
                        frmKhuVuc_Load(sender, e);
                    }
            }
            else
            {
                a.SuaKhuVuc(kvobj);
                butThem.Enabled = true;
                frmKhuVuc_Load(sender, e);
            }

            
            
           
        }

        private void butSua_Click(object sender, EventArgs e)
        {
            HienThiNutLuu(true);
            butThem.Enabled = false;
            txtTenKV.Focus();
        }

        private void dataGridKhuVuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                txtMaKV.Text = dataGridKhuVuc.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenKV.Text = dataGridKhuVuc.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtGiaPhong.Text = dataGridKhuVuc.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void butXoa_Click(object sender, EventArgs e)
        {

            if ((MessageBox.Show("Bạn muốn xóa khu vực " + txtTenKV.Text.ToString()+"\n\tTất cả bàn thuộc khu vực sẽ bị xóa.","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
            {
                KhuVucObj kv = new KhuVucObj();
                kv.MaKhuVuc = txtMaKV.Text;
                a.XoaKhuVuc(kv);
                frmKhuVuc_Load(sender, e);
            }
        }

        private void butKhongLuu_Click(object sender, EventArgs e)
        {
            HienThiNutLuu(false);
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            ConnectData a = new ConnectData();
            if (a.KiểmTraCóKhông("tblKhuVuc","MaKhuVuc","KV03") == true)
            {
                MessageBox.Show("Có");
            }
        }

        private void txtTenKV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {

                KhuVucObj kvobj = new KhuVucObj();
                kvobj.MaKhuVuc = txtMaKV.Text;
                kvobj.TenKhuVuc = txtTenKV.Text;
                if (butThem.Enabled == true)
                {
                    if (txtTenKV.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập tên khu vực.", "Thông báo", MessageBoxButtons.OK);
                        txtTenKV.Focus();
                    }
                    else
                        if (conn.KiểmTraCóKhông("tblKhuVuc", "TenKhuVuc", txtTenKV.Text) == true)
                        {
                            MessageBox.Show("Tên này đã có, vui lòng nhập tên khác", "Thông báo");
                            txtTenKV.Clear();
                            txtTenKV.Focus();
                        }
                        else
                        {
                            a.ThemKhuVuc(kvobj);
                            frmKhuVuc_Load(sender, e);
                        }
                }
                else
                {
                    a.SuaKhuVuc(kvobj);
                    butThem.Enabled = true;
                    frmKhuVuc_Load(sender, e);
                }

            
            
           
            }
        }

        private void txtGiaPhong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        
        

        

       
      
    }
}