using System;
using System.Windows.Forms;

namespace KeyPressExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // �������� ��䳿 KeyPress ��� ���������� �������
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ��������: ��������� ����� ������� 'n' �� 'z' � �������� ������
            if (e.KeyChar < 'n' || e.KeyChar > 'z')
            {
                e.Handled = true; // ������� �������� ������������ �������
            }
        }
    }
}
