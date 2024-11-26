using System.Drawing;
using System.Windows.Forms;

public partial class LoginForm : Form
{
    public LoginForm()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        // Настройка формы
        this.Text = "Авторизация";
        this.Size = new Size(400, 250);
        this.StartPosition = FormStartPosition.CenterScreen;

        // Логин
        Label lblUsername = new Label();
        lblUsername.Text = "Логин:";
        lblUsername.Location = new Point(30, 40);
        TextBox txtUsername = new TextBox();
        txtUsername.Location = new Point(120, 40);
        txtUsername.Width = 200;

        // Пароль
        Label lblPassword = new Label();
        lblPassword.Text = "Пароль:";
        lblPassword.Location = new Point(30, 80);
        TextBox txtPassword = new TextBox();
        txtPassword.Location = new Point(120, 80);
        txtPassword.Width = 200;
        txtPassword.PasswordChar = '*';

        // Кнопка входа
        Button btnLogin = new Button();
        btnLogin.Text = "Войти";
        btnLogin.Location = new Point(120, 120);
        btnLogin.Click += (sender, e) =>
        {
            // Логика авторизации
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == "admin" && password == "password") // Пример проверки
            {
                this.Close();
                ShowProfileForm();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        };

        // Добавление элементов на форму
        this.Controls.Add(lblUsername);
        this.Controls.Add(txtUsername);
        this.Controls.Add(lblPassword);
        this.Controls.Add(txtPassword);
        this.Controls.Add(btnLogin);
    }

    private void ShowProfileForm()
    {
        var profileForm = new ProfileForm();
        profileForm.Show();
    }
}
