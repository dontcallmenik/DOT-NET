using System;
using System.Windows.Forms;

namespace Task02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // Инициализируем компоненты, автоматически добавляется при создании формы
        }

        // Обработчик для кнопки "ОК" (Конвертация из гривен в манаты)
        private void ButtonOk_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(TextBox1.Text, out decimal amountInUAH))
            {
                decimal rate = 16.5m; // Курс гривна -> манат
                decimal amountInAZN = amountInUAH / rate;
                TextBox2.Text = amountInAZN.ToString("F2");
            }
            else
            {
                MessageBox.Show("Введите корректную сумму в гривнах.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Обработчик для кнопки "Конвертировать" (Обратная конвертация)
        private void ButtonConvertBack_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(TextBox3.Text, out decimal amountInAZN))
            {
                decimal rate = 16.5m; // Курс манат -> гривна
                decimal amountInUAH = amountInAZN * rate;
                TextBox1.Text = amountInUAH.ToString("F2");
            }
            else
            {
                MessageBox.Show("Введите корректную сумму в манатах.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
