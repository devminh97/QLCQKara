using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MrLong_QLCaffe.report;

namespace MrLong_QLCaffe
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
       //   Application.Run(new report.rptThongKe());
         
        }
    }
}
