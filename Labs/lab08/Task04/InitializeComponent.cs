private void InitializeComponent()
{
	this.Text = "������� ������������";
	this.Size = new System.Drawing.Size(400, 300);

	// ���������
	Label lblTitle = new Label();
	lblTitle.Text = "������� ������������";
	lblTitle.Font = new Font("Arial", 16, FontStyle.Bold);
	lblTitle.TextAlign = ContentAlignment.MiddleCenter;
	lblTitle.Size = new Size(300, 30);
	lblTitle.Location = new Point(50, 20);
	this.Controls.Add(lblTitle);

	// ���� ��� �����
	Label lblName = new Label();
	lblName.Text = "���:";
	lblName.Location = new Point(50, 70);
	this.Controls.Add(lblName);

	TextBox txtName = new TextBox();
	txtName.Name = "txtName";
	txtName.Size = new Size(200, 20);
	txtName.Location = new Point(150, 70);
	this.Controls.Add(txtName);

	// ���� ��� email
	Label lblEmail = new Label();
	lblEmail.Text = "Email:";
	lblEmail.Location = new Point(50, 110);
	this.Controls.Add(lblEmail);

	TextBox txtEmail = new TextBox();
	txtEmail.Name = "txtEmail";
	txtEmail.Size = new Size(200, 20);
	txtEmail.Location = new Point(150, 110);
	this.Controls.Add(txtEmail);

	// ���� ��� ������
	Label lblPassword = new Label();
	lblPassword.Text = "������:";
	lblPassword.Location = new Point(50, 150);
	this.Controls.Add(lblPassword);

	TextBox txtPassword = new TextBox();
	txtPassword.Name = "txtPassword";
	txtPassword.PasswordChar = '*';
	txtPassword.Size = new Size(200, 20);
	txtPassword.Location = new Point(150, 150);
	this.Controls.Add(txtPassword);

	// ������ "���������"
	Button btnSave = new Button();
	btnSave.Text = "���������";
	btnSave.Name = "btnSave";
	btnSave.Size = new Size(100, 30);
	btnSave.Location = new Point(50, 200);
	btnSave.Click += btnSave_Click;
	this.Controls.Add(btnSave);

	// ������ "������"
	Button btnCancel = new Button();
	btnCancel.Text = "������";
	btnCancel.Name = "btnCancel";
	btnCancel.Size = new Size(100, 30);
	btnCancel.Location = new Point(200, 200);
	btnCancel.Click += btnCancel_Click;
	this.Controls.Add(btnCancel);
}
