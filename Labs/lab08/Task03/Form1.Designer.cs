using System.Drawing;

private void InitializeComponent()
{
    // Заголовок
    Label lblTitle = new Label();
    lblTitle.Text = "Авторизация";
    lblTitle.Font = new Font("Arial", 16, FontStyle.Bold);
    lblTitle.TextAlign = ContentAlignment.MiddleCenter;
    lblTitle.Size = new Size(300, 30);
    lblTitle.Location = new Point(100, 20);
    this.Controls.Add(lblTitle);

    // Логин
    Label lblUsername = new Label();
    lblUsername.Text = "Логин";
    lblUsername.Location = new Point(50, 75);
    this.Controls.Add(lblUsername);

    TextBox txtUsername = new TextBox();
    txtUsername.Name = "txtUsername";
    txtUsername.PlaceholderText = "Введите логин";
    txtUsername.Size = new Size(200, 20);
    txtUsername.Location = new Point(100, 70);
    this.Controls.Add(txtUsername);

    // Пароль
    Label lblPassword = new Label();
    lblPassword.Text = "Пароль";
    lblPassword.Location = new Point(50, 125);
    this.Controls.Add(lblPassword);

    TextBox txtPassword = new TextBox();
    txtPassword.Name = "txtPassword";
    txtPassword.PasswordChar = '*';
    txtPassword.PlaceholderText = "Введите пароль";
    txtPassword.Size = new Size(200, 20);
    txtPassword.Location = new Point(100, 120);
    this.Controls.Add(txtPassword);

    // Кнопка Войти
    Button btnLogin = new Button();
    btnLogin.Text = "Войти";
    btnLogin.Name = "btnLogin";
    btnLogin.Size = new Size(100, 30);
    btnLogin.Location = new Point(150, 170);
    btnLogin.Click += btnLogin_Click;
    this.Controls.Add(btnLogin);

    // Метка для ошибок
    Label lblError = new Label();
    lblError.Name = "lblError";
    lblError.Text = "";
    lblError.ForeColor = Color.Red;
    lblError.Font = new Font("Arial", 10, FontStyle.Bold);
    lblError.Visible = false;
    lblError.Location = new Point(100, 210);
    this.Controls.Add(lblError);

    // Настройка формы
    this.Text = "Авторизация";
    this.Size = new Size(400, 300);
}
