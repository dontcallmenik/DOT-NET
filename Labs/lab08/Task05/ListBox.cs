using System;
using System.IO;
using System.Windows.Forms;

namespace UserMessageApp
{
    public partial class ReceivedMessagesForm : Form
    {
        private const string MessagesFilePath = "messages.txt";

        public ReceivedMessagesForm()
        {
            InitializeComponent();
            LoadMessages();
        }

        private void LoadMessages()
        {
            if (File.Exists(MessagesFilePath))
            {
                string[] messages = File.ReadAllLines(MessagesFilePath);
                foreach (string message in messages)
                {
                    lstMessages.Items.Add(message);
                }
            }
            else
            {
                MessageBox.Show("Файл сообщений не найден!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
