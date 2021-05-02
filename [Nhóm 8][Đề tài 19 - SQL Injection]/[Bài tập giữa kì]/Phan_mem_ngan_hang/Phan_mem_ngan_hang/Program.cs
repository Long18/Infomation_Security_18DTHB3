using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;

namespace Phan_mem_ngan_hang
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
            Dang_Nhap_Nhan_Vien fromdangnhap = new Dang_Nhap_Nhan_Vien();

            Application.Run(fromdangnhap);
            if(fromdangnhap.Islogin== true)
            {
                Application.Run(new Dang_Nhap_Nhan_Vien());
            }

        }
    }
}
