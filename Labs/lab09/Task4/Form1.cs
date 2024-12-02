using System;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DistanceConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false; // Вимикаємо кнопку OK, поки поле не заповнено
            textBox1.TextChanged += TextBox1_TextChanged;
            textBox1.KeyPress += TextBox1_KeyPress;
            button1.Click += Button1_Click;
            comboBoxDirection.SelectedIndexChanged += ComboBoxDirection_SelectedIndexChanged;
            comboBoxDirection.SelectedIndex = 0; // Встановлюємо початковий напрямок конвертації
        }

        // Дозволити тільки цифри
        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.');
        }

        // Увімкнути кнопку OK, якщо текстове поле непорожнє
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = !string.IsNullOrWhiteSpace(textBox1.Text);
        }

        // Виконати конвертацію після натискання кнопки OK
        private void Button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double input))
            {
                string direction = comboBoxDirection.SelectedItem.ToString();
                double result;

                if (direction == "Кілометри в лінії")
                {
                    // Конвертувати кілометри в лінії (1 км = 100 000 ліній)
                    result = input * 100000;
                    label1.Text = $"{input} км = {result} ліній";
                }
                else
                {
                    // Конвертувати лінії в кілометри (1 лінія = 0.00001 км)
                    result = input * 0.00001;
                    label1.Text = $"{input} ліній = {result} км";
                }
            }
            else
            {
                MessageBox.Show("Введіть правильне число.");
            }
        }

        // Оновлення тексту label1 при зміні напрямку конвертації
        private void ComboBoxDirection_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = ""; // Очищуємо результат при зміні напрямку
        }
    }
}
