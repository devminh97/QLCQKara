namespace MrLong_QLCaffe
{
    partial class frmLoaiSP
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.butXoa = new DevComponents.DotNetBar.ButtonX();
            this.butSua = new DevComponents.DotNetBar.ButtonX();
            this.butThem = new DevComponents.DotNetBar.ButtonX();
            this.butHuy = new DevComponents.DotNetBar.ButtonX();
            this.butLuu = new DevComponents.DotNetBar.ButtonX();
            this.txtTenLoai = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMaLoai = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.datagridLoai = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.MaLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridLoai)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.butXoa);
            this.groupPanel1.Controls.Add(this.butSua);
            this.groupPanel1.Controls.Add(this.butThem);
            this.groupPanel1.Controls.Add(this.butHuy);
            this.groupPanel1.Controls.Add(this.butLuu);
            this.groupPanel1.Controls.Add(this.txtTenLoai);
            this.groupPanel1.Controls.Add(this.txtMaLoai);
            this.groupPanel1.Location = new System.Drawing.Point(3, 1);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(305, 154);
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
            this.groupPanel1.Text = "Quản lý loại";
            // 
            // labelX2
            // 
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(11, 34);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 8;
            this.labelX2.Text = "Tên loại:";
            // 
            // labelX1
            // 
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(11, 8);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 7;
            this.labelX1.Text = "Mã loại:";
            // 
            // butXoa
            // 
            this.butXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.butXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.butXoa.Location = new System.Drawing.Point(198, 71);
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
            this.butSua.Location = new System.Drawing.Point(117, 71);
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
            this.butThem.Location = new System.Drawing.Point(36, 71);
            this.butThem.Name = "butThem";
            this.butThem.Size = new System.Drawing.Size(75, 23);
            this.butThem.TabIndex = 4;
            this.butThem.Text = "Thêm";
            this.butThem.Click += new System.EventHandler(this.butThem_Click);
            // 
            // butHuy
            // 
            this.butHuy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.butHuy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.butHuy.Location = new System.Drawing.Point(159, 100);
            this.butHuy.Name = "butHuy";
            this.butHuy.Size = new System.Drawing.Size(75, 23);
            this.butHuy.TabIndex = 3;
            this.butHuy.Text = "Hủy bỏ";
            this.butHuy.Click += new System.EventHandler(this.butHuy_Click);
            // 
            // butLuu
            // 
            this.butLuu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.butLuu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.butLuu.Location = new System.Drawing.Point(78, 100);
            this.butLuu.Name = "butLuu";
            this.butLuu.Size = new System.Drawing.Size(75, 23);
            this.butLuu.TabIndex = 2;
            this.butLuu.Text = "Lưu lại";
            this.butLuu.Click += new System.EventHandler(this.butLuu_Click);
            // 
            // txtTenLoai
            // 
            // 
            // 
            // 
            this.txtTenLoai.Border.Class = "TextBoxBorder";
            this.txtTenLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLoai.Location = new System.Drawing.Point(92, 34);
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.Size = new System.Drawing.Size(191, 22);
            this.txtTenLoai.TabIndex = 1;
            // 
            // txtMaLoai
            // 
            // 
            // 
            // 
            this.txtMaLoai.Border.Class = "TextBoxBorder";
            this.txtMaLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLoai.Location = new System.Drawing.Point(92, 8);
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.Size = new System.Drawing.Size(191, 22);
            this.txtMaLoai.TabIndex = 0;
            // 
            // datagridLoai
            // 
            this.datagridLoai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridLoai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoai,
            this.TenLoai});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridLoai.DefaultCellStyle = dataGridViewCellStyle5;
            this.datagridLoai.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.datagridLoai.Location = new System.Drawing.Point(3, 163);
            this.datagridLoai.Name = "datagridLoai";
            this.datagridLoai.Size = new System.Drawing.Size(305, 210);
            this.datagridLoai.TabIndex = 1;
            this.datagridLoai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridLoai_CellClick);
            // 
            // MaLoai
            // 
            this.MaLoai.DataPropertyName = "MaLoaiSP";
            this.MaLoai.HeaderText = "Mã loại";
            this.MaLoai.Name = "MaLoai";
            // 
            // TenLoai
            // 
            this.TenLoai.DataPropertyName = "TenLoaiSP";
            this.TenLoai.HeaderText = "Tên loại";
            this.TenLoai.Name = "TenLoai";
            // 
            // frmLoaiSP
            // 
            this.ClientSize = new System.Drawing.Size(310, 377);
            this.Controls.Add(this.datagridLoai);
            this.Controls.Add(this.groupPanel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "frmLoaiSP";
            this.Text = "Loại sản phẩm";
            this.Load += new System.EventHandler(this.frmLoaiSP_Load);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridLoai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX butXoa;
        private DevComponents.DotNetBar.ButtonX butSua;
        private DevComponents.DotNetBar.ButtonX butThem;
        private DevComponents.DotNetBar.ButtonX butHuy;
        private DevComponents.DotNetBar.ButtonX butLuu;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenLoai;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaLoai;
        private DevComponents.DotNetBar.Controls.DataGridViewX datagridLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoai;

    }
}