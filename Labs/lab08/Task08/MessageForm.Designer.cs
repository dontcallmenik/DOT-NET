using System.Drawing;
using System.Windows.Forms;

public partial class MessageForm : Form
{
    public MessageForm()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        // Настройка формы
        this.Text = "Отправка сообщения";
        this.Size = new Size(400, 300);
        this.StartPosition = FormStartPosition.CenterScreen;

        // Получатель
        Label lblRecipient = new Label();
        lblRecipient.Text = "Получатель:";
        lblRecipient.Location = new Point(30, 40);
        TextBox txtRecipient = new TextBox();
        txtRecipient.Location = new Point(120, 40);
        txtRecipient.Width = 200;

        // Тема
        Label lblTheme = new Label();
        lblTheme.Text = "Тема:";
        lblTheme.Location = new Point(30, 80);
        TextBox txtTheme = new TextBox();
        txtTheme.Location = new Point(120, 80);
        txtTheme.Width = 200;

        // Сообщение
        Label lblMessage = new Label();
        lblMessage.Text = "Сообщение:";
        lblMessage.Location = new Point(30, 120);
        TextBox txtMessage = new TextBox();
        txtMessage.Location = new Point(120, 120);
        txtMessage.Width = 200;
        txtMessage.Height = 100;
        txtMessage.Multiline = true;

        // Кнопка отправки
        Button btnSend = new Button();
        btnSend.Text = "Отправить";
        btnSend.Location = new Point(120, 240);
        btnSend.Click += (sender, e) =>
        {
            // Логика отправки сообщения
            MessageBox.Show("Сообщение отправлено!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ShowReceivedMessagesForm();
        };

        // Добавление элементов на форму
        this.Controls.Add(lblRecipient);
        this.Controls.Add(txtRecipient);
        this.Controls.Add(lblTheme);
        this.Controls.Add(txtTheme);
        this.Controls.Add(lblMessage);
        this.Controls.Add(txtMessage);
        this.Controls.Add(btnSend);
    }

    private void ShowReceivedMessagesForm()
    {
        var receivedMessagesForm = new ReceivedMessagesForm();
        receivedMessagesForm.Show();
    }
}
