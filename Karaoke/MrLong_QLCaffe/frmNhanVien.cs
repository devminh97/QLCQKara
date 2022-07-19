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
    public partial class frmNhanVien : DevComponents.DotNetBar.Office2007Form
    {
        private NhanVienLogic logicNhanVien = new NhanVienLogic();
        private AccessData.ConnectData conn = new MrLong_QLCaffe.AccessData.ConnectData();
        NhanVienObj objNhanVien = new NhanVienObj();
        private NhanVienObj LayNhanVien()
        {
            objNhanVien.MaNhanVien = txtMaNV.Text;
            objNhanVien.TenNhanVien = txtHoTen.Text;
            objNhanVien.GioiTinh = cboGioiTinh.Text;
            objNhanVien.NgaySinh = datetimeNgaySinh.Value.ToString("MM/dd/yyyy");
            objNhanVien.SoDienThoai = txtSoDienThoai.Text;
            objNhanVien.TenDangNhap = txtTenDangNhap.Text;
            objNhanVien.DiaChi = txtDiaChi.Text;
            objNhanVien.QuyenHan = cboQuyenHan.Text;
            return objNhanVien;
        }
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            cboGioiTinh.SelectedItem = null;
            
            dataNhanVien.DataSource = logicNhanVien.LayDSNhanVien();
            txtMaNV.Enabled = false;
            HienThiControl(false);
        }

        private void dataNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaNV.Text = dataNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtHoTen.Text = dataNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDiaChi.Text = dataNhanVien.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtSoDienThoai.Text = dataNhanVien.Rows[e.RowIndex].Cells[3].Value.ToString();
                datetimeNgaySinh.Text = dataNhanVien.Rows[e.RowIndex].Cells[4].Value.ToString();
                cboGioiTinh.Text = dataNhanVien.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtTenDangNhap.Text = dataNhanVien.Rows[e.RowIndex].Cells[6].Value.ToString();
                cboQuyenHan.Text = dataNhanVien.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
        }
        private void HienThiControl(bool tf)
        {
            txtDiaChi.Enabled = tf;
            txtHoTen.Enabled = tf;
            txtSoDienThoai.Enabled = tf;
            txtTenDangNhap.Enabled = tf;
            cboGioiTinh.Enabled = tf;
            cboQuyenHan.Enabled = tf;
            datetimeNgaySinh.Enabled = tf;
            dataNhanVien.Enabled = !tf;
            butHuy.Enabled = tf;
            butLuuLai.Enabled = tf;
            butThem.Enabled = !tf;
            butSua.Enabled = !tf;
            butXoa.Enabled = !tf;
            txtHoTen.Focus();
        }
        private bool KiemTraTT()
        {
            if ((cboGioiTinh.Text != "Nam") && (cboGioiTinh.Text != "Nữ"))
            {
                MessageBox.Show("Giới tính không hợp lệ");
                return false;
            }
            else if ((cboQuyenHan.Text != "Admin") && (cboQuyenHan.Text != "Nhân viên"))
            {
                MessageBox.Show("Quyền hạn không hợp lệ.");
                return false;
            }
            else
                return true;
                    
        }
        private void XoaText()
        {
            txtMaNV.Clear();
            txtDiaChi.Clear();
            txtHoTen.Clear();
            txtSoDienThoai.Clear();
            txtTenDangNhap.Clear();
            datetimeNgaySinh.Text = DateTime.Now.ToString();
            cboGioiTinh.Text = "Nam";
            cboQuyenHan.Text = "Nhân viên";

        }
        private void butThem_Click(object sender, EventArgs e)
        {
           
            {
                HienThiControl(true);
                XoaText();
                txtMaNV.Text = logicNhanVien.SinhMa();
            }
        }

        private void butHuy_Click(object sender, EventArgs e)
        {
            HienThiControl(false);
            XoaText();
            txtDiaChi.Text = LayNhanVien().NgaySinh.ToString();
           
        }

        private void butXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "")
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Vui lòng chọn vào nhân viên muốn xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (DevComponents.DotNetBar.MessageBoxEx.Show("Bạn muốn xóa nhân viên: " + txtHoTen.Text + "", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    logicNhanVien.Xoa(LayNhanVien());
                    frmNhanVien_Load(sender, e);
                }
            }
        }

        private void butSua_Click(object sender, EventArgs e)
        {
           
            {
                if (txtMaNV.Text == "")
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Vui lòng chọn vào nhân viên muốn sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    HienThiControl(true);
                    txtTenDangNhap.Enabled = false;
                }
            }
        }

        private void butLuuLai_Click(object sender, EventArgs e)
        {
            if (KiemTraTT() == true)
            {
                if (logicNhanVien.KiemTra(LayNhanVien()) == true)
                {
                    if (conn.KiểmTraCóKhông("tblNhanVien", "MaNhanVien", txtMaNV.Text) == false)
                    {
                        if (conn.KiểmTraCóKhông("tblNhanVien", "TenDangNhap", txtTenDangNhap.Text) == false)
                        {
                            logicNhanVien.ThemNhanVien(LayNhanVien());
                            frmNhanVien_Load(sender, e);
                            HienThiControl(false);
                            XoaText();
                        }
                        else { DevComponents.DotNetBar.MessageBoxEx.Show("Tên đăng nhập này đã có.\n\tVui lòng chọn tên khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); txtTenDangNhap.Focus(); }
                    }
                    else
                    {
                        if (0 == 0) { }
                        logicNhanVien.SuaNhanVien(LayNhanVien());
                        frmNhanVien_Load(sender, e);
                        HienThiControl(false);
                        XoaText();
                    }
                }
            }
        }

        private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }

        }

        
    }
}