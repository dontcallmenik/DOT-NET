using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace UserMessageApp
{
    public partial class MessageForm : Form
    {
        private TextBox txtRecipient;
        private TextBox txtTheme;
        private TextBox txtMessage;
        private Button btnSend;

        public MessageForm()
        {
            InitializeComponent();
            CreateDesign();
        }

        private void CreateDesign()
        {
            // Инициализация TextBox для получателя
            txtRecipient = new TextBox();
            txtRecipient.Name = "txtRecipient";
            txtRecipient.PlaceholderText = "Введите получателя";
            txtRecipient.Location = new Point(50, 50);
            txtRecipient.Width = 200;

            // Инициализация TextBox для темы
            txtTheme = new TextBox();
            txtTheme.Name = "txtTheme";
            txtTheme.PlaceholderText = "Введите тему";
            txtTheme.Location = new Point(50, 100);
            txtTheme.Width = 200;

            // Инициализация TextBox для текста сообщения
            txtMessage = new TextBox();
            txtMessage.Name = "txtMessage";
            txtMessage.PlaceholderText = "Введите сообщение";
            txtMessage.Location = new Point(50, 150);
            txtMessage.Width = 200;
            txtMessage.Multiline = true;
            txtMessage.Height = 100;

            // Инициализация Button для отправки сообщения
            btnSend = new Button();
            btnSend.Name = "btnSend";
            btnSend.Text = "Отправить сообщение";
            btnSend.Location = new Point(50, 270);
            btnSend.Click += BtnSend_Click;

            // Добавление элементов на форму
            this.Controls.Add(txtRecipient);
            this.Controls.Add(txtTheme);
            this.Controls.Add(txtMessage);
            this.Controls.Add(btnSend);
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            string recipient = txtRecipient.Text;
            string theme = txtTheme.Text;
            string message = txtMessage.Text;

            if (!string.IsNullOrWhiteSpace(recipient) && !string.IsNullOrWhiteSpace(message))
            {
                string fullMessage = $"To: {recipient}\nTheme: {theme}\nMessage: {message}\n---";
                File.AppendAllText("messages.txt", fullMessage + Environment.NewLine);
                MessageBox.Show("Сообщение отправлено!", "Успех");
            }
            else
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка");
            }
        }
    }
}
