using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        [Obsolete]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new Home());
            //Application.Run(new Order());
            //Application.Run(new NhanVien());
            //Application.Run(new DienThongTin());
            Application.Run(new QuanLyNCC());
            Application.Run(new QuanLyKho());

        }
    }
}
