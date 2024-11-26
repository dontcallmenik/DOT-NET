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
        }

        private void ReceivedMessagesForm_Load(object sender, EventArgs e)
        {
            // Загружаем список сообщений из файла
            string filePath = "messages.txt"; // Файл с сообщениями
            if (File.Exists(filePath))
            {
                string[] messages = File.ReadAllLines(filePath);
                lstMessages.Items.AddRange(messages);
            }
            else
            {
                MessageBox.Show("Сообщений пока нет.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnViewMessage_Click(object sender, EventArgs e)
        {
            if (lstMessages.SelectedItem != null)
            {
                // Открываем форму просмотра сообщения
                string selectedMessage = lstMessages.SelectedItem.ToString();
                var viewMessageForm = new ViewMessageForm(selectedMessage);
                viewMessageForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите сообщение.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

}
