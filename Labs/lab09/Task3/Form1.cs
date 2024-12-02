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
            if (double.TryParse(textBox1.Text, out double kilometers))
            {
                // Конвертувати кілометри в "лінії"
                double lines = kilometers * 100000; // Формула для конвертації в "лінії"
                label1.Text = $"{kilometers} км = {lines} ліній";
            }
            else
            {
                MessageBox.Show("Введіть правильне число.");
            }
        }
    }
}
