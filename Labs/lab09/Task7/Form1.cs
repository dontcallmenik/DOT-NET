using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PhotoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            // ֳ�� ������� �� �������
            decimal pricePerPhoto = 0;

            if (radioButton1.Checked)
                pricePerPhoto = 5m; // ֳ�� ��� ������� 9x12
            else if (radioButton2.Checked)
                pricePerPhoto = 7m; // ֳ�� ��� ������� 10x15
            else if (radioButton3.Checked)
                pricePerPhoto = 10m; // ֳ�� ��� ������� 18x24

            // ʳ������ ����
            if (int.TryParse(textBoxQuantity.Text, out int quantity) && quantity > 0)
            {
                decimal totalPrice = pricePerPhoto * quantity;
                labelResult.Text = $"�������� ����: {totalPrice:C}";
            }
            else
            {
                MessageBox.Show("������ �������� �������", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
