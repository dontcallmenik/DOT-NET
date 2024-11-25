using System;
using System.Windows.Forms;

namespace KeyPressHandling
{
    public partial class Form1 : Form
    {
        private TextBox textBox1 = new TextBox(); // ������������� � ����� ����������

        public Form1()
        {
            InitializeComponent();
            InitializeTextBox(); // �������������� ��������� ����
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(textBox1); // ��������� TextBox �� �����
            this.Name = "Form1";
            this.Text = "Key Press Handling Example";
            this.ResumeLayout(false);
        }

        private void InitializeTextBox()
        {
            textBox1.Location = new System.Drawing.Point(50, 50); // ������������� �������
            textBox1.Size = new System.Drawing.Size(200, 30); // ������������� ������
            textBox1.KeyPress += textBox1_KeyPress; // ������������ ���������� ������� KeyPress
        }

        private void textBox1_KeyPress(object? sender, KeyPressEventArgs e) // �������� �������������� ���� ��� sender
        {
            // ��������, �������� �� ������ ������ ��� ������
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                // ���� ���, ������ �������� - ��������� �������
                e.Handled = true;
            }
            else
            {
                // �������� ���������� �����
                if (e.KeyChar == '.' && textBox1.Text.IndexOf('.') != -1)
                {
                    // ���� ��� ���� ����� - ��������� �������
                    e.Handled = true;
                }
                else if (textBox1.Text.Length >= 10)
                {
                    // �������� ���������� ����
                    if (e.KeyChar == '.' && textBox1.Text.IndexOf('.') == -1)
                    {
                        // ���� ���� ������ 10, � ����� ��� �� ������� - ��������� �� ����
                        e.Handled = false;
                    }
                    else
                    {
                        // ���� ���� ������ 10 � ����� ��� ������� - ��������� �������
                        e.Handled = true;
                    }
                }
                else
                {
                    // ���� ���������� ���� �� ��������� 10 - ��������� �������
                    e.Handled = false;
                }
            }
        }
    }
}
