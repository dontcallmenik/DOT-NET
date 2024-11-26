using System.Drawing;
using System.Windows.Forms;

public partial class ProfileForm : Form
{
    public ProfileForm()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        // Настройка формы
        this.Text = "Профиль пользователя";
        this.Size = new Size(400, 250);
        this.StartPosition = FormStartPosition.CenterScreen;

        // Имя
        Label lblName = new Label();
        lblName.Text = "Имя:";
        lblName.Location = new Point(30, 40);
        TextBox txtName = new TextBox();
        txtName.Location = new Point(120, 40);
        txtName.Width = 200;

        // Email
        Label lblEmail = new Label();
        lblEmail.Text = "Email:";
        lblEmail.Location = new Point(30, 80);
        TextBox txtEmail = new TextBox();
        txtEmail.Location = new Point(120, 80);
        txtEmail.Width = 200;

        // Кнопка сохранения
        Button btnSaveProfile = new Button();
        btnSaveProfile.Text = "Сохранить";
        btnSaveProfile.Location = new Point(120, 120);
        btnSaveProfile.Click += (sender, e) =>
        {
            // Логика сохранения профиля
            MessageBox.Show("Данные профиля сохранены.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ShowMessageForm();
        };

        // Добавление элементов на форму
        this.Controls.Add(lblName);
        this.Controls.Add(txtName);
        this.Controls.Add(lblEmail);
        this.Controls.Add(txtEmail);
        this.Controls.Add(btnSaveProfile);
    }

    private void ShowMessageForm()
    {
        var messageForm = new MessageForm();
        messageForm.Show();
    }
}
