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
    public partial class frmLoaiSP : DevComponents.DotNetBar.Office2007Form
    {
        private layerLogic.LoaiSPLogic logicLoai = new MrLong_QLCaffe.layerLogic.LoaiSPLogic();
        private layerObject.LoaiSPObj objLoai = new MrLong_QLCaffe.layerObject.LoaiSPObj();
        private AccessData.ConnectData conn = new MrLong_QLCaffe.AccessData.ConnectData();
        public frmLoaiSP()
        {
            InitializeComponent();
        }

        private void frmLoaiSP_Load(object sender, EventArgs e)
        {
            datagridLoai.DataSource = logicLoai.LayDanhSachLoai();
            txtMaLoai.Enabled = false;
            HienThiControl(false);
            datagridLoai.ReadOnly = true;

        }
        private void HienThiControl(bool qw)
        {

            butXoa.Enabled = !qw;
            butThem.Enabled = !qw;
            butSua.Enabled = !qw;
            datagridLoai.Enabled = !qw;
            butLuu.Enabled = qw;
            butHuy.Enabled = qw;
            txtTenLoai.Enabled = qw;
            txtTenLoai.Focus();
        }

        private void butThem_Click(object sender, EventArgs e)
        {
            HienThiControl(true);
            txtMaLoai.Text = logicLoai.MaTiep();
            txtTenLoai.Text = "";
        }

        private void butHuy_Click(object sender, EventArgs e)
        {
            HienThiControl(false);
            txtMaLoai.Text = "";
            txtTenLoai.Text = "";
        }

        private void datagridLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                txtMaLoai.Text = datagridLoai.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenLoai.Text = datagridLoai.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void butSua_Click(object sender, EventArgs e)
        {
            if (txtMaLoai.Text == "")
                MessageBox.Show("Vui lòng chọn vào loại cần sửa","Thông báo");
               else HienThiControl(true);
        }

        private void butXoa_Click(object sender, EventArgs e)
        {
            objLoai.MaLoaiSP = txtMaLoai.Text;
            if (MessageBox.Show("Bạn muốn xóa loại " + txtTenLoai.Text+".\n\tTất cả sản phẩm của loại sẽ bị xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                logicLoai.XoaLoai(objLoai);
                frmLoaiSP_Load(sender, e);
                txtMaLoai.Text = "";
                txtTenLoai.Text = "";
            }
        }

        private void butLuu_Click(object sender, EventArgs e)
        {
            objLoai.MaLoaiSP = txtMaLoai.Text;
            objLoai.TenLoaiSP = txtTenLoai.Text;
            if (txtTenLoai.Text == "")
            {
                MessageBox.Show("Tên loại không được để trống.\n\rVui lòng nhập lại.","Thông báo"); txtTenLoai.Focus();
            }
            else if (conn.KiểmTraCóKhông("tblLoaiSP", "TenLoaiSP", txtTenLoai.Text) == true)
            {
                MessageBox.Show("Tên loại đã có.\n\rVui lòng nhập lại","Thông báo"); txtTenLoai.Focus();
            }
            else
            if (conn.KiểmTraCóKhông("tblLoaiSP", "MaLoaiSP", txtMaLoai.Text) == false)
            {
                logicLoai.ThemLoai(objLoai);
                HienThiControl(false);
                frmLoaiSP_Load(sender, e);
            }
            else
            {
                logicLoai.SuaLoai(objLoai);
                HienThiControl(false);
                frmLoaiSP_Load(sender, e);
            }
        }   
    }
}