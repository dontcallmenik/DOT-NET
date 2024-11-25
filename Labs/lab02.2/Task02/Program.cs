using System;
using System.Windows.Forms;

namespace ButtonClickEvent
{
    public partial class Form1 : Form
    {
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private Button button3;

        public Form1()
        {
            InitializeComponent();

            // Инициализация текстовых полей
            textBox1 = new TextBox() { Location = new System.Drawing.Point(20, 20), Width = 200 };
            textBox2 = new TextBox() { Location = new System.Drawing.Point(20, 60), Width = 200 };
            textBox3 = new TextBox() { Location = new System.Drawing.Point(20, 100), Width = 200 };

            // Инициализация кнопок
            button1 = new Button() { Text = "Кнопка 1", Location = new System.Drawing.Point(240, 20) };
            button2 = new Button() { Text = "Кнопка 2", Location = new System.Drawing.Point(240, 60) };
            button3 = new Button() { Text = "Кнопка 3", Location = new System.Drawing.Point(240, 100) };

            // Добавляем контролы на форму
            this.Controls.Add(textBox1);
            this.Controls.Add(textBox2);
            this.Controls.Add(textBox3);
            this.Controls.Add(button1);
            this.Controls.Add(button2);
            this.Controls.Add(button3);

            // Привязка одного обработчика событий ко всем кнопкам
            button1.Click += Button_Click;
            button2.Click += Button_Click;
            button3.Click += Button_Click;
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        // Обработчик событий для всех кнопок
        private void Button_Click(object? sender, EventArgs e)
        {
            if (sender is Button button)
            {
                switch (button.Text)
                {
                    case "Кнопка 1":
                        textBox1.Text = "Кнопка 1 нажата";
                        break;
                    case "Кнопка 2":
                        textBox2.Text = "Кнопка 2 нажата";
                        break;
                    case "Кнопка 3":
                        textBox3.Text = "Кнопка 3 нажата";
                        break;
                }
            }
        }
    }
}
