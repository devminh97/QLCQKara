namespace MrLong_QLCaffe
{
    partial class frmKhuVuc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.butKhongLuu = new DevComponents.DotNetBar.ButtonX();
            this.butLuu = new DevComponents.DotNetBar.ButtonX();
            this.butXoa = new DevComponents.DotNetBar.ButtonX();
            this.butSua = new DevComponents.DotNetBar.ButtonX();
            this.butThem = new DevComponents.DotNetBar.ButtonX();
            this.txtTenKV = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMaKV = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dataGridKhuVuc = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colMaKV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenKV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtGiaPhong = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKhuVuc)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.butKhongLuu);
            this.groupPanel1.Controls.Add(this.butLuu);
            this.groupPanel1.Controls.Add(this.butXoa);
            this.groupPanel1.Controls.Add(this.butSua);
            this.groupPanel1.Controls.Add(this.butThem);
            this.groupPanel1.Controls.Add(this.txtGiaPhong);
            this.groupPanel1.Controls.Add(this.txtTenKV);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.txtMaKV);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Location = new System.Drawing.Point(3, 2);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(291, 187);
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
            this.groupPanel1.TabIndex = 0;
            this.groupPanel1.Text = "Khu vực";
            // 
            // butKhongLuu
            // 
            this.butKhongLuu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.butKhongLuu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.butKhongLuu.Location = new System.Drawing.Point(144, 140);
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
            this.butLuu.Location = new System.Drawing.Point(63, 141);
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
            this.butXoa.Location = new System.Drawing.Point(179, 111);
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
            this.butSua.Location = new System.Drawing.Point(98, 111);
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
            this.butThem.Location = new System.Drawing.Point(17, 111);
            this.butThem.Name = "butThem";
            this.butThem.Size = new System.Drawing.Size(75, 23);
            this.butThem.TabIndex = 4;
            this.butThem.Text = "Thêm";
            this.butThem.Click += new System.EventHandler(this.butThem_Click);
            // 
            // txtTenKV
            // 
            // 
            // 
            // 
            this.txtTenKV.Border.Class = "TextBoxBorder";
            this.txtTenKV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKV.Location = new System.Drawing.Point(86, 46);
            this.txtTenKV.Name = "txtTenKV";
            this.txtTenKV.Size = new System.Drawing.Size(180, 22);
            this.txtTenKV.TabIndex = 3;
            this.txtTenKV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenKV_KeyPress);
            // 
            // txtMaKV
            // 
            // 
            // 
            // 
            this.txtMaKV.Border.Class = "TextBoxBorder";
            this.txtMaKV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKV.Location = new System.Drawing.Point(86, 17);
            this.txtMaKV.Name = "txtMaKV";
            this.txtMaKV.Size = new System.Drawing.Size(180, 22);
            this.txtMaKV.TabIndex = 2;
            // 
            // labelX2
            // 
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(5, 46);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Tên khu vực";
            // 
            // labelX1
            // 
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(5, 17);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Mã khu vực:";
            // 
            // dataGridKhuVuc
            // 
            this.dataGridKhuVuc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridKhuVuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaKV,
            this.colTenKV,
            this.GiaPhong});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridKhuVuc.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridKhuVuc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridKhuVuc.Location = new System.Drawing.Point(4, 195);
            this.dataGridKhuVuc.Name = "dataGridKhuVuc";
            this.dataGridKhuVuc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridKhuVuc.Size = new System.Drawing.Size(288, 186);
            this.dataGridKhuVuc.TabIndex = 1;
            this.dataGridKhuVuc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridKhuVuc_CellClick);
            // 
            // colMaKV
            // 
            this.colMaKV.DataPropertyName = "MaKhuVuc";
            this.colMaKV.HeaderText = "Mã khu vực";
            this.colMaKV.Name = "colMaKV";
            // 
            // colTenKV
            // 
            this.colTenKV.DataPropertyName = "TenKhuVuc";
            this.colTenKV.HeaderText = "Tên khu vực";
            this.colTenKV.Name = "colTenKV";
            // 
            // GiaPhong
            // 
            this.GiaPhong.DataPropertyName = "GiaPhong";
            this.GiaPhong.HeaderText = "Giá phòng";
            this.GiaPhong.Name = "GiaPhong";
            // 
            // labelX3
            // 
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(5, 74);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.labelX3.TabIndex = 1;
            this.labelX3.Text = "Giá phòng";
            // 
            // txtGiaPhong
            // 
            // 
            // 
            // 
            this.txtGiaPhong.Border.Class = "TextBoxBorder";
            this.txtGiaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaPhong.Location = new System.Drawing.Point(86, 74);
            this.txtGiaPhong.Name = "txtGiaPhong";
            this.txtGiaPhong.Size = new System.Drawing.Size(180, 22);
            this.txtGiaPhong.TabIndex = 3;
            this.txtGiaPhong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaPhong_KeyPress);
            // 
            // frmKhuVuc
            // 
            this.ClientSize = new System.Drawing.Size(294, 383);
            this.Controls.Add(this.dataGridKhuVuc);
            this.Controls.Add(this.groupPanel1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "frmKhuVuc";
            this.Text = "Quản lý khu vực";
            this.Load += new System.EventHandler(this.frmKhuVuc_Load);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKhuVuc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenKV;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaKV;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX butXoa;
        private DevComponents.DotNetBar.ButtonX butSua;
        private DevComponents.DotNetBar.ButtonX butThem;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridKhuVuc;
        private DevComponents.DotNetBar.ButtonX butKhongLuu;
        private DevComponents.DotNetBar.ButtonX butLuu;
        private DevComponents.DotNetBar.Controls.TextBoxX txtGiaPhong;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenKV;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaPhong;
    }
}