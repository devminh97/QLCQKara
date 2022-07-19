using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace MrLong_QLCaffe
{
    public partial class frmBan : DevComponents.DotNetBar.Office2007Form
    {
        public frmBan()
        {
            InitializeComponent();
        }
        layerObject.BanObj objBan = new MrLong_QLCaffe.layerObject.BanObj();
        layerLogic.BanLogic logicBan = new MrLong_QLCaffe.layerLogic.BanLogic();
        layerLogic.KhuVucLogic logicKV = new MrLong_QLCaffe.layerLogic.KhuVucLogic();
        AccessData.ConnectData conn = new MrLong_QLCaffe.AccessData.ConnectData();
        private void frmBan_Load(object sender, EventArgs e)
        {
            dataBan.DataSource = logicBan.LayDanhSachBan();
            comboBox1.DataSource = logicKV.LayDanhSachKhuVuc();
            conn.LoadComBoBox(comboBox1, "tblKhuVuc", "TenKhuVuc", "MaKhuVuc");
            
            
            txtMaBan.Enabled = false;
            HienThiNutLuu(false);
        }
        private void HienThiNutLuu(bool True_or_Fales)
        {
            butThem.Enabled = !True_or_Fales;
            butSua.Enabled = !True_or_Fales;
            butXoa.Enabled = !True_or_Fales;
            butLuu.Visible = True_or_Fales;
            butKhongLuu.Visible = True_or_Fales;
            dataBan.Enabled = !True_or_Fales;
            txtTenBan.Enabled = True_or_Fales;
            comboBox1.Enabled = True_or_Fales;


        }

       
        private void dataBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaBan.Text = dataBan.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenBan.Text = dataBan.Rows[e.RowIndex].Cells[1].Value.ToString();
                comboBox1.Text = dataBan.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void butThem_Click(object sender, EventArgs e)
        {
            HienThiNutLuu(true);
            txtTenBan.Text = "";
            txtTenBan.Focus();

            //Lấy mã Tiếp và đưa lên textbox
            txtMaBan.Text = logicBan.MaTiep();

        }

        private void butLuu_Click(object sender, EventArgs e)
        {
            objBan.MaBan = txtMaBan.Text;
            objBan.TenBan = txtTenBan.Text;
            objBan.MaKhuVuc = comboBox1.SelectedValue.ToString();

            if (conn.KiểmTraCóKhông("tblBan","MaBan",txtMaBan.Text)== false)
            {
                if (txtTenBan.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập tên bàn.", "Thông báo", MessageBoxButtons.OK);
                    txtTenBan.Focus();
                }
                else
                    if (conn.KiểmTraCóKhông("tblBan", "TenBan", txtTenBan.Text) == true)
                    {
                        MessageBox.Show("Tên này đã có, vui lòng nhập tên khác", "Thông báo");
                        txtTenBan.Clear();
                        txtTenBan.Focus();
                    }
                    else
                    {
                        logicBan.ThemBan(objBan);
                        frmBan_Load(sender, e);
                    }
            }
            else
            {
                logicBan.SuaBan(objBan);
                butThem.Enabled = true;
                frmBan_Load(sender, e);
            }

        }

        private void butKhongLuu_Click(object sender, EventArgs e)
        {
            HienThiNutLuu(false);
            butThem.Enabled = true;
        }

        private void butSua_Click(object sender, EventArgs e)
        {
            HienThiNutLuu(true);
            butThem.Enabled = false;
            txtTenBan.Focus();

        }

        private void butXoa_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Bạn muốn xóa bàn " + txtTenBan.Text.ToString(), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
            {
                objBan.MaBan = txtMaBan.Text;
                logicBan.XoaBan(objBan);
                frmBan_Load(sender, e);
            }

        }

        
        }
    }
