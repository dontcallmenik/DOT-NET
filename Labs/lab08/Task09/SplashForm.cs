using System;
using System.Windows.Forms;

namespace UserMessageApp
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        // Конструктор для быстрого перехода на форму авторизации
        private void SplashForm_Load(object sender, EventArgs e)
        {
            // Пауза на 3 секунды
            System.Threading.Thread.Sleep(3000);
            var loginForm = new LoginForm(); // Переключаемся на форму авторизации
            loginForm.Show();
            this.Hide();
        }
    }
}
