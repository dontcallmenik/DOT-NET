using System;
using System.Drawing;
using System.Windows.Forms;

namespace UserMessageApp
{
    public partial class SplashForm : Form
    {
        private PictureBox pictureBoxLogo;
        private Label labelTitle;

        public SplashForm()
        {
            InitializeComponent();
            CreateDesign();
        }

        private void CreateDesign()
        {
            // Инициализация PictureBox для логотипа
            pictureBoxLogo = new PictureBox();
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(200, 200);
            pictureBoxLogo.Location = new Point((this.ClientSize.Width - pictureBoxLogo.Width) / 2, 50);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.Image = Properties.Resources.Logo; // Замените на свой логотип

            // Инициализация Label для названия системы
            labelTitle = new Label();
            labelTitle.Name = "labelTitle";
            labelTitle.Text = "Название системы";
            labelTitle.Font = new Font("Arial", 20, FontStyle.Bold);
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            labelTitle.Size = new Size(this.ClientSize.Width, 50);
            labelTitle.Location = new Point(0, pictureBoxLogo.Bottom + 10);

            // Добавление элементов на форму
            this.Controls.Add(pictureBoxLogo);
            this.Controls.Add(labelTitle);
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            // Пауза на 3 секунды
            System.Threading.Thread.Sleep(3000);
            var loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
