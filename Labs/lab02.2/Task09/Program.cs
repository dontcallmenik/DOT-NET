using System;
using System.Drawing;
using System.Windows.Forms;

namespace TextBoxEventExample
{
    public partial class Form1 : Form
    {
        private TextBox[] textBoxes;

        public Form1()
        {
            InitializeComponent();

            // ������� ������ ��������� �����
            textBoxes = new TextBox[3];

            // ������� ��������� ���� � ��������� �� �� �����
            for (int i = 0; i < textBoxes.Length; i++)
            {
                textBoxes[i] = new TextBox();
                textBoxes[i].Location = new Point(100, 50 + (i * 40)); // ������������� �������
                textBoxes[i].Size = new Size(200, 30); // ������������� ������
                textBoxes[i].Enter += TextBox_Enter; // ��������� ���������� ������� Enter
                textBoxes[i].Leave += TextBox_Leave; // ��������� ���������� ������� Leave
                Controls.Add(textBoxes[i]); // ��������� ��������� ���� �� �����
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Name = "Form1";
            this.Text = "TextBox Event Example";
            this.ResumeLayout(false);
        }

        // ���������� ������� Enter
        private void TextBox_Enter(object? sender, EventArgs e) // ���������, ��� sender ����� ���� null
        {
            if (sender is TextBox textBox) // ���������, ��� sender ��� TextBox
            {
                textBox.BackColor = Color.LightYellow; // �������� ���� ����
                textBox.Text = "������� ����"; // ������������� �����
            }
        }

        // ���������� ������� Leave
        private void TextBox_Leave(object? sender, EventArgs e) // ���������, ��� sender ����� ���� null
        {
            if (sender is TextBox textBox) // ���������, ��� sender ��� TextBox
            {
                textBox.BackColor = SystemColors.Window; // ���������� ���� ����
                textBox.Text = ""; // ������� �����
            }
        }
    }
}
