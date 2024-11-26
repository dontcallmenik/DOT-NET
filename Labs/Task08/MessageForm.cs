using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public partial class MessageForm : Form
{
    public MessageForm()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        throw new NotImplementedException();
    }

    private void btnSend_Click(object sender, EventArgs e)
    {
        string recipient = txtRecipient.Text;
        string theme = txtTheme.Text;
        string messageText = txtMessage.Text;

        if (!string.IsNullOrWhiteSpace(recipient) && !string.IsNullOrWhiteSpace(messageText))
        {
            // Сохранение сообщения в файл
            string fullMessage = $"To: {recipient}\nTheme: {theme}\nMessage: {messageText}\n---";
            File.AppendAllText("messages.txt", fullMessage + Environment.NewLine);

            MessageBox.Show("Сообщение отправлено!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            ShowReceivedMessagesForm(); // Переход к форме получения сообщений
        }
        else
        {
            MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void ShowReceivedMessagesForm()
    {
        var receivedMessagesForm = new ReceivedMessagesForm(); // Открытие формы получения сообщений
        receivedMessagesForm.Show();
    }
}
