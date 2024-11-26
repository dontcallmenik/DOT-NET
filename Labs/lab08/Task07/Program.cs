using System;
using System.Windows.Forms;

namespace UserMessageApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Показываем заставку
            Application.Run(new SplashScreenForm());  // Заставка будет отображаться
        }
    }
}
