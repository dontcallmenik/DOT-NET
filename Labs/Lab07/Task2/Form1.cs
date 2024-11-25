using System;
using System.Windows.Forms;

namespace ButtonClickApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Єдиний обробник подій для всіх кнопок
        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;  // Приводимо sender до типу Button

            if (clickedButton != null)
            {
                Label label = new Label();
                label.Text = $"Натиснута {clickedButton.Text}";  // Виводимо текст кнопки
                label.Location = new System.Drawing.Point(300, 150 + this.Controls.Count * 30);  // Динамічне розташування
                this.Controls.Add(label);
            }
        }
    }
}
