using System.Drawing;
using System.Windows.Forms;

public partial class SplashScreenForm : Form
{
    public SplashScreenForm()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        // Настройка формы заставки
        this.Text = "Заставка";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Size = new Size(500, 300);

        // Логотип
        PictureBox logo = new PictureBox();
        logo.Image = Properties.Resources.Logo; // Логотип из ресурсов
        logo.SizeMode = PictureBoxSizeMode.Zoom;
        logo.Dock = DockStyle.Top;
        logo.Height = 150;

        // Название системы
        Label lblTitle = new Label();
        lblTitle.Text = "Условная система";
        lblTitle.Font = new Font("Arial", 24, FontStyle.Bold);
        lblTitle.TextAlign = ContentAlignment.MiddleCenter;
        lblTitle.Dock = DockStyle.Fill;

        this.Controls.Add(lblTitle);
        this.Controls.Add(logo);

        // Таймер для перехода на авторизационную форму
        Timer timer = new Timer();
        timer.Interval = 3000; // 3 секунды
        timer.Tick += (sender, e) =>
        {
            timer.Stop();
            this.Close();
            ShowLoginForm(); // Переход к авторизационной форме
        };
        timer.Start();
    }

    private void ShowLoginForm()
    {
        var loginForm = new LoginForm();
        loginForm.Show();
    }
}
