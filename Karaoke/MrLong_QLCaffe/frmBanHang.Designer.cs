namespace MrLong_QLCaffe
{
    partial class frmBanHang
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBanHang));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.listViewBan = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStripMoBan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripTinhTien = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupPanel3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.groupPanel4 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.gridLoaiSP = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.TenLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanel5 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.gridSanPham = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dataGridThucDon = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.butMoBan = new DevComponents.DotNetBar.ButtonX();
            this.lblThoiGianDaSD = new System.Windows.Forms.Label();
            this.txtTienGio = new System.Windows.Forms.Label();
            this.lblTinhTien = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNhanVien = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.butTinhTien = new DevComponents.DotNetBar.ButtonX();
            this.txtTGHT = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtThoiGian = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTenBan = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txtMaHoaDon = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.butXoa = new DevComponents.DotNetBar.ButtonX();
            this.butGiam = new DevComponents.DotNetBar.ButtonX();
            this.butThem = new DevComponents.DotNetBar.ButtonX();
            this.contextMenuStrip1.SuspendLayout();
            this.groupPanel3.SuspendLayout();
            this.groupPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLoaiSP)).BeginInit();
            this.groupPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridThucDon)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewBan
            // 
            // 
            // 
            // 
            this.listViewBan.Border.Class = "ListViewBorder";
            this.listViewBan.ContextMenuStrip = this.contextMenuStrip1;
            this.listViewBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewBan.LargeImageList = this.imageList1;
            this.listViewBan.Location = new System.Drawing.Point(0, 0);
            this.listViewBan.Name = "listViewBan";
            this.listViewBan.Size = new System.Drawing.Size(294, 544);
            this.listViewBan.TabIndex = 0;
            this.listViewBan.UseCompatibleStateImageBehavior = false;
            this.listViewBan.Click += new System.EventHandler(this.listViewBan_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripMoBan,
            this.menuStripTinhTien});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(131, 48);
            // 
            // menuStripMoBan
            // 
            this.menuStripMoBan.Name = "menuStripMoBan";
            this.menuStripMoBan.Size = new System.Drawing.Size(130, 22);
            this.menuStripMoBan.Text = "Mở phòng";
            this.menuStripMoBan.Click += new System.EventHandler(this.menuStripMoBan_Click);
            // 
            // menuStripTinhTien
            // 
            this.menuStripTinhTien.Name = "menuStripTinhTien";
            this.menuStripTinhTien.Size = new System.Drawing.Size(130, 22);
            this.menuStripTinhTien.Text = "Tính tiền";
            this.menuStripTinhTien.Click += new System.EventHandler(this.menuStripTinhTien_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Hinh2.png");
            this.imageList1.Images.SetKeyName(1, "Hinh1.png");
            // 
            // groupPanel3
            // 
            this.groupPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel3.Controls.Add(this.listViewBan);
            this.groupPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupPanel3.Location = new System.Drawing.Point(0, 0);
            this.groupPanel3.Name = "groupPanel3";
            this.groupPanel3.Size = new System.Drawing.Size(300, 565);
            // 
            // 
            // 
            this.groupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel3.Style.BackColorGradientAngle = 90;
            this.groupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderBottomWidth = 1;
            this.groupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderLeftWidth = 1;
            this.groupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderRightWidth = 1;
            this.groupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderTopWidth = 1;
            this.groupPanel3.Style.CornerDiameter = 4;
            this.groupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel3.TabIndex = 6;
            this.groupPanel3.Text = "Danh sách phòng";
            // 
            // groupPanel4
            // 
            this.groupPanel4.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel4.Controls.Add(this.gridLoaiSP);
            this.groupPanel4.Location = new System.Drawing.Point(482, 7);
            this.groupPanel4.Name = "groupPanel4";
            this.groupPanel4.Size = new System.Drawing.Size(247, 223);
            // 
            // 
            // 
            this.groupPanel4.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel4.Style.BackColorGradientAngle = 90;
            this.groupPanel4.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel4.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderBottomWidth = 1;
            this.groupPanel4.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel4.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderLeftWidth = 1;
            this.groupPanel4.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderRightWidth = 1;
            this.groupPanel4.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderTopWidth = 1;
            this.groupPanel4.Style.CornerDiameter = 4;
            this.groupPanel4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel4.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel4.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel4.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel4.TabIndex = 15;
            this.groupPanel4.Text = "Loại sản phẩm";
            // 
            // gridLoaiSP
            // 
            this.gridLoaiSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridLoaiSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLoaiSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenLoai});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridLoaiSP.DefaultCellStyle = dataGridViewCellStyle1;
            this.gridLoaiSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridLoaiSP.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridLoaiSP.Location = new System.Drawing.Point(0, 0);
            this.gridLoaiSP.Name = "gridLoaiSP";
            this.gridLoaiSP.ReadOnly = true;
            this.gridLoaiSP.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridLoaiSP.Size = new System.Drawing.Size(241, 202);
            this.gridLoaiSP.TabIndex = 4;
            this.gridLoaiSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridLoaiSP_CellClick);
            // 
            // TenLoai
            // 
            this.TenLoai.DataPropertyName = "TenLoaiSP";
            this.TenLoai.HeaderText = "Loại sản phẩm";
            this.TenLoai.Name = "TenLoai";
            this.TenLoai.ReadOnly = true;
            // 
            // groupPanel5
            // 
            this.groupPanel5.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel5.Controls.Add(this.gridSanPham);
            this.groupPanel5.Location = new System.Drawing.Point(476, 236);
            this.groupPanel5.Name = "groupPanel5";
            this.groupPanel5.Size = new System.Drawing.Size(253, 323);
            // 
            // 
            // 
            this.groupPanel5.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel5.Style.BackColorGradientAngle = 90;
            this.groupPanel5.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel5.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel5.Style.BorderBottomWidth = 1;
            this.groupPanel5.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel5.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel5.Style.BorderLeftWidth = 1;
            this.groupPanel5.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel5.Style.BorderRightWidth = 1;
            this.groupPanel5.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel5.Style.BorderTopWidth = 1;
            this.groupPanel5.Style.CornerDiameter = 4;
            this.groupPanel5.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel5.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel5.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel5.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel5.TabIndex = 6;
            this.groupPanel5.Text = "Các sản phẩm đã gọi";
            // 
            // gridSanPham
            // 
            this.gridSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridSanPham.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSanPham.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridSanPham.Location = new System.Drawing.Point(0, 0);
            this.gridSanPham.Name = "gridSanPham";
            this.gridSanPham.ReadOnly = true;
            this.gridSanPham.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridSanPham.Size = new System.Drawing.Size(247, 302);
            this.gridSanPham.TabIndex = 1;
            this.gridSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridSanPham_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TenSanPham";
            this.dataGridViewTextBoxColumn1.HeaderText = "Tên sản phẩm";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DonGia";
            this.dataGridViewTextBoxColumn3.HeaderText = "Đơn giá";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // numSoLuong
            // 
            this.numSoLuong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.numSoLuong.Location = new System.Drawing.Point(372, 291);
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(90, 29);
            this.numSoLuong.TabIndex = 17;
            this.numSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.dataGridThucDon);
            this.groupPanel2.Location = new System.Drawing.Point(3, 234);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(356, 325);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel2.TabIndex = 5;
            this.groupPanel2.Text = "Các sản phẩm đã gọi";
            // 
            // dataGridThucDon
            // 
            this.dataGridThucDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridThucDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridThucDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridThucDon.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridThucDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridThucDon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridThucDon.Location = new System.Drawing.Point(0, 0);
            this.dataGridThucDon.Name = "dataGridThucDon";
            this.dataGridThucDon.ReadOnly = true;
            this.dataGridThucDon.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridThucDon.Size = new System.Drawing.Size(350, 304);
            this.dataGridThucDon.TabIndex = 1;
            this.dataGridThucDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridThucDon_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TenSanPham";
            this.Column1.HeaderText = "Tên sản phẩm";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "SoLuong";
            this.Column2.HeaderText = "Số lượng";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.butMoBan);
            this.groupPanel1.Controls.Add(this.lblThoiGianDaSD);
            this.groupPanel1.Controls.Add(this.txtTienGio);
            this.groupPanel1.Controls.Add(this.lblTinhTien);
            this.groupPanel1.Controls.Add(this.lblTongTien);
            this.groupPanel1.Controls.Add(this.label3);
            this.groupPanel1.Controls.Add(this.label2);
            this.groupPanel1.Controls.Add(this.txtNhanVien);
            this.groupPanel1.Controls.Add(this.label5);
            this.groupPanel1.Controls.Add(this.label1);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.butTinhTien);
            this.groupPanel1.Controls.Add(this.txtTGHT);
            this.groupPanel1.Controls.Add(this.txtThoiGian);
            this.groupPanel1.Controls.Add(this.txtTenBan);
            this.groupPanel1.Controls.Add(this.labelX6);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.txtMaHoaDon);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Location = new System.Drawing.Point(3, 7);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(473, 223);
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
            this.groupPanel1.TabIndex = 4;
            this.groupPanel1.Text = "Chi tiết hóa đơn";
            // 
            // butMoBan
            // 
            this.butMoBan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.butMoBan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.butMoBan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.butMoBan.Location = new System.Drawing.Point(113, 166);
            this.butMoBan.Name = "butMoBan";
            this.butMoBan.Size = new System.Drawing.Size(90, 29);
            this.butMoBan.TabIndex = 13;
            this.butMoBan.Text = "Mở phòng";
            this.butMoBan.Click += new System.EventHandler(this.butMoBan_Click);
            // 
            // lblThoiGianDaSD
            // 
            this.lblThoiGianDaSD.AutoSize = true;
            this.lblThoiGianDaSD.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblThoiGianDaSD.ForeColor = System.Drawing.Color.Red;
            this.lblThoiGianDaSD.Location = new System.Drawing.Point(292, 41);
            this.lblThoiGianDaSD.Name = "lblThoiGianDaSD";
            this.lblThoiGianDaSD.Size = new System.Drawing.Size(77, 19);
            this.lblThoiGianDaSD.TabIndex = 3;
            this.lblThoiGianDaSD.Text = "                 ";
            // 
            // txtTienGio
            // 
            this.txtTienGio.AutoSize = true;
            this.txtTienGio.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTienGio.ForeColor = System.Drawing.Color.Red;
            this.txtTienGio.Location = new System.Drawing.Point(385, 75);
            this.txtTienGio.Name = "txtTienGio";
            this.txtTienGio.Size = new System.Drawing.Size(77, 19);
            this.txtTienGio.TabIndex = 3;
            this.txtTienGio.Text = "                 ";
            // 
            // lblTinhTien
            // 
            this.lblTinhTien.AutoSize = true;
            this.lblTinhTien.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTinhTien.ForeColor = System.Drawing.Color.Red;
            this.lblTinhTien.Location = new System.Drawing.Point(385, 139);
            this.lblTinhTien.Name = "lblTinhTien";
            this.lblTinhTien.Size = new System.Drawing.Size(77, 19);
            this.lblTinhTien.TabIndex = 3;
            this.lblTinhTien.Text = "                 ";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTongTien.ForeColor = System.Drawing.Color.Red;
            this.lblTongTien.Location = new System.Drawing.Point(385, 107);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(77, 19);
            this.lblTongTien.TabIndex = 3;
            this.lblTongTien.Text = "                 ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(292, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thời gian sử dụng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(294, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tiền giờ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNhanVien
            // 
            // 
            // 
            // 
            this.txtNhanVien.Border.Class = "TextBoxBorder";
            this.txtNhanVien.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNhanVien.Location = new System.Drawing.Point(105, 70);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.Size = new System.Drawing.Size(177, 27);
            this.txtNhanVien.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(294, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tổng tiền";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(294, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tiền nước";
            // 
            // labelX5
            // 
            this.labelX5.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX5.Location = new System.Drawing.Point(1, 73);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(99, 23);
            this.labelX5.TabIndex = 11;
            this.labelX5.Text = "Nhân viên:";
            // 
            // butTinhTien
            // 
            this.butTinhTien.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.butTinhTien.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.butTinhTien.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.butTinhTien.Location = new System.Drawing.Point(209, 166);
            this.butTinhTien.Name = "butTinhTien";
            this.butTinhTien.Size = new System.Drawing.Size(104, 29);
            this.butTinhTien.TabIndex = 10;
            this.butTinhTien.Text = "Tính tiền";
            this.butTinhTien.Click += new System.EventHandler(this.butTinhTien_Click);
            // 
            // txtTGHT
            // 
            // 
            // 
            // 
            this.txtTGHT.Border.Class = "TextBoxBorder";
            this.txtTGHT.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTGHT.Location = new System.Drawing.Point(105, 134);
            this.txtTGHT.Name = "txtTGHT";
            this.txtTGHT.ReadOnly = true;
            this.txtTGHT.Size = new System.Drawing.Size(177, 27);
            this.txtTGHT.TabIndex = 7;
            // 
            // txtThoiGian
            // 
            // 
            // 
            // 
            this.txtThoiGian.Border.Class = "TextBoxBorder";
            this.txtThoiGian.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtThoiGian.Location = new System.Drawing.Point(105, 102);
            this.txtThoiGian.Name = "txtThoiGian";
            this.txtThoiGian.Size = new System.Drawing.Size(177, 27);
            this.txtThoiGian.TabIndex = 7;
            // 
            // txtTenBan
            // 
            // 
            // 
            // 
            this.txtTenBan.Border.Class = "TextBoxBorder";
            this.txtTenBan.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenBan.Location = new System.Drawing.Point(105, 38);
            this.txtTenBan.Name = "txtTenBan";
            this.txtTenBan.Size = new System.Drawing.Size(177, 27);
            this.txtTenBan.TabIndex = 6;
            // 
            // labelX6
            // 
            this.labelX6.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX6.Location = new System.Drawing.Point(1, 137);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(99, 23);
            this.labelX6.TabIndex = 2;
            this.labelX6.Text = "Thời gian ra";
            // 
            // labelX4
            // 
            this.labelX4.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX4.Location = new System.Drawing.Point(1, 105);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(99, 23);
            this.labelX4.TabIndex = 2;
            this.labelX4.Text = "Thời gian vào";
            // 
            // txtMaHoaDon
            // 
            // 
            // 
            // 
            this.txtMaHoaDon.Border.Class = "TextBoxBorder";
            this.txtMaHoaDon.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaHoaDon.Location = new System.Drawing.Point(105, 6);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.Size = new System.Drawing.Size(177, 27);
            this.txtMaHoaDon.TabIndex = 5;
            // 
            // labelX2
            // 
            this.labelX2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX2.Location = new System.Drawing.Point(1, 41);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(99, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Tên phòng:";
            // 
            // labelX1
            // 
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX1.Location = new System.Drawing.Point(1, 9);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(99, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Mã hóa đơn:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupPanel4);
            this.panel1.Controls.Add(this.groupPanel5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.groupPanel2);
            this.panel1.Controls.Add(this.groupPanel1);
            this.panel1.Controls.Add(this.butXoa);
            this.panel1.Controls.Add(this.butGiam);
            this.panel1.Controls.Add(this.butThem);
            this.panel1.Controls.Add(this.numSoLuong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(300, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 565);
            this.panel1.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(379, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 18;
            this.label4.Text = "Số lượng";
            // 
            // butXoa
            // 
            this.butXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.butXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.butXoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.butXoa.Image = global::MrLong_QLCaffe.Properties.Resources._001_051;
            this.butXoa.Location = new System.Drawing.Point(372, 409);
            this.butXoa.Name = "butXoa";
            this.butXoa.Size = new System.Drawing.Size(90, 35);
            this.butXoa.TabIndex = 16;
            this.butXoa.Text = "Xóa";
            this.butXoa.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.butXoa.Click += new System.EventHandler(this.butXoa_Click);
            // 
            // butGiam
            // 
            this.butGiam.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.butGiam.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.butGiam.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.butGiam.Image = global::MrLong_QLCaffe.Properties.Resources._001_02;
            this.butGiam.Location = new System.Drawing.Point(372, 368);
            this.butGiam.Name = "butGiam";
            this.butGiam.Size = new System.Drawing.Size(90, 35);
            this.butGiam.TabIndex = 16;
            this.butGiam.Text = "Giảm";
            this.butGiam.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.butGiam.Click += new System.EventHandler(this.butGiam_Click);
            // 
            // butThem
            // 
            this.butThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.butThem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.butThem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.butThem.Image = global::MrLong_QLCaffe.Properties.Resources._001_01;
            this.butThem.Location = new System.Drawing.Point(372, 327);
            this.butThem.Name = "butThem";
            this.butThem.Size = new System.Drawing.Size(90, 35);
            this.butThem.TabIndex = 16;
            this.butThem.Text = "Thêm";
            this.butThem.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.butThem.Click += new System.EventHandler(this.butThem_Click);
            // 
            // frmBanHang
            // 
            this.ClientSize = new System.Drawing.Size(1015, 565);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupPanel3);
            this.DoubleBuffered = true;
            this.Name = "frmBanHang";
            this.Text = "Quản lý karaoke";
            this.Load += new System.EventHandler(this.frmBanHang_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupPanel3.ResumeLayout(false);
            this.groupPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridLoaiSP)).EndInit();
            this.groupPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            this.groupPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridThucDon)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ListViewEx listViewBan;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuStripMoBan;
        private System.Windows.Forms.ToolStripMenuItem menuStripTinhTien;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel3;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel4;
        private DevComponents.DotNetBar.Controls.DataGridViewX gridLoaiSP;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel5;
        private DevComponents.DotNetBar.Controls.DataGridViewX gridSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoai;
        private System.Windows.Forms.Timer timer1;
        private DevComponents.DotNetBar.ButtonX butGiam;
        private DevComponents.DotNetBar.ButtonX butThem;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridThucDon;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.ButtonX butMoBan;
        private System.Windows.Forms.Label lblThoiGianDaSD;
        private System.Windows.Forms.Label txtTienGio;
        private System.Windows.Forms.Label lblTinhTien;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNhanVien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.ButtonX butTinhTien;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTGHT;
        private DevComponents.DotNetBar.Controls.TextBoxX txtThoiGian;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenBan;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaHoaDon;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX butXoa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}