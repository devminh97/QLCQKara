namespace MrLong_QLCaffe.report
{
    partial class rptThongKe
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kt = new System.Windows.Forms.DateTimePicker();
            this.bd = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.kARAOKEDataSet = new MrLong_QLCaffe.KARAOKEDataSet();
            this.thongKeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thongKeTableAdapter = new MrLong_QLCaffe.KARAOKEDataSetTableAdapters.ThongKeTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kARAOKEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongKeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.kt);
            this.panel1.Controls.Add(this.bd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 59);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(442, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đến ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Từ ngày";
            // 
            // kt
            // 
            this.kt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.kt.Location = new System.Drawing.Point(305, 22);
            this.kt.Name = "kt";
            this.kt.Size = new System.Drawing.Size(115, 20);
            this.kt.TabIndex = 1;
            // 
            // bd
            // 
            this.bd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.bd.Location = new System.Drawing.Point(107, 23);
            this.bd.Name = "bd";
            this.bd.Size = new System.Drawing.Size(113, 20);
            this.bd.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reportViewer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(640, 403);
            this.panel2.TabIndex = 1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.thongKeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MrLong_QLCaffe.report.rptThongKe.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(640, 403);
            this.reportViewer1.TabIndex = 0;
            // 
            // kARAOKEDataSet
            // 
            this.kARAOKEDataSet.DataSetName = "KARAOKEDataSet";
            this.kARAOKEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // thongKeBindingSource
            // 
            this.thongKeBindingSource.DataMember = "ThongKe";
            this.thongKeBindingSource.DataSource = this.kARAOKEDataSet;
            // 
            // thongKeTableAdapter
            // 
            this.thongKeTableAdapter.ClearBeforeFill = true;
            // 
            // rptThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 462);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "rptThongKe";
            this.Text = "rptThongKe";
            this.Load += new System.EventHandler(this.rptThongKe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kARAOKEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongKeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker kt;
        private System.Windows.Forms.DateTimePicker bd;
        private System.Windows.Forms.BindingSource thongKeBindingSource;
        private KARAOKEDataSet kARAOKEDataSet;
        private KARAOKEDataSetTableAdapters.ThongKeTableAdapter thongKeTableAdapter;


    }
}