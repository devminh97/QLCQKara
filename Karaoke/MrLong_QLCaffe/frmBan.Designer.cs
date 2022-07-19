namespace MrLong_QLCaffe
{
    partial class frmBan
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
            this.ban = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.butKhongLuu = new DevComponents.DotNetBar.ButtonX();
            this.butLuu = new DevComponents.DotNetBar.ButtonX();
            this.butXoa = new DevComponents.DotNetBar.ButtonX();
            this.butSua = new DevComponents.DotNetBar.ButtonX();
            this.butThem = new DevComponents.DotNetBar.ButtonX();
            this.txtTenBan = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMaBan = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dataBan = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colMaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKhuVuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ban.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBan)).BeginInit();
            this.SuspendLayout();
            // 
            // ban
            // 
            this.ban.CanvasColor = System.Drawing.SystemColors.Control;
            this.ban.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ban.Controls.Add(this.comboBox1);
            this.ban.Controls.Add(this.labelX3);
            this.ban.Controls.Add(this.butKhongLuu);
            this.ban.Controls.Add(this.butLuu);
            this.ban.Controls.Add(this.butXoa);
            this.ban.Controls.Add(this.butSua);
            this.ban.Controls.Add(this.butThem);
            this.ban.Controls.Add(this.txtTenBan);
            this.ban.Controls.Add(this.txtMaBan);
            this.ban.Controls.Add(this.labelX2);
            this.ban.Controls.Add(this.labelX1);
            this.ban.Location = new System.Drawing.Point(5, 0);
            this.ban.Name = "ban";
            this.ban.Size = new System.Drawing.Size(291, 190);
            // 
            // 
            // 
            this.ban.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.ban.Style.BackColorGradientAngle = 90;
            this.ban.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.ban.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ban.Style.BorderBottomWidth = 1;
            this.ban.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.ban.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ban.Style.BorderLeftWidth = 1;
            this.ban.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ban.Style.BorderRightWidth = 1;
            this.ban.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ban.Style.BorderTopWidth = 1;
            this.ban.Style.CornerDiameter = 4;
            this.ban.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.ban.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.ban.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.ban.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.ban.TabIndex = 2;
            this.ban.Text = "Quản lý bàn";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(86, 77);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // labelX3
            // 
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(5, 75);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 9;
            this.labelX3.Text = "Khu vực:";
            // 
            // butKhongLuu
            // 
            this.butKhongLuu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.butKhongLuu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.butKhongLuu.Location = new System.Drawing.Point(146, 142);
            this.butKhongLuu.Name = "butKhongLuu";
            this.butKhongLuu.Size = new System.Drawing.Size(75, 23);
            this.butKhongLuu.TabIndex = 8;
            this.butKhongLuu.Text = "Không lưu";
            this.butKhongLuu.Click += new System.EventHandler(this.butKhongLuu_Click);
            // 
            // butLuu
            // 
            this.butLuu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.butLuu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.butLuu.Location = new System.Drawing.Point(65, 143);
            this.butLuu.Name = "butLuu";
            this.butLuu.Size = new System.Drawing.Size(75, 23);
            this.butLuu.TabIndex = 7;
            this.butLuu.Text = "Lưu lại";
            this.butLuu.Click += new System.EventHandler(this.butLuu_Click);
            // 
            // butXoa
            // 
            this.butXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.butXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.butXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butXoa.Location = new System.Drawing.Point(181, 113);
            this.butXoa.Name = "butXoa";
            this.butXoa.Size = new System.Drawing.Size(75, 23);
            this.butXoa.TabIndex = 6;
            this.butXoa.Text = "Xóa";
            this.butXoa.Click += new System.EventHandler(this.butXoa_Click);
            // 
            // butSua
            // 
            this.butSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.butSua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.butSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSua.Location = new System.Drawing.Point(100, 113);
            this.butSua.Name = "butSua";
            this.butSua.Size = new System.Drawing.Size(75, 23);
            this.butSua.TabIndex = 5;
            this.butSua.Text = "Sửa";
            this.butSua.Click += new System.EventHandler(this.butSua_Click);
            // 
            // butThem
            // 
            this.butThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.butThem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.butThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butThem.Location = new System.Drawing.Point(19, 113);
            this.butThem.Name = "butThem";
            this.butThem.Size = new System.Drawing.Size(75, 23);
            this.butThem.TabIndex = 4;
            this.butThem.Text = "Thêm";
            this.butThem.Click += new System.EventHandler(this.butThem_Click);
            // 
            // txtTenBan
            // 
            // 
            // 
            // 
            this.txtTenBan.Border.Class = "TextBoxBorder";
            this.txtTenBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenBan.Location = new System.Drawing.Point(86, 46);
            this.txtTenBan.Name = "txtTenBan";
            this.txtTenBan.Size = new System.Drawing.Size(180, 22);
            this.txtTenBan.TabIndex = 3;
            // 
            // txtMaBan
            // 
            // 
            // 
            // 
            this.txtMaBan.Border.Class = "TextBoxBorder";
            this.txtMaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaBan.Location = new System.Drawing.Point(86, 17);
            this.txtMaBan.Name = "txtMaBan";
            this.txtMaBan.Size = new System.Drawing.Size(180, 22);
            this.txtMaBan.TabIndex = 2;
            // 
            // labelX2
            // 
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(5, 46);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Tên phòng:";
            // 
            // labelX1
            // 
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(5, 17);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Mã phòng:";
            // 
            // dataBan
            // 
            this.dataBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaBan,
            this.colTenBan,
            this.MaKhuVuc});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataBan.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataBan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataBan.Location = new System.Drawing.Point(2, 196);
            this.dataBan.Name = "dataBan";
            this.dataBan.ReadOnly = true;
            this.dataBan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataBan.Size = new System.Drawing.Size(294, 210);
            this.dataBan.TabIndex = 3;
            this.dataBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataBan_CellClick);
            // 
            // colMaBan
            // 
            this.colMaBan.DataPropertyName = "MaBan";
            this.colMaBan.HeaderText = "Mã bàn";
            this.colMaBan.Name = "colMaBan";
            this.colMaBan.ReadOnly = true;
            // 
            // colTenBan
            // 
            this.colTenBan.DataPropertyName = "TenBan";
            this.colTenBan.HeaderText = "Tên phòng";
            this.colTenBan.Name = "colTenBan";
            this.colTenBan.ReadOnly = true;
            // 
            // MaKhuVuc
            // 
            this.MaKhuVuc.DataPropertyName = "TenKhuVuc";
            this.MaKhuVuc.HeaderText = "Khu vực";
            this.MaKhuVuc.Name = "MaKhuVuc";
            this.MaKhuVuc.ReadOnly = true;
            // 
            // frmBan
            // 
            this.ClientSize = new System.Drawing.Size(300, 409);
            this.Controls.Add(this.ban);
            this.Controls.Add(this.dataBan);
            this.DoubleBuffered = true;
            this.Name = "frmBan";
            this.Text = "Quản lý phòng";
            this.Load += new System.EventHandler(this.frmBan_Load);
            this.ban.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataBan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel ban;
        private DevComponents.DotNetBar.ButtonX butKhongLuu;
        private DevComponents.DotNetBar.ButtonX butLuu;
        private DevComponents.DotNetBar.ButtonX butXoa;
        private DevComponents.DotNetBar.ButtonX butSua;
        private DevComponents.DotNetBar.ButtonX butThem;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenBan;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaBan;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataBan;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhuVuc;
    }
}