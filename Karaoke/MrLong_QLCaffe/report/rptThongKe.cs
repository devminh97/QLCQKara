using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MrLong_QLCaffe.report
{
    public partial class rptThongKe : Form
    {
        public rptThongKe()
        {
            InitializeComponent();
        }

        private void rptThongKe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kARAOKEDataSet.ThongKe' table. You can move, or remove it, as needed.
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.thongKeTableAdapter.Fill(this.kARAOKEDataSet.ThongKe, bd.Value, kt.Value);
            this.reportViewer1.RefreshReport();
        }

    }
}
