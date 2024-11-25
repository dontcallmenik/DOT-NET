using System;
using System.Drawing;
using System.Windows.Forms;

namespace ButtonTransformations
{
    public partial class Form1 : Form
    {
        private Button[] buttons;
        private Random random;

        public Form1()
        {
            InitializeComponent();
            random = new Random();
            buttons = new Button[3];

            // Create buttons with different labels
            for (int i = 0; i < 3; i++)
            {
                buttons[i] = new Button();
                buttons[i].Text = $"Button {i + 1}";
                buttons[i].Location = new Point(10 + 100 * i, 100);
                buttons[i].Size = new Size(80, 30);

                // Assign TabIndex
                buttons[i].TabIndex = i;

                // Add MouseEnter and MouseLeave event handlers
                buttons[i].MouseEnter += Button_MouseEnter;
                buttons[i].MouseLeave += Button_MouseLeave;

                // Add buttons to the form
                Controls.Add(buttons[i]);
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Name = "Form1";
            this.ResumeLayout(false);
        }

        private void Button_MouseEnter(object? sender, EventArgs e)
        {
            if (sender is Button button) // Проверяем, что sender - это кнопка
            {
                // Apply transformation based on the button's index
                int index = Array.IndexOf(buttons, button);
                switch (index)
                {
                    case 0:
                        // Increase button size by 2 pixels
                        button.Size = new Size(button.Width + 4, button.Height + 4);
                        break;
                    case 1:
                        // Decrease button size by 1 pixel
                        button.Size = new Size(button.Width - 2, button.Height - 2);
                        break;
                    case 2:
                        // Move button 3 pixels to the right
                        button.Location = new Point(button.Location.X + 3, button.Location.Y);
                        break;
                }
            }
        }

        private void Button_MouseLeave(object? sender, EventArgs e)
        {
            if (sender is Button button) // Проверяем, что sender - это кнопка
            {
                // Reset button size and position based on index
                int index = Array.IndexOf(buttons, button);
                switch (index)
                {
                    case 0:
                        button.Size = new Size(80, 30);
                        break;
                    case 1:
                        button.Size = new Size(80, 30);
                        break;
                    case 2:
                        button.Location = new Point(10 + 100 * 2, 100);
                        break;
                }
            }
        }
    }
}
