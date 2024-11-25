using System;
using System.Drawing;
using System.Windows.Forms;

namespace ButtonFontToggle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();  // Ініціалізація форми

            // Додаємо обробники подій для трьох кнопок
            button1.MouseEnter += Button_MouseEnter;
            button1.MouseLeave += Button_MouseLeave;

            button2.MouseEnter += Button_MouseEnter;
            button2.MouseLeave += Button_MouseLeave;

            button3.MouseEnter += Button_MouseEnter;
            button3.MouseLeave += Button_MouseLeave;
        }

        // Обробник події MouseEnter (навели курсор на кнопку)
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                btn.Font = new Font(btn.Font, FontStyle.Underline);
            }
        }

        // Обробник події MouseLeave (курсор покинув кнопку)
        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                btn.Font = new Font(btn.Font, FontStyle.Regular);
            }
        }
    }
}
