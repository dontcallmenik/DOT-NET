using System;
using System.Drawing;
using System.Windows.Forms;

namespace TextBoxEventsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeTextBoxes();
        }

        private void InitializeTextBoxes()
        {
            // ��������� �� ������������ ����� ��������� ����
            TextBox textBox1 = CreateTextBox("������ �����", 50);
            TextBox textBox2 = CreateTextBox("������ �����", 100);
            TextBox textBox3 = CreateTextBox("����� �����", 150);

            // ��������� ��������� ���� �� �����
            this.Controls.Add(textBox1);
            this.Controls.Add(textBox2);
            this.Controls.Add(textBox3);
        }

        private TextBox CreateTextBox(string text, int topPosition)
        {
            TextBox textBox = new TextBox
            {
                Text = text,
                Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular),
                Width = 200,
                Location = new Point((this.ClientSize.Width - 200) / 2, topPosition)
            };

            // ����'����� ��������� ���� Enter �� Leave
            textBox.Enter += TextBox_Enter;
            textBox.Leave += TextBox_Leave;

            return textBox;
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            // ϳ���������� ����� ��� ���� � �������� ����
            if (sender is TextBox textBox)
            {
                textBox.Font = new Font(textBox.Font, FontStyle.Underline);
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            // ��������� ��������� ����� ��� ����� � ���������� ����
            if (sender is TextBox textBox)
            {
                textBox.Font = new Font(textBox.Font, FontStyle.Regular);
            }
        }
    }
}
