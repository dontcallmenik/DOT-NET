using System;
using System.IO;
using System.Windows.Forms;

namespace UserMessageApp
{
    public partial class MessageForm : Form
    {
        // Элементы управления для ввода данных
        private TextBox txtRecipient;
        private TextBox txtTheme;
        private TextBox txtMessage;
        private Button btnSend;

        public MessageForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            // Инициализация формы
            this.Text = "Отправка сообщения";
            this.Size = new System.Drawing.Size(400, 400);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Поле для ввода получателя
            txtRecipient = new TextBox();
            txtRecipient.Name = "txtRecipient";
            txtRecipient.PlaceholderText = "Получатель";
            txtRecipient.Dock = DockStyle.Top;
            txtRecipient.Height = 30;

            // Поле для ввода темы сообщения
            txtTheme = new TextBox();
            txtTheme.Name = "txtTheme";
            txtTheme.PlaceholderText = "Тема сообщения";
            txtTheme.Dock = DockStyle.Top;
            txtTheme.Height = 30;

            // Поле для ввода текста сообщения
            txtMessage = new TextBox();
            txtMessage.Name = "txtMessage";
            txtMessage.PlaceholderText = "Текст сообщения";
            txtMessage.Multiline = true;
            txtMessage.Dock = DockStyle.Fill;

            // Кнопка отправки сообщения
            btnSend = new Button();
            btnSend.Name = "btnSend";
            btnSend.Text = "Отправить";
            btnSend.Dock = DockStyle.Bottom;
            btnSend.Click += btnSend_Click;

            // Добавление элементов управления на форму
            this.Controls.Add(txtMessage);
            this.Controls.Add(txtTheme);
            this.Controls.Add(txtRecipient);
            this.Controls.Add(btnSend);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            // Получаем данные из полей ввода
            string recipient = txtRecipient.Text; // Поле для ввода получателя
            string theme = txtTheme.Text; // Поле для темы сообщения
            string messageText = txtMessage.Text; // Поле для текста сообщения

            // Проверяем, что все поля заполнены
            if (!string.IsNullOrWhiteSpace(recipient) && !string.IsNullOrWhiteSpace(messageText))
            {
                // Формируем строку для сохранения
                string fullMessage = $"To: {recipient}\nTheme: {theme}\nMessage: {messageText}\n---";

                // Сохраняем в файл
                File.AppendAllText("messages.txt", fullMessage + Environment.NewLine);

                // Информируем пользователя об успешной отправке
                MessageBox.Show("Сообщение отправлено!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Очищаем поля для нового ввода
                txtRecipient.Clear();
                txtTheme.Clear();
                txtMessage.Clear();
            }
            else
            {
                // Если одно из полей пустое, выводим ошибку
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
