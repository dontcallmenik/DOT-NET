using System;
using System.Drawing;
using System.Windows.Forms;

namespace ButtonTransformations
{
    public partial class Form1 : Form
    {
        private Button[] buttons;

        public Form1()
        {
            InitializeComponent();
            buttons = new Button[3];

            // Создание кнопок с разными метками
            for (int i = 0; i < 3; i++)
            {
                buttons[i] = new Button();
                buttons[i].Text = $"Button {i + 1}";
                buttons[i].Location = new Point(10 + 100 * i, 100);
                buttons[i].Size = new Size(80, 30);

                // Привязка одного обработчика событий к каждой кнопке
                buttons[i].MouseEnter += Button_MouseEnter;
                buttons[i].MouseLeave += Button_MouseLeave;

                // Добавление кнопок на форму
                Controls.Add(buttons[i]);
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Name = "Form1";
            this.ResumeLayout(false);
        }

        private void Button_MouseEnter(object? sender, EventArgs e)
        {
            if (sender is Button button) // Проверяем, что sender - это кнопка
            {
                // Применение трансформации в зависимости от индекса кнопки
                int index = Array.IndexOf(buttons, button);
                switch (index)
                {
                    case 0:
                        // Увеличиваем размер кнопки на 4 пикселя
                        button.Size = new Size(button.Width + 4, button.Height + 4);
                        break;
                    case 1:
                        // Уменьшаем размер кнопки на 2 пикселя
                        button.Size = new Size(button.Width - 2, button.Height - 2);
                        break;
                    case 2:
                        // Перемещаем кнопку на 3 пикселя вправо
                        button.Location = new Point(button.Location.X + 3, button.Location.Y);
                        break;
                }
            }
        }

        private void Button_MouseLeave(object? sender, EventArgs e)
        {
            if (sender is Button button) // Проверяем, что sender - это кнопка
            {
                // Сброс размера и положения кнопки в зависимости от индекса
                int index = Array.IndexOf(buttons, button);
                switch (index)
                {
                    case 0:
                        button.Size = new Size(80, 30);
                        break;
                    case 1:
                        button.Size = new Size(80, 30);
                        break;
                    case 2:
                        button.Location = new Point(10 + 100 * 2, 100);
                        break;
                }
            }
        }
    }
}
