using System;
using System.Windows.Forms;

namespace Task6
{
    public partial class Form1 : Form
    {
        // Курс валют (наприклад, UAH до інших валют)
        private readonly decimal usdRate = 0.027m; // 1 UAH = 0.027 USD
        private readonly decimal eurRate = 0.025m; // 1 UAH = 0.025 EUR

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            // Базова ціна оренди банкетного залу
            decimal basePrice = 20000m;

            // Додаткова вартість залежно від обраних опцій
            if (checkBoxLighting.Checked) basePrice += 3000m;
            if (checkBoxSound.Checked) basePrice += 2500m;
            if (checkBoxDecoration.Checked) basePrice += 4000m;
            if (checkBoxCatering.Checked) basePrice += 5000m;

            // Виведення результату в національній валюті
            labelTotalPrice.Text = "Загальна ціна: " + basePrice.ToString("C") + " грн";

            // Оновлення ціни в обраній валюті
            UpdateConvertedPrice(basePrice);
        }

        private void comboBoxCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Перерахунок ціни при зміні обраної валюти
            if (decimal.TryParse(labelTotalPrice.Text.Replace("Загальна ціна:", "").Replace("грн", "").Trim(), out decimal basePrice))
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
                    labelConvertedPrice.Text = "Ціна в USD: " + convertedPrice.ToString("C") + " $";
                    break;
                case "EUR":
                    convertedPrice = basePrice * eurRate;
                    labelConvertedPrice.Text = "Ціна в EUR: " + convertedPrice.ToString("C") + " €";
                    break;
                default:
                    labelConvertedPrice.Text = "Виберіть валюту для конвертації.";
                    break;
            }
        }
    }
}
