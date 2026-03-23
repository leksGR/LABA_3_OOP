using System;
using System.Windows.Forms;
using WinFormsApp_OOP_Lab3_Singleton.Forms;
using WinFormsApp_OOP_Lab3_Singleton;

namespace WinFormsApp_OOP_Lab3_Singleton
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}