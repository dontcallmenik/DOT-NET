using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HotKeysForm
{
    public partial class Form1 : Form
    {
        private TextBox textBox1; // Объявляем поле textBox1

        public Form1()
        {
            InitializeComponent();

            // Инициализация textBox1
            textBox1 = new TextBox(); // Создаем экземпляр textBox1
            textBox1.Location = new Point(50, 50);
            textBox1.Size = new Size(200, 30);
            this.Controls.Add(textBox1); // Добавляем TextBox на форму

            // Регистрация горячей клавиши для добавления кнопки
            RegisterHotKey(this.Handle, 1, 0, Keys.Control | Keys.D);

            // Обработка нажатия горячей клавиши
            this.KeyDown += Form1_KeyDown; // Можно убрать new KeyEventHandler
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new Size(300, 200);
            this.Name = "Form1";
            this.Text = "Hotkeys Example";
            this.ResumeLayout(false);
        }

        private void Form1_KeyDown(object? sender, KeyEventArgs e) // Добавлено "?" для sender
        {
            // Проверка нажатия сочетания Ctrl + D
            if (e.Control && e.KeyCode == Keys.D)
            {
                // Добавление кнопки на форму
                Button button = new Button();
                button.Text = "Button";
                button.Location = new Point(10, 10);
                this.Controls.Add(button);
            }
        }

        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, Keys vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        // Освобождение горячей клавиши при закрытии формы
        protected override void Dispose(bool disposing)
        {
            UnregisterHotKey(this.Handle, 1);
            base.Dispose(disposing);
        }
    }
}
