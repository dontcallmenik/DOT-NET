using System;
using System.Windows.Forms;

namespace Task5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            // ������ ���� ������ ���������� ����
            decimal basePrice = 20000m;

            // ��������� ������� ������� �� ������� �����
            if (checkBoxLighting.Checked) basePrice += 3000m;
            if (checkBoxSound.Checked) basePrice += 2500m;
            if (checkBoxDecoration.Checked) basePrice += 4000m;
            if (checkBoxCatering.Checked) basePrice += 5000m;

            // ��������� ����������
            labelTotalPrice.Text = "�������� ����: " + basePrice.ToString("C") + " ���";
        }
    }
}
