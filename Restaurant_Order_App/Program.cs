using Restaurant_Order_App.Connection;
using Restaurant_Order_App.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Order_App
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            /*Connect connect = new Connect();
            connect.getConnect();
            MessageBox.Show("Hello");*/
            Application.Run(new FrmKhachHang());

            
        }
    }
}
