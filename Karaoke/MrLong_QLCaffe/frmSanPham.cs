using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using MrLong_QLCaffe.layerLogic;
using MrLong_QLCaffe.layerObject;

namespace MrLong_QLCaffe
{
    public partial class frmSanPham : DevComponents.DotNetBar.Office2007Form
    {
        private SanPhamLogic spLogic = new SanPhamLogic();
        private SanPhamObj LaySanPham()
        {
            SanPhamObj sp = new SanPhamObj();
            sp.MaSP = txtMaSP.Text;
            sp.DonGia = txtDonGia.Text;
            sp.DVT = txtDVT.Text;
            sp.MaLoai = cboLoaiSP.SelectedValue.ToString();
            sp.TenSP = txtTenSP.Text;
            return sp;
            
        }
       
        private AccessData.ConnectData conn = new MrLong_QLCaffe.AccessData.ConnectData();
        public frmSanPham()
        {
            InitializeComponent();
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            dataGridViewX1.ReadOnly = true;
            txtMaSP.Enabled = false;
            dataGridViewX1.DataSource = spLogic.LayDSSanPham();
            conn.LoadComBoBox(cboLoaiSP, "tblLoaiSP", "TenLoaiSP", "MaLoaiSP");
            HienThiNut(false);
            
        }
        private void ResetText()
        {
            txtTenSP.Text = "";
            txtDVT.Text = "";
            
            txtDonGia.Text = "";
        }

        private void HienThiNut(bool TF)
        {
            txtDonGia.Enabled = TF;
            txtDVT.Enabled = TF;
            txtTenSP.Enabled = TF;
            cboLoaiSP.Enabled = TF;
            dataGridViewX1.Enabled = !TF;
            butHuy.Enabled = TF;
            butLuu.Enabled = TF;
            butThem.Enabled = !TF;
            butSua.Enabled = !TF;
            butXoa.Enabled = !TF;
            txtTenSP.Focus();
        }

        private void butThem_Click(object sender, EventArgs e)
        {
          
            ResetText();
            HienThiNut(true);
            txtMaSP.Text = spLogic.SinhMa();
        }

        private void butHuy_Click(object sender, EventArgs e)
        {
            HienThiNut(false);
            ResetText();
            txtMaSP.Text = "";
        }

        private void butLuu_Click(object sender, EventArgs e)
        {
            if (conn.KiểmTraCóKhông("tblLoaiSP", "TenLoaiSP", cboLoaiSP.Text) == true)
            {
                if (spLogic.KiemTra(LaySanPham()) == true)
                {
                    if (conn.KiểmTraCóKhông("tblSanPham", "MaSanPham", txtMaSP.Text) == false)
                    {
                        if (conn.KiểmTraCóKhông("tblSanPham", "TenSanPham", txtTenSP.Text) == true)
                            MessageBox.Show("Tên này đã có.", "Thông báo");
                        else
                        {
                            spLogic.ThemSanPham(LaySanPham());
                            HienThiNut(false);
                            frmSanPham_Load(sender, e);
                            ResetText();
                        }
                    }
                    else
                    {
                        spLogic.SuaSanPham(LaySanPham());
                        HienThiNut(false);
                        frmSanPham_Load(sender, e);
                        ResetText();
                    }

                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng tên loại sản phẩm","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                cboLoaiSP.Focus();
            }
        }

        private void butSua_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text != "")
                HienThiNut(true);
            else
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa", "Thông báo");
        }

        private void dataGridViewX1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaSP.Text = dataGridViewX1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenSP.Text = dataGridViewX1.Rows[e.RowIndex].Cells[1].Value.ToString();
                cboLoaiSP.Text = dataGridViewX1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtDonGia.Text = dataGridViewX1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtDVT.Text = dataGridViewX1.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void butXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa sản phẩm: " + txtTenSP.Text + "", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                spLogic.Xoa(LaySanPham());
                frmSanPham_Load(sender, e);
                ResetText();
            }
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        } 

    }
}