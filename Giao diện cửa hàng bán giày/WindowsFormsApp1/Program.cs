using DoAn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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
            //Application.Run(new Form1());
            //Application.Run(new GiaoDienDoanhThu());
            //Application.Run(new GiaoDienQuanLyKhachHangChoNhanVien());
            //Application.Run(new GiaoDienAD());
            Application.Run(new QuanLyNhanVien());
        }
    }
}
