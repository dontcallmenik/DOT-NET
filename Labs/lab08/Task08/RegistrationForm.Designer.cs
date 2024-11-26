using System.Drawing;
using System.Windows.Forms;

public partial class RegistrationForm : Form
{
    public RegistrationForm()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        // Настройка формы
        this.Text = "Регистрация";
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

        // Email
        Label lblEmail = new Label();
        lblEmail.Text = "Email:";
        lblEmail.Location = new Point(30, 120);
        TextBox txtEmail = new TextBox();
        txtEmail.Location = new Point(120, 120);
        txtEmail.Width = 200;

        // Кнопка регистрации
        Button btnRegister = new Button();
        btnRegister.Text = "Зарегистрироваться";
        btnRegister.Location = new Point(120, 160);
        btnRegister.Click += (sender, e) =>
        {
            // Логика регистрации
            MessageBox.Show("Регистрация успешна!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            ShowLoginForm();
        };

        // Добавление элементов на форму
        this.Controls.Add(lblUsername);
        this.Controls.Add(txtUsername);
        this.Controls.Add(lblPassword);
        this.Controls.Add(txtPassword);
        this.Controls.Add(lblEmail);
        this.Controls.Add(txtEmail);
        this.Controls.Add(btnRegister);
    }

    private void ShowLoginForm()
    {
        var loginForm = new LoginForm();
        loginForm.Show();
    }
}
