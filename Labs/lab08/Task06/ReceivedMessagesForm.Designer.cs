using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UserMessageApp
{
    public partial class ReceivedMessagesForm : Form
    {
        // Элементы управления
        private ListBox lstMessages;
        private Button btnViewMessage;

        public ReceivedMessagesForm()
        {
            // Инициализация формы
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            // Установка параметров формы
            this.Text = "Полученные сообщения";
            this.Size = new System.Drawing.Size(400, 300);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Создание ListBox для отображения сообщений
            lstMessages = new ListBox();
            lstMessages.Name = "lstMessages";
            lstMessages.Dock = DockStyle.Top;
            lstMessages.Height = 200;

            // Создание кнопки "Просмотреть сообщение"
            btnViewMessage = new Button();
            btnViewMessage.Name = "btnViewMessage";
            btnViewMessage.Text = "Просмотреть сообщение";
            btnViewMessage.Dock = DockStyle.Bottom;
            btnViewMessage.Click += BtnViewMessage_Click;

            // Добавление элементов управления на форму
            this.Controls.Add(lstMessages);
            this.Controls.Add(btnViewMessage);
        }

        // Обработчик кнопки "Просмотреть сообщение"
        private void BtnViewMessage_Click(object sender, EventArgs e)
        {
            if (lstMessages.SelectedItem != null)
            {
                string selectedMessage = lstMessages.SelectedItem.ToString();
                var viewMessageForm = new ViewMessageForm(selectedMessage);
                viewMessageForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите сообщение.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Загрузка сообщений (вызывается при открытии формы)
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // Загружаем список сообщений из файла
            string filePath = "messages.txt";
            if (System.IO.File.Exists(filePath))
            {
                string[] messages = System.IO.File.ReadAllLines(filePath);
                lstMessages.Items.AddRange(messages);
            }
            else
            {
                MessageBox.Show("Сообщений пока нет.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}