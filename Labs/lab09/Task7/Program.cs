using System;
using System.Windows.Forms;
using PhotoApp;  // ������ ����, � ����� ����������� Form1

namespace Task7
{
    static class Program
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

