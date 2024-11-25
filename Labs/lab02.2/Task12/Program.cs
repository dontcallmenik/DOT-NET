using System;
using System.Windows.Forms;

namespace KeyPressHandling
{
    public partial class Form1 : Form
    {
        private TextBox textBox1 = new TextBox(); // Инициализация в месте объявления

        public Form1()
        {
            InitializeComponent();
            InitializeTextBox(); // Инициализируем текстовое поле
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(textBox1); // Добавляем TextBox на форму
            this.Name = "Form1";
            this.Text = "Key Press Handling Example";
            this.ResumeLayout(false);
        }

        private void InitializeTextBox()
        {
            textBox1.Location = new System.Drawing.Point(50, 50); // Устанавливаем позицию
            textBox1.Size = new System.Drawing.Size(200, 30); // Устанавливаем размер
            textBox1.KeyPress += textBox1_KeyPress; // Регистрируем обработчик события KeyPress
        }

        private void textBox1_KeyPress(object? sender, KeyPressEventArgs e) // Добавлен вопросительный знак для sender
        {
            // Проверка, является ли символ цифрой или точкой
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                // Если нет, символ запрещен - блокируем событие
                e.Handled = true;
            }
            else
            {
                // Проверка количества точек
                if (e.KeyChar == '.' && textBox1.Text.IndexOf('.') != -1)
                {
                    // Если уже есть точка - блокируем событие
                    e.Handled = true;
                }
                else if (textBox1.Text.Length >= 10)
                {
                    // Проверка количества цифр
                    if (e.KeyChar == '.' && textBox1.Text.IndexOf('.') == -1)
                    {
                        // Если цифр больше 10, а точка еще не введена - разрешаем ее ввод
                        e.Handled = false;
                    }
                    else
                    {
                        // Если цифр больше 10 и точка уже введена - блокируем событие
                        e.Handled = true;
                    }
                }
                else
                {
                    // Если количество цифр не превышает 10 - разрешаем событие
                    e.Handled = false;
                }
            }
        }
    }
}
