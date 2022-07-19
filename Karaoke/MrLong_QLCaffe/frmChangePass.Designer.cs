namespace MrLong_QLCaffe
{
    partial class frmChangePass
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
            this.txtCu = new System.Windows.Forms.TextBox();
            this.txtMoi1 = new System.Windows.Forms.TextBox();
            this.txtMoi2 = new System.Windows.Forms.TextBox();
            this.butOK = new System.Windows.Forms.Button();
            this.butCance = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCu
            // 
            this.txtCu.Location = new System.Drawing.Point(136, 11);
            this.txtCu.Name = "txtCu";
            this.txtCu.Size = new System.Drawing.Size(153, 20);
            this.txtCu.TabIndex = 0;
            this.txtCu.UseSystemPasswordChar = true;
            // 
            // txtMoi1
            // 
            this.txtMoi1.Location = new System.Drawing.Point(136, 37);
            this.txtMoi1.Name = "txtMoi1";
            this.txtMoi1.Size = new System.Drawing.Size(153, 20);
            this.txtMoi1.TabIndex = 1;
            this.txtMoi1.UseSystemPasswordChar = true;
            this.txtMoi1.TextChanged += new System.EventHandler(this.txtMoi1_TextChanged);
            // 
            // txtMoi2
            // 
            this.txtMoi2.Location = new System.Drawing.Point(136, 63);
            this.txtMoi2.Name = "txtMoi2";
            this.txtMoi2.Size = new System.Drawing.Size(153, 20);
            this.txtMoi2.TabIndex = 2;
            this.txtMoi2.UseSystemPasswordChar = true;
            this.txtMoi2.TextChanged += new System.EventHandler(this.txtMoi2_TextChanged);
            // 
            // butOK
            // 
            this.butOK.Location = new System.Drawing.Point(136, 89);
            this.butOK.Name = "butOK";
            this.butOK.Size = new System.Drawing.Size(75, 23);
            this.butOK.TabIndex = 3;
            this.butOK.Text = "OK";
            this.butOK.UseVisualStyleBackColor = true;
            this.butOK.Click += new System.EventHandler(this.butOK_Click);
            // 
            // butCance
            // 
            this.butCance.Location = new System.Drawing.Point(214, 89);
            this.butCance.Name = "butCance";
            this.butCance.Size = new System.Drawing.Size(75, 23);
            this.butCance.TabIndex = 4;
            this.butCance.Text = "Đóng";
            this.butCance.UseVisualStyleBackColor = true;
            this.butCance.Click += new System.EventHandler(this.butCance_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nhập mật khẩu cũ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nhập mật khẩu mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nhập lại mật khẩu mới";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(295, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "OK";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(295, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "OK";
            // 
            // frmChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 125);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butCance);
            this.Controls.Add(this.butOK);
            this.Controls.Add(this.txtMoi2);
            this.Controls.Add(this.txtMoi1);
            this.Controls.Add(this.txtCu);
            this.Name = "frmChangePass";
            this.Text = "Thay đổi mật khẩu";
            this.Load += new System.EventHandler(this.frmChangePass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCu;
        private System.Windows.Forms.TextBox txtMoi1;
        private System.Windows.Forms.TextBox txtMoi2;
        private System.Windows.Forms.Button butOK;
        private System.Windows.Forms.Button butCance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}