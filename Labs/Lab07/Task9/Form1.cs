using System;
using System.Drawing;
using System.Windows.Forms;

namespace TextBoxEventsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeTextBoxes();
        }

        private void InitializeTextBoxes()
        {
            // Створення та налаштування трьох текстових полів
            TextBox textBox1 = CreateTextBox("Перший текст", 50);
            TextBox textBox2 = CreateTextBox("Другий текст", 100);
            TextBox textBox3 = CreateTextBox("Третій текст", 150);

            // Додавання текстових полів на форму
            this.Controls.Add(textBox1);
            this.Controls.Add(textBox2);
            this.Controls.Add(textBox3);
        }

        private TextBox CreateTextBox(string text, int topPosition)
        {
            TextBox textBox = new TextBox
            {
                Text = text,
                Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular),
                Width = 200,
                Location = new Point((this.ClientSize.Width - 200) / 2, topPosition)
            };

            // Прив'язуємо обробники подій Enter та Leave
            textBox.Enter += TextBox_Enter;
            textBox.Leave += TextBox_Leave;

            return textBox;
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            // Підкреслюємо текст при вході в текстове поле
            if (sender is TextBox textBox)
            {
                textBox.Font = new Font(textBox.Font, FontStyle.Underline);
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            // Повертаємо звичайний шрифт при виході з текстового поля
            if (sender is TextBox textBox)
            {
                textBox.Font = new Font(textBox.Font, FontStyle.Regular);
            }
        }
    }
}
