using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.IO;
using System.Windows.Forms;

namespace UserMessageApp
{
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
                string fullMessage = $"To: {recipient}\nTheme: {theme}\nMessage: {messageText}\n---";
                File.AppendAllText("messages.txt", fullMessage + Environment.NewLine);
                MessageBox.Show("Сообщение отправлено!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtRecipient.Clear();
                txtTheme.Clear();
                txtMessage.Clear();
            }
            else
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
