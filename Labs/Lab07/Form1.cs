using System;
using System.Windows.Forms;

namespace ButtonClickApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();  // Ініціалізуємо компоненти форми
        }

        // Обробник натискання для кнопки 1
        private void button1_Click(object sender, EventArgs e)
        {
            Label label = new Label();
            label.Text = "Натиснута кнопка 1";
            label.Location = new System.Drawing.Point(300, 150);  // Позиція напису
            this.Controls.Add(label);
        }

        // Обробник натискання для кнопки 2
        private void button2_Click(object sender, EventArgs e)
        {
            Label label = new Label();
            label.Text = "Натиснута кнопка 2";
            label.Location = new System.Drawing.Point(300, 180);
            this.Controls.Add(label);
        }

        // Обробник натискання для кнопки 3
        private void button3_Click(object sender, EventArgs e)
        {
            Label label = new Label();
            label.Text = "Натиснута кнопка 3";
            label.Location = new System.Drawing.Point(300, 210);
            this.Controls.Add(label);
        }
    }
}
