using System;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DistanceConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false; // �������� ������ OK, ���� ���� �� ���������
            textBox1.TextChanged += TextBox1_TextChanged;
            textBox1.KeyPress += TextBox1_KeyPress;
            button1.Click += Button1_Click;
        }

        // ��������� ����� �����
        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.');
        }

        // �������� ������ OK, ���� �������� ���� ��������
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = !string.IsNullOrWhiteSpace(textBox1.Text);
        }

        // �������� ����������� ���� ���������� ������ OK
        private void Button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double kilometers))
            {
                // ������������ �������� � "��"
                double lines = kilometers * 100000; // ������� ��� ����������� � "��"
                label1.Text = $"{kilometers} �� = {lines} ���";
            }
            else
            {
                MessageBox.Show("������ ��������� �����.");
            }
        }
    }
}
