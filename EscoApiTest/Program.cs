using System;
using System.Windows.Forms;

namespace EscoApiTest
{
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmTest());
            //Application.Run(new frmFondosDemo());
            Application.Run(new frmDemoPpal());
        }
    }
}
