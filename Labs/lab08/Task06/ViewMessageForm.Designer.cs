using System;
using System.Windows.Forms;

namespace UserMessageApp
{
    public partial class ViewMessageForm : Form
    {
        // Элемент для отображения текста сообщения
        private Label lblMessage;

        public ViewMessageForm(string message)
        {
            // Инициализация компонентов
            InitializeComponent();

            // Устанавливаем текст сообщения в Label
            lblMessage.Text = message;
        }

        private void InitializeComponent()
        {
            // Инициализация формы
            this.Text = "Просмотр сообщения";
            this.Size = new System.Drawing.Size(400, 300);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Создание Label для отображения сообщения
            lblMessage = new Label();
            lblMessage.Name = "lblMessage";
            lblMessage.Dock = DockStyle.Fill;  // Занимает всю площадь формы
            lblMessage.AutoSize = false;  // Отключаем AutoSize, чтобы текст масштабировался по форме
            lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;  // Центрируем текст
            lblMessage.Font = new System.Drawing.Font("Arial", 10);  // Устанавливаем шрифт для читаемости
            lblMessage.Padding = new Padding(10);  // Добавляем отступы для текста

            // Добавление Label на форму
            this.Controls.Add(lblMessage);
        }
    }
}
