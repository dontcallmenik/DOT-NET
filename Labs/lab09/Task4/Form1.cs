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
            comboBoxDirection.SelectedIndexChanged += ComboBoxDirection_SelectedIndexChanged;
            comboBoxDirection.SelectedIndex = 0; // ������������ ���������� �������� �����������
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
            if (double.TryParse(textBox1.Text, out double input))
            {
                string direction = comboBoxDirection.SelectedItem.ToString();
                double result;

                if (direction == "ʳ������� � ��")
                {
                    // ������������ �������� � �� (1 �� = 100 000 ���)
                    result = input * 100000;
                    label1.Text = $"{input} �� = {result} ���";
                }
                else
                {
                    // ������������ �� � �������� (1 ��� = 0.00001 ��)
                    result = input * 0.00001;
                    label1.Text = $"{input} ��� = {result} ��";
                }
            }
            else
            {
                MessageBox.Show("������ ��������� �����.");
            }
        }

        // ��������� ������ label1 ��� ��� �������� �����������
        private void ComboBoxDirection_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = ""; // ������� ��������� ��� ��� ��������
        }
    }
}
