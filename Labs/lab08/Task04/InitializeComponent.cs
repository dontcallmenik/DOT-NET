private void InitializeComponent()
{
	this.Text = "Профиль пользователя";
	this.Size = new System.Drawing.Size(400, 300);

	// Заголовок
	Label lblTitle = new Label();
	lblTitle.Text = "Профиль пользователя";
	lblTitle.Font = new Font("Arial", 16, FontStyle.Bold);
	lblTitle.TextAlign = ContentAlignment.MiddleCenter;
	lblTitle.Size = new Size(300, 30);
	lblTitle.Location = new Point(50, 20);
	this.Controls.Add(lblTitle);

	// Поле для имени
	Label lblName = new Label();
	lblName.Text = "Имя:";
	lblName.Location = new Point(50, 70);
	this.Controls.Add(lblName);

	TextBox txtName = new TextBox();
	txtName.Name = "txtName";
	txtName.Size = new Size(200, 20);
	txtName.Location = new Point(150, 70);
	this.Controls.Add(txtName);

	// Поле для email
	Label lblEmail = new Label();
	lblEmail.Text = "Email:";
	lblEmail.Location = new Point(50, 110);
	this.Controls.Add(lblEmail);

	TextBox txtEmail = new TextBox();
	txtEmail.Name = "txtEmail";
	txtEmail.Size = new Size(200, 20);
	txtEmail.Location = new Point(150, 110);
	this.Controls.Add(txtEmail);

	// Поле для пароля
	Label lblPassword = new Label();
	lblPassword.Text = "Пароль:";
	lblPassword.Location = new Point(50, 150);
	this.Controls.Add(lblPassword);

	TextBox txtPassword = new TextBox();
	txtPassword.Name = "txtPassword";
	txtPassword.PasswordChar = '*';
	txtPassword.Size = new Size(200, 20);
	txtPassword.Location = new Point(150, 150);
	this.Controls.Add(txtPassword);

	// Кнопка "Сохранить"
	Button btnSave = new Button();
	btnSave.Text = "Сохранить";
	btnSave.Name = "btnSave";
	btnSave.Size = new Size(100, 30);
	btnSave.Location = new Point(50, 200);
	btnSave.Click += btnSave_Click;
	this.Controls.Add(btnSave);

	// Кнопка "Отмена"
	Button btnCancel = new Button();
	btnCancel.Text = "Отмена";
	btnCancel.Name = "btnCancel";
	btnCancel.Size = new Size(100, 30);
	btnCancel.Location = new Point(200, 200);
	btnCancel.Click += btnCancel_Click;
	this.Controls.Add(btnCancel);
}
