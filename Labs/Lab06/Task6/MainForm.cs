using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Task6
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Очистка
            textBox1.Text = "";
            richTextBox1.Text = "";

            // Получение информации
            string name = textBox1.Text;
            int age = Convert.ToInt32(comboBox1.SelectedItem);
            string gender = comboBox2.SelectedItem.ToString();
            string interest = "";
            if (checkBox1.Checked)
            {
                interest += "Комп'ютери ";
            }
            if (checkBox2.Checked)
            {
                interest += "Спорт ";
            }
            if (checkBox3.Checked)
            {
                interest += "Мистецтво ";
            }
            if (checkBox4.Checked)
            {
                interest += "Наука ";
            }

            // Формирование текста
            string text = $"Ім'я: {name}\nВік: {age}\nСтать: {gender}\nІнтереси: {interest}";
            richTextBox1.Text = text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Очистка
            textBox1.Text = "";
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            richTextBox1.Text = "";
        }
    }
}