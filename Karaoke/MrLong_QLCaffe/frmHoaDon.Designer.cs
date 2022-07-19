namespace MrLong_QLCaffe
{
    partial class frmHoaDon
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
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.butXoa = new DevComponents.DotNetBar.ButtonX();
            this.cboNhanVien = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.cboTenBan = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dateTimeHD = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txtMaHoaDon = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.gridHoaDon = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colMaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenBan = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaNhanVien = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Karaoke = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTinhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.butXoa);
            this.groupPanel1.Controls.Add(this.cboNhanVien);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.cboTenBan);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.dateTimeHD);
            this.groupPanel1.Controls.Add(this.txtMaHoaDon);
            this.groupPanel1.Location = new System.Drawing.Point(212, 2);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(396, 146);
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
            this.groupPanel1.Text = "Hóa đơn";
            // 
            // butXoa
            // 
            this.butXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.butXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.butXoa.Location = new System.Drawing.Point(307, 64);
            this.butXoa.Name = "butXoa";
            this.butXoa.Size = new System.Drawing.Size(75, 23);
            this.butXoa.TabIndex = 13;
            this.butXoa.Text = "Xóa";
            this.butXoa.Click += new System.EventHandler(this.butXoa_Click);
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.DisplayMember = "Text";
            this.cboNhanVien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.ItemHeight = 14;
            this.cboNhanVien.Location = new System.Drawing.Point(100, 92);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(168, 20);
            this.cboNhanVien.TabIndex = 12;
            // 
            // labelX5
            // 
            this.labelX5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.Location = new System.Drawing.Point(3, 92);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(91, 23);
            this.labelX5.TabIndex = 11;
            this.labelX5.Text = "Tên nhân viên";
            // 
            // labelX3
            // 
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(3, 57);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 9;
            this.labelX3.Text = "Thời gian";
            // 
            // cboTenBan
            // 
            this.cboTenBan.DisplayMember = "Text";
            this.cboTenBan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTenBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTenBan.FormattingEnabled = true;
            this.cboTenBan.ItemHeight = 16;
            this.cboTenBan.Location = new System.Drawing.Point(100, 29);
            this.cboTenBan.Name = "cboTenBan";
            this.cboTenBan.Size = new System.Drawing.Size(168, 22);
            this.cboTenBan.TabIndex = 8;
            // 
            // labelX2
            // 
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(3, 28);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 7;
            this.labelX2.Text = "Tên bàn:";
            // 
            // labelX1
            // 
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(3, -1);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 6;
            this.labelX1.Text = "Mã hóa đơn:";
            // 
            // dateTimeHD
            // 
            // 
            // 
            // 
            this.dateTimeHD.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateTimeHD.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateTimeHD.ButtonDropDown.Visible = true;
            this.dateTimeHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeHD.Location = new System.Drawing.Point(100, 58);
            // 
            // 
            // 
            this.dateTimeHD.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateTimeHD.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dateTimeHD.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateTimeHD.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateTimeHD.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeHD.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateTimeHD.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateTimeHD.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateTimeHD.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateTimeHD.MonthCalendar.DisplayMonth = new System.DateTime(2012, 6, 1, 0, 0, 0, 0);
            this.dateTimeHD.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dateTimeHD.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateTimeHD.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateTimeHD.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeHD.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateTimeHD.MonthCalendar.TodayButtonVisible = true;
            this.dateTimeHD.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dateTimeHD.Name = "dateTimeHD";
            this.dateTimeHD.Size = new System.Drawing.Size(168, 22);
            this.dateTimeHD.TabIndex = 3;
            this.dateTimeHD.Value = new System.DateTime(2012, 6, 11, 0, 0, 0, 0);
            // 
            // txtMaHoaDon
            // 
            // 
            // 
            // 
            this.txtMaHoaDon.Border.Class = "TextBoxBorder";
            this.txtMaHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHoaDon.Location = new System.Drawing.Point(100, 3);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.Size = new System.Drawing.Size(168, 22);
            this.txtMaHoaDon.TabIndex = 0;
            // 
            // gridHoaDon
            // 
            this.gridHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridHoaDon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridHoaDon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.gridHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHD,
            this.colTenBan,
            this.colThoiGian,
            this.colMaNhanVien,
            this.Karaoke,
            this.TongTien,
            this.colTinhTien});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridHoaDon.DefaultCellStyle = dataGridViewCellStyle1;
            this.gridHoaDon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridHoaDon.Location = new System.Drawing.Point(-1, 163);
            this.gridHoaDon.Name = "gridHoaDon";
            this.gridHoaDon.Size = new System.Drawing.Size(782, 237);
            this.gridHoaDon.TabIndex = 1;
            this.gridHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridHoaDon_CellClick);
            // 
            // colMaHD
            // 
            this.colMaHD.DataPropertyName = "MaHoaDon";
            this.colMaHD.HeaderText = "Mã hóa đơn";
            this.colMaHD.Name = "colMaHD";
            // 
            // colTenBan
            // 
            this.colTenBan.DataPropertyName = "MaBan";
            this.colTenBan.HeaderText = "Tên bàn";
            this.colTenBan.Name = "colTenBan";
            this.colTenBan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTenBan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colThoiGian
            // 
            this.colThoiGian.DataPropertyName = "ThoiGian";
            this.colThoiGian.HeaderText = "Thời gian";
            this.colThoiGian.Name = "colThoiGian";
            this.colThoiGian.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colThoiGian.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colMaNhanVien
            // 
            this.colMaNhanVien.DataPropertyName = "MaNhanVien";
            this.colMaNhanVien.HeaderText = "Tên nhân viên";
            this.colMaNhanVien.Name = "colMaNhanVien";
            this.colMaNhanVien.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMaNhanVien.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Karaoke
            // 
            this.Karaoke.DataPropertyName = "Karaoke";
            this.Karaoke.HeaderText = "Tiền giờ";
            this.Karaoke.Name = "Karaoke";
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.Name = "TongTien";
            // 
            // colTinhTien
            // 
            this.colTinhTien.DataPropertyName = "TinhTien";
            this.colTinhTien.HeaderText = "Tính tiền";
            this.colTinhTien.Name = "colTinhTien";
            // 
            // frmHoaDon
            // 
            this.ClientSize = new System.Drawing.Size(779, 399);
            this.Controls.Add(this.gridHoaDon);
            this.Controls.Add(this.groupPanel1);
            this.DoubleBuffered = true;
            this.Name = "frmHoaDon";
            this.Text = "Quản lý hóa đơn";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaHoaDon;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTimeHD;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboTenBan;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboNhanVien;
        private DevComponents.DotNetBar.Controls.DataGridViewX gridHoaDon;
        private DevComponents.DotNetBar.ButtonX butXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHD;
        private System.Windows.Forms.DataGridViewComboBoxColumn colTenBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThoiGian;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Karaoke;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTinhTien;
    }
}