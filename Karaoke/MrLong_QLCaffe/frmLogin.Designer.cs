namespace MrLong_QLCaffe
{
    partial class frmLogin
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
            this.txtTenDangNhap = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.butThoat = new DevComponents.DotNetBar.ButtonX();
            this.butDangNhap = new DevComponents.DotNetBar.ButtonX();
            this.linkQuenPass = new System.Windows.Forms.LinkLabel();
            this.txtMatKhau = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SuspendLayout();
            // 
            // txtTenDangNhap
            // 
            // 
            // 
            // 
            this.txtTenDangNhap.Border.Class = "TextBoxBorder";
            this.txtTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDangNhap.Location = new System.Drawing.Point(139, 24);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(214, 26);
            this.txtTenDangNhap.TabIndex = 0;
            // 
            // labelX1
            // 
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(15, 24);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(118, 23);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "Tên đăng nhập:";
            // 
            // labelX2
            // 
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(15, 56);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "Mật khẩu:";
            // 
            // butThoat
            // 
            this.butThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.butThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.butThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butThoat.Location = new System.Drawing.Point(187, 88);
            this.butThoat.Name = "butThoat";
            this.butThoat.Size = new System.Drawing.Size(94, 34);
            this.butThoat.TabIndex = 7;
            this.butThoat.Text = "Thoát";
            this.butThoat.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // butDangNhap
            // 
            this.butDangNhap.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.butDangNhap.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.butDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDangNhap.Location = new System.Drawing.Point(92, 88);
            this.butDangNhap.Name = "butDangNhap";
            this.butDangNhap.Size = new System.Drawing.Size(89, 34);
            this.butDangNhap.TabIndex = 2;
            this.butDangNhap.Text = "Đăng nhập";
            this.butDangNhap.Click += new System.EventHandler(this.butDangNhap_Click_1);
            // 
            // linkQuenPass
            // 
            this.linkQuenPass.AutoSize = true;
            this.linkQuenPass.Location = new System.Drawing.Point(136, 130);
            this.linkQuenPass.Name = "linkQuenPass";
            this.linkQuenPass.Size = new System.Drawing.Size(86, 13);
            this.linkQuenPass.TabIndex = 9;
            this.linkQuenPass.TabStop = true;
            this.linkQuenPass.Text = "Quên mật khẩu?";
            this.linkQuenPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkQuenPass_LinkClicked);
            // 
            // txtMatKhau
            // 
            // 
            // 
            // 
            this.txtMatKhau.Border.Class = "TextBoxBorder";
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(139, 56);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '●';
            this.txtMatKhau.Size = new System.Drawing.Size(214, 26);
            this.txtMatKhau.TabIndex = 1;
            this.txtMatKhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatKhau_KeyPress);
            // 
            // frmLogin
            // 
            this.ClientSize = new System.Drawing.Size(371, 150);
            this.Controls.Add(this.linkQuenPass);
            this.Controls.Add(this.butDangNhap);
            this.Controls.Add(this.butThoat);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTenDangNhap);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đăng nhập";
            this.TitleText = "Đăng nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        public DevComponents.DotNetBar.Controls.TextBoxX txtTenDangNhap;
        private DevComponents.DotNetBar.ButtonX butThoat;
        private DevComponents.DotNetBar.ButtonX butDangNhap;
        private System.Windows.Forms.LinkLabel linkQuenPass;
        public DevComponents.DotNetBar.Controls.TextBoxX txtMatKhau;
    }
}