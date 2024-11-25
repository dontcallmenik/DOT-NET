using System;
using System.Drawing;
using System.Windows.Forms;

namespace ButtonTransformations
{
    public partial class Form1 : Form
    {
        private Button[] buttons;

        public Form1()
        {
            InitializeComponent();
            buttons = new Button[3];

            // �������� ������ � ������� �������
            for (int i = 0; i < 3; i++)
            {
                buttons[i] = new Button();
                buttons[i].Text = $"Button {i + 1}";
                buttons[i].Location = new Point(10 + 100 * i, 100);
                buttons[i].Size = new Size(80, 30);

                // �������� ������ ����������� ������� � ������ ������
                buttons[i].MouseEnter += Button_MouseEnter;
                buttons[i].MouseLeave += Button_MouseLeave;

                // ���������� ������ �� �����
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
            if (sender is Button button) // ���������, ��� sender - ��� ������
            {
                // ���������� ������������� � ����������� �� ������� ������
                int index = Array.IndexOf(buttons, button);
                switch (index)
                {
                    case 0:
                        // ����������� ������ ������ �� 4 �������
                        button.Size = new Size(button.Width + 4, button.Height + 4);
                        break;
                    case 1:
                        // ��������� ������ ������ �� 2 �������
                        button.Size = new Size(button.Width - 2, button.Height - 2);
                        break;
                    case 2:
                        // ���������� ������ �� 3 ������� ������
                        button.Location = new Point(button.Location.X + 3, button.Location.Y);
                        break;
                }
            }
        }

        private void Button_MouseLeave(object? sender, EventArgs e)
        {
            if (sender is Button button) // ���������, ��� sender - ��� ������
            {
                // ����� ������� � ��������� ������ � ����������� �� �������
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
