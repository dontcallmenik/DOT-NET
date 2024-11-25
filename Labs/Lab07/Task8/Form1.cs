using System;
using System.Drawing;
using System.Windows.Forms;

namespace MouseEventsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Один обробник подій для MouseDown та MouseUp
        private void Label_MouseAction(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // Перевіряємо, що це ліва кнопка миші
            {
                Label label = sender as Label; // Приводимо sender до типу Label
                if (label != null)
                {
                    // Перемикаємо підкреслення за допомогою XOR-операції
                    label.Font = new Font(label.Font, label.Font.Style ^ FontStyle.Underline);
                }
            }
        }
    }
}
