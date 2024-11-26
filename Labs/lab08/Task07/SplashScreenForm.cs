using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace UserMessageApp
{
    public partial class SplashScreenForm : Form
    {
        public SplashScreenForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            // Настройка формы
            this.Text = "Заставка";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(500, 300); // Размеры окна

            // Фон заставки
            this.BackColor = Color.White;

            // Логотип (вы можете использовать собственный логотип)
            PictureBox logo = new PictureBox();
            logo.Image = Properties.Resources.Logo;  // Добавьте свой логотип в проект через ресурсы
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.Dock = DockStyle.Top;
            logo.Height = 150;

            // Название системы
            Label lblTitle = new Label();
            lblTitle.Text = "Условная система";
            lblTitle.Font = new Font("Arial", 24, FontStyle.Bold);
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Dock = DockStyle.Fill;

            // Добавление элементов на форму
            this.Controls.Add(lblTitle);
            this.Controls.Add(logo);

            // Таймер для закрытия заставки через 3 секунды
            Timer timer = new Timer();
            timer.Interval = 3000;  // 3000 миллисекунд (3 секунды)
            timer.Tick += (sender, e) =>
            {
                timer.Stop();  // Останавливаем таймер
                this.Close();  // Закрываем заставку
                ShowMainForm(); // Показываем основную форму
            };
            timer.Start();
        }

        // Открытие основной формы
        private void ShowMainForm()
        {
            Form mainForm = new MainForm(); // Замените на вашу основную форму
            mainForm.Show();
        }
    }
}
