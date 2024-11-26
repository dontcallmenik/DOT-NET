using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace UserMessageApp
{
    public partial class MessageForm : Form
    {
        private const string MessagesFilePath = "messages.txt"; // Путь к файлу для сохранения сообщений

        public MessageForm()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string recipient = txtTo.Text.Trim();
            string theme = txtTheme.Text.Trim();
            string text = txtText.Text.Trim();

            // Проверка на заполнение полей
            if (string.IsNullOrWhiteSpace(recipient) || string.IsNullOrWhiteSpace(theme) || string.IsNullOrWhiteSpace(text))
            {
                MessageBox.Show("Заполните все поля перед отправкой сообщения!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Формируем строку сообщения
            string message = $"To: {recipient}\nTheme: {theme}\nText: {text}\n---\n";

            // Сохраняем сообщение в файл
            try
            {
                File.AppendAllText(MessagesFilePath, message);
                MessageBox.Show("Сообщение успешно отправлено и сохранено!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Очищаем поля после отправки
                txtTo.Text = "";
                txtTheme.Text = "";
                txtText.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении сообщения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
