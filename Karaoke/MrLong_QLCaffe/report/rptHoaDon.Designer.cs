namespace MrLong_QLCaffe.report
{
    partial class rptHoaDon
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tblThongTinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataReport = new MrLong_QLCaffe.report.dataReport();
            this.tblChiTietHoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblHoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tblThongTinTableAdapter = new MrLong_QLCaffe.report.dataReportTableAdapters.tblThongTinTableAdapter();
            this.tblChiTietHoaDonTableAdapter = new MrLong_QLCaffe.report.dataReportTableAdapters.tblChiTietHoaDonTableAdapter();
            this.tblHoaDonTableAdapter = new MrLong_QLCaffe.report.dataReportTableAdapters.tblHoaDonTableAdapter();
            this.TienTeObjBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tblThongTinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblChiTietHoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TienTeObjBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tblThongTinBindingSource
            // 
            this.tblThongTinBindingSource.DataMember = "tblThongTin";
            this.tblThongTinBindingSource.DataSource = this.dataReport;
            // 
            // dataReport
            // 
            this.dataReport.DataSetName = "dataReport";
            this.dataReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblChiTietHoaDonBindingSource
            // 
            this.tblChiTietHoaDonBindingSource.DataMember = "tblChiTietHoaDon";
            this.tblChiTietHoaDonBindingSource.DataSource = this.dataReport;
            // 
            // tblHoaDonBindingSource
            // 
            this.tblHoaDonBindingSource.DataMember = "tblHoaDon";
            this.tblHoaDonBindingSource.DataSource = this.dataReport;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "MrLong_QLCaffe_layerObject_TienTeObj";
            reportDataSource1.Value = this.TienTeObjBindingSource;
            reportDataSource2.Name = "dataReport_tblThongTin";
            reportDataSource2.Value = this.tblThongTinBindingSource;
            reportDataSource3.Name = "dataReport_tblChiTietHoaDon";
            reportDataSource3.Value = this.tblChiTietHoaDonBindingSource;
            reportDataSource4.Name = "dataReport_tblHoaDon";
            reportDataSource4.Value = this.tblHoaDonBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MrLong_QLCaffe.report.rptHoaDon.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(742, 491);
            this.reportViewer1.TabIndex = 0;
            // 
            // tblThongTinTableAdapter
            // 
            this.tblThongTinTableAdapter.ClearBeforeFill = true;
            // 
            // tblChiTietHoaDonTableAdapter
            // 
            this.tblChiTietHoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // tblHoaDonTableAdapter
            // 
            this.tblHoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // TienTeObjBindingSource
            // 
            this.TienTeObjBindingSource.DataSource = typeof(MrLong_QLCaffe.layerObject.TienTeObj);
            // 
            // rptHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 491);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rptHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn";
            this.Load += new System.EventHandler(this.rptHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblThongTinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblChiTietHoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TienTeObjBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TienTeObjBindingSource;
        private System.Windows.Forms.BindingSource tblThongTinBindingSource;
        private dataReport dataReport;
        private System.Windows.Forms.BindingSource tblChiTietHoaDonBindingSource;
        private MrLong_QLCaffe.report.dataReportTableAdapters.tblThongTinTableAdapter tblThongTinTableAdapter;
        private MrLong_QLCaffe.report.dataReportTableAdapters.tblChiTietHoaDonTableAdapter tblChiTietHoaDonTableAdapter;
        private System.Windows.Forms.BindingSource tblHoaDonBindingSource;
        private MrLong_QLCaffe.report.dataReportTableAdapters.tblHoaDonTableAdapter tblHoaDonTableAdapter;
    }
}