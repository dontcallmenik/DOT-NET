using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Windows.Forms;
using Task08;

namespace UserMessageApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Запуск заставки
            Application.Run(new SplashScreenForm());
        }
    }
}
