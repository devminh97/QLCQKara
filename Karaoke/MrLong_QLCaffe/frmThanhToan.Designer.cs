namespace MrLong_QLCaffe
{
    partial class frmThanhToan
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTien = new System.Windows.Forms.Label();
            this.lblPhong = new System.Windows.Forms.Label();
            this.butIn = new System.Windows.Forms.Button();
            this.butKhongIn = new System.Windows.Forms.Button();
            this.butHuy = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.butXemHD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(26, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên phòng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(26, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số tiền:";
            // 
            // lblTien
            // 
            this.lblTien.AutoSize = true;
            this.lblTien.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblTien.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTien.ForeColor = System.Drawing.Color.Red;
            this.lblTien.Location = new System.Drawing.Point(175, 80);
            this.lblTien.Name = "lblTien";
            this.lblTien.Size = new System.Drawing.Size(97, 31);
            this.lblTien.TabIndex = 4;
            this.lblTien.Text = "Số tiền:";
            // 
            // lblPhong
            // 
            this.lblPhong.AutoSize = true;
            this.lblPhong.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPhong.ForeColor = System.Drawing.Color.Red;
            this.lblPhong.Location = new System.Drawing.Point(175, 49);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(137, 31);
            this.lblPhong.TabIndex = 3;
            this.lblPhong.Text = "Tên phòng:";
            // 
            // butIn
            // 
            this.butIn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.butIn.Location = new System.Drawing.Point(12, 130);
            this.butIn.Name = "butIn";
            this.butIn.Size = new System.Drawing.Size(153, 38);
            this.butIn.TabIndex = 5;
            this.butIn.Text = "Thanh toán và in";
            this.butIn.UseVisualStyleBackColor = true;
            this.butIn.Click += new System.EventHandler(this.butIn_Click);
            // 
            // butKhongIn
            // 
            this.butKhongIn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.butKhongIn.Location = new System.Drawing.Point(171, 130);
            this.butKhongIn.Name = "butKhongIn";
            this.butKhongIn.Size = new System.Drawing.Size(168, 38);
            this.butKhongIn.TabIndex = 6;
            this.butKhongIn.Text = "Thanh toán và đóng";
            this.butKhongIn.UseVisualStyleBackColor = true;
            this.butKhongIn.Click += new System.EventHandler(this.butKhongIn_Click);
            // 
            // butHuy
            // 
            this.butHuy.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.butHuy.Location = new System.Drawing.Point(345, 130);
            this.butHuy.Name = "butHuy";
            this.butHuy.Size = new System.Drawing.Size(107, 38);
            this.butHuy.TabIndex = 7;
            this.butHuy.Text = "Hủy";
            this.butHuy.UseVisualStyleBackColor = true;
            this.butHuy.Click += new System.EventHandler(this.butHuy_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(26, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(383, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Bạn có muốn thanh toán hóa đơn này không?";
            // 
            // butXemHD
            // 
            this.butXemHD.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butXemHD.Location = new System.Drawing.Point(345, 59);
            this.butXemHD.Name = "butXemHD";
            this.butXemHD.Size = new System.Drawing.Size(108, 52);
            this.butXemHD.TabIndex = 9;
            this.butXemHD.Text = "Xem hóa đơn";
            this.butXemHD.UseVisualStyleBackColor = true;
            this.butXemHD.Click += new System.EventHandler(this.butXemHD_Click);
            // 
            // frmThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 186);
            this.Controls.Add(this.butXemHD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.butHuy);
            this.Controls.Add(this.butKhongIn);
            this.Controls.Add(this.butIn);
            this.Controls.Add(this.lblTien);
            this.Controls.Add(this.lblPhong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Name = "frmThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thanh toán hóa đơn";
            this.Load += new System.EventHandler(this.frmThanhToan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.Label lblTien;
        private System.Windows.Forms.Button butIn;
        private System.Windows.Forms.Button butKhongIn;
        private System.Windows.Forms.Button butHuy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button butXemHD;
    }
}