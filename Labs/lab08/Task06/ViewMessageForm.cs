using System.Windows.Forms;
using System;

private void btnSend_Click(object sender, EventArgs e)
{
    string recipient = txtRecipient.Text; // Поле для ввода получателя
    string theme = txtTheme.Text; // Поле для темы сообщения
    string messageText = txtMessage.Text; // Поле для текста сообщения

    if (!string.IsNullOrWhiteSpace(recipient) && !string.IsNullOrWhiteSpace(messageText))
    {
        // Формируем строку для сохранения
        string fullMessage = $"To: {recipient}\nTheme: {theme}\nMessage: {messageText}\n---";

        // Сохраняем в файл
        File.AppendAllText("messages.txt", fullMessage + Environment.NewLine);

        MessageBox.Show("Сообщение отправлено!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

        // Очистка полей
        txtRecipient.Clear();
        txtTheme.Clear();
        txtMessage.Clear();
    }
    else
    {
        MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
}
