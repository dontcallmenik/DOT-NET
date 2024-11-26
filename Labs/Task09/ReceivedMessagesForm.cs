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
    public partial class ReceivedMessagesForm : Form
    {
        public ReceivedMessagesForm()
        {
            InitializeComponent();
            LoadMessages();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void LoadMessages()
        {
            if (File.Exists("messages.txt"))
            {
                string[] messages = File.ReadAllLines("messages.txt");
                foreach (string message in messages)
                {
                    if (!string.IsNullOrWhiteSpace(message))
                    {
                        lstMessages.Items.Add(message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Сообщения не найдены.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnViewMessage_Click(object sender, EventArgs e)
        {
            string selectedMessage = lstMessages.SelectedItem?.ToString();
            if (selectedMessage != null)
            {
                var viewMessageForm = new ViewMessageForm(selectedMessage);
                viewMessageForm.Show();
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите сообщение.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
