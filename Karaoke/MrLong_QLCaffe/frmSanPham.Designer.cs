namespace MrLong_QLCaffe
{
    partial class frmSanPham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSanPham));
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtMaSP = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTenSP = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cboLoaiSP = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtDonGia = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDVT = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.butLuu = new DevComponents.DotNetBar.ButtonX();
            this.butHuy = new DevComponents.DotNetBar.ButtonX();
            this.butThem = new DevComponents.DotNetBar.ButtonX();
            this.butSua = new DevComponents.DotNetBar.ButtonX();
            this.butXoa = new DevComponents.DotNetBar.ButtonX();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelX3
            // 
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(3, 55);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(98, 23);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "Loại sản phẩm:";
            // 
            // labelX2
            // 
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(3, 29);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(90, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Tên sản phẩm:";
            // 
            // labelX5
            // 
            this.labelX5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.Location = new System.Drawing.Point(3, 107);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(90, 23);
            this.labelX5.TabIndex = 4;
            this.labelX5.Text = "Đơn vị tính:";
            // 
            // labelX4
            // 
            this.labelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.Location = new System.Drawing.Point(3, 81);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(90, 23);
            this.labelX4.TabIndex = 3;
            this.labelX4.Text = "Đơn giá:";
            // 
            // labelX1
            // 
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(3, 3);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(98, 23);
            this.labelX1.TabIndex = 5;
            this.labelX1.Text = "Mã sản phẩm:";
            // 
            // txtMaSP
            // 
            // 
            // 
            // 
            this.txtMaSP.Border.Class = "TextBoxBorder";
            this.txtMaSP.Location = new System.Drawing.Point(107, 3);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(205, 20);
            this.txtMaSP.TabIndex = 6;
            // 
            // txtTenSP
            // 
            // 
            // 
            // 
            this.txtTenSP.Border.Class = "TextBoxBorder";
            this.txtTenSP.Location = new System.Drawing.Point(107, 29);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(205, 20);
            this.txtTenSP.TabIndex = 7;
            // 
            // cboLoaiSP
            // 
            this.cboLoaiSP.DisplayMember = "Text";
            this.cboLoaiSP.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLoaiSP.FormattingEnabled = true;
            this.cboLoaiSP.ItemHeight = 14;
            this.cboLoaiSP.Location = new System.Drawing.Point(107, 58);
            this.cboLoaiSP.Name = "cboLoaiSP";
            this.cboLoaiSP.Size = new System.Drawing.Size(205, 20);
            this.cboLoaiSP.TabIndex = 8;
            // 
            // txtDonGia
            // 
            // 
            // 
            // 
            this.txtDonGia.Border.Class = "TextBoxBorder";
            this.txtDonGia.Location = new System.Drawing.Point(107, 84);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(205, 20);
            this.txtDonGia.TabIndex = 9;
            this.txtDonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGia_KeyPress);
            // 
            // txtDVT
            // 
            // 
            // 
            // 
            this.txtDVT.Border.Class = "TextBoxBorder";
            this.txtDVT.Location = new System.Drawing.Point(107, 110);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Size = new System.Drawing.Size(205, 20);
            this.txtDVT.TabIndex = 10;
            // 
            // butLuu
            // 
            this.butLuu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.butLuu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.butLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLuu.Location = new System.Drawing.Point(114, 165);
            this.butLuu.Name = "butLuu";
            this.butLuu.Size = new System.Drawing.Size(75, 23);
            this.butLuu.TabIndex = 11;
            this.butLuu.Text = "Lưu lại";
            this.butLuu.Click += new System.EventHandler(this.butLuu_Click);
            // 
            // butHuy
            // 
            this.butHuy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.butHuy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.butHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butHuy.Location = new System.Drawing.Point(206, 165);
            this.butHuy.Name = "butHuy";
            this.butHuy.Size = new System.Drawing.Size(75, 23);
            this.butHuy.TabIndex = 12;
            this.butHuy.Text = "Hủy";
            this.butHuy.Click += new System.EventHandler(this.butHuy_Click);
            // 
            // butThem
            // 
            this.butThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.butThem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.butThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butThem.Location = new System.Drawing.Point(75, 136);
            this.butThem.Name = "butThem";
            this.butThem.Size = new System.Drawing.Size(75, 23);
            this.butThem.TabIndex = 13;
            this.butThem.Text = "Thêm";
            this.butThem.Click += new System.EventHandler(this.butThem_Click);
            // 
            // butSua
            // 
            this.butSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.butSua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.butSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSua.Location = new System.Drawing.Point(156, 136);
            this.butSua.Name = "butSua";
            this.butSua.Size = new System.Drawing.Size(75, 23);
            this.butSua.TabIndex = 14;
            this.butSua.Text = "Sửa";
            this.butSua.Click += new System.EventHandler(this.butSua_Click);
            // 
            // butXoa
            // 
            this.butXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.butXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.butXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butXoa.Location = new System.Drawing.Point(237, 136);
            this.butXoa.Name = "butXoa";
            this.butXoa.Size = new System.Drawing.Size(75, 23);
            this.butXoa.TabIndex = 15;
            this.butXoa.Text = "Xóa";
            this.butXoa.Click += new System.EventHandler(this.butXoa_Click);
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewX1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(4, 231);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.Size = new System.Drawing.Size(544, 245);
            this.dataGridViewX1.TabIndex = 16;
            this.dataGridViewX1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewX1_CellClick);
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.txtDonGia);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.butXoa);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.butSua);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.butThem);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.butHuy);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.butLuu);
            this.groupPanel1.Controls.Add(this.txtMaSP);
            this.groupPanel1.Controls.Add(this.txtDVT);
            this.groupPanel1.Controls.Add(this.txtTenSP);
            this.groupPanel1.Controls.Add(this.cboLoaiSP);
            this.groupPanel1.Location = new System.Drawing.Point(75, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(390, 225);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel1.TabIndex = 17;
            this.groupPanel1.Text = "Quản lý sản phẩm";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaSanPham";
            this.Column1.HeaderText = "Mã SP";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenSanPham";
            this.Column2.HeaderText = "Tên sản phẩm";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TenLoaiSP";
            this.Column3.HeaderText = "Loại sản phẩm";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DonGia";
            this.Column4.HeaderText = "Đơn giá";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "DonViTinh";
            this.Column5.HeaderText = "Đơn vị tính";
            this.Column5.Name = "Column5";
            // 
            // frmSanPham
            // 
            this.ClientSize = new System.Drawing.Size(549, 477);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.dataGridViewX1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý sản phẩm";
            this.Load += new System.EventHandler(this.frmSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaSP;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenSP;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboLoaiSP;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDonGia;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDVT;
        private DevComponents.DotNetBar.ButtonX butLuu;
        private DevComponents.DotNetBar.ButtonX butHuy;
        private DevComponents.DotNetBar.ButtonX butThem;
        private DevComponents.DotNetBar.ButtonX butSua;
        private DevComponents.DotNetBar.ButtonX butXoa;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;

    }
}