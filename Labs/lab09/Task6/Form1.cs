using System;
using System.Windows.Forms;

namespace Task6
{
    public partial class Form1 : Form
    {
        // ���� ����� (���������, UAH �� ����� �����)
        private readonly decimal usdRate = 0.027m; // 1 UAH = 0.027 USD
        private readonly decimal eurRate = 0.025m; // 1 UAH = 0.025 EUR

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

            // ��������� ���������� � ����������� �����
            labelTotalPrice.Text = "�������� ����: " + basePrice.ToString("C") + " ���";

            // ��������� ���� � ������ �����
            UpdateConvertedPrice(basePrice);
        }

        private void comboBoxCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ����������� ���� ��� ��� ������ ������
            if (decimal.TryParse(labelTotalPrice.Text.Replace("�������� ����:", "").Replace("���", "").Trim(), out decimal basePrice))
            {
                UpdateConvertedPrice(basePrice);
            }
        }

        private void UpdateConvertedPrice(decimal basePrice)
        {
            decimal convertedPrice = basePrice;

            switch (comboBoxCurrency.SelectedItem.ToString())
            {
                case "USD":
                    convertedPrice = basePrice * usdRate;
                    labelConvertedPrice.Text = "ֳ�� � USD: " + convertedPrice.ToString("C") + " $";
                    break;
                case "EUR":
                    convertedPrice = basePrice * eurRate;
                    labelConvertedPrice.Text = "ֳ�� � EUR: " + convertedPrice.ToString("C") + " �";
                    break;
                default:
                    labelConvertedPrice.Text = "������� ������ ��� �����������.";
                    break;
            }
        }
    }
}
