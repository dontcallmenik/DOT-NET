using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace UserMessageApp
{
    public partial class ReceivedMessagesForm : Form
    {
        private ListBox lstMessages;
        private Button btnViewMessage;

        public ReceivedMessagesForm()
        {
            InitializeComponent();
            CreateDesign();
            LoadMessages();
        }

        private void CreateDesign()
        {
            // Инициализация ListBox для сообщений
            lstMessages = new ListBox();
            lstMessages.Name = "lstMessages";
            lstMessages.Location = new Point(50, 50);
            lstMessages.Width = 400;
            lstMessages.Height = 200;

            // Инициализация Button для просмотра сообщения
            btnViewMessage = new Button();
            btnViewMessage.Name = "btnViewMessage";
            btnViewMessage.Text = "Просмотреть сообщение";
            btnViewMessage.Location = new Point(50, 270);
            btnViewMessage.Click += BtnViewMessage_Click;

            // Добавление элементов на форму
            this.Controls.Add(lstMessages);
            this.Controls.Add(btnViewMessage);
        }

        private void LoadMessages()
        {
            if (File.Exists("messages.txt"))
            {
                var messages = File.ReadAllLines("messages.txt");
                lstMessages.Items.AddRange(messages);
            }
        }

        private void BtnViewMessage_Click(object sender, EventArgs e)
        {
            if (lstMessages.SelectedItem != null)
            {
                MessageBox.Show(lstMessages.SelectedItem.ToString(), "Сообщение");
            }
            else
            {
                MessageBox.Show("Выберите сообщение для просмотра.", "Ошибка");
            }
        }
    }
}
