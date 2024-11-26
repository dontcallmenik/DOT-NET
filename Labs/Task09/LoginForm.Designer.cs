using System;
using System.Drawing;
using System.Windows.Forms;

namespace UserMessageApp
{
    public partial class LoginForm : Form
    {
        private TextBox txtLogin;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label lblError;

        public LoginForm()
        {
            InitializeComponent();
            CreateDesign();
        }

        private void CreateDesign()
        {
            // Инициализация TextBox для логина
            txtLogin = new TextBox();
            txtLogin.Name = "txtLogin";
            txtLogin.PlaceholderText = "Введите логин";
            txtLogin.Location = new Point(50, 50);
            txtLogin.Width = 200;

            // Инициализация TextBox для пароля
            txtPassword = new TextBox();
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Введите пароль";
            txtPassword.Location = new Point(50, 100);
            txtPassword.Width = 200;
            txtPassword.PasswordChar = '*';

            // Инициализация Button для входа
            btnLogin = new Button();
            btnLogin.Name = "btnLogin";
            btnLogin.Text = "Войти";
            btnLogin.Location = new Point(50, 150);
            btnLogin.Click += BtnLogin_Click;

            // Инициализация Label для отображения ошибок
            lblError = new Label();
            lblError.Name = "lblError";
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(50, 200);
            lblError.Size = new Size(200, 20);

            // Добавление элементов на форму
            this.Controls.Add(txtLogin);
            this.Controls.Add(txtPassword);
            this.Controls.Add(btnLogin);
            this.Controls.Add(lblError);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "admin" && txtPassword.Text == "password")
            {
                var profileForm = new ProfileForm();
                profileForm.Show();
                this.Hide();
            }
            else
            {
                lblError.Text = "Неверный логин или пароль!";
            }
        }
    }
}
