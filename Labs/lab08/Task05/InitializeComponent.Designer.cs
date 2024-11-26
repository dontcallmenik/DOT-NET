private void InitializeComponent()
{
    this.Text = "Отправка сообщения";
    this.Size = new System.Drawing.Size(400, 400);

    // Поле "Кому"
    Label lblTo = new Label();
    lblTo.Text = "Кому:";
    lblTo.Location = new Point(30, 30);
    this.Controls.Add(lblTo);

    TextBox txtTo = new TextBox();
    txtTo.Name = "txtTo";
    txtTo.Size = new Size(300, 20);
    txtTo.Location = new Point(100, 30);
    this.Controls.Add(txtTo);

    // Поле "Тема"
    Label lblTheme = new Label();
    lblTheme.Text = "Тема:";
    lblTheme.Location = new Point(30, 80);
    this.Controls.Add(lblTheme);

    TextBox txtTheme = new TextBox();
    txtTheme.Name = "txtTheme";
    txtTheme.Size = new Size(300, 20);
    txtTheme.Location = new Point(100, 80);
    this.Controls.Add(txtTheme);

    // Поле "Текст"
    Label lblText = new Label();
    lblText.Text = "Текст:";
    lblText.Location = new Point(30, 130);
    this.Controls.Add(lblText);

    TextBox txtText = new TextBox();
    txtText.Name = "txtText";
    txtText.Multiline = true;
    txtText.Size = new Size(300, 150);
    txtText.Location = new Point(100, 130);
    this.Controls.Add(txtText);

    // Кнопка "Отправить"
    Button btnSend = new Button();
    btnSend.Text = "Отправить";
    btnSend.Size = new Size(100, 30);
    btnSend.Location = new Point(100, 300);
    btnSend.Click += btnSend_Click;
    this.Controls.Add(btnSend);

    // Кнопка "Отмена"
    Button btnCancel = new Button();
    btnCancel.Text = "Отмена";
    btnCancel.Size = new Size(100, 30);
    btnCancel.Location = new Point(250, 300);
    btnCancel.Click += btnCancel_Click;
    this.Controls.Add(btnCancel);
}