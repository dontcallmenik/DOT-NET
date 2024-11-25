using System;
using System.Windows.Forms;

namespace KeyPressExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Обробник події KeyPress для фільтрації символів
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Перевірка: дозволити тільки символи 'n' до 'z' у нижньому регістрі
            if (e.KeyChar < 'n' || e.KeyChar > 'z')
            {
                e.Handled = true; // Блокуємо введення недозволених символів
            }
        }
    }
}
