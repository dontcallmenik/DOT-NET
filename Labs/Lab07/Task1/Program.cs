using System;
using System.Windows.Forms;

namespace ButtonClickApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());  // Запускаємо Form1
        }
    }
}
