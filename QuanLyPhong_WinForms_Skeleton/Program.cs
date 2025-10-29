using System;
using System.Windows.Forms;
using QuanLyPhong_WinForms_Skeleton.Forms;

namespace QuanLyPhong_WinForms_Skeleton
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmDangNhap());
        }
    }
}
