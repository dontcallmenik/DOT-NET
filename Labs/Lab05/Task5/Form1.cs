using System;
using System.Windows.Forms;

namespace CarConfiguration
{
    public partial class CarConfigurationForm : Form
    {
        private string _carModel = "Chevrolet LACETTI";
        private double _basePrice = 415000;

        private bool _carMats = false;
        private bool _engineGuard = false;
        private bool _winterTires = false;
        private bool _alloyWheels = false;

        private double _matPrice = 5000;
        private double _guardPrice = 10000;
        private double _tirePrice = 20000;
        private double _wheelPrice = 15000;

        private double _usdExchangeRate = 36.7; // Курс гривні до долара
        private string _selectedCurrency = "Гривні (UAH)";

        public CarConfigurationForm()
        {
            InitializeComponent();

            carModelLabel.Text = _carModel;

            // Ініціалізуємо список валют
            currencyComboBox.SelectedIndex = 0; // Встановлюємо "Гривні" за замовчуванням

            UpdateTotalPrice();
        }

        private void UpdateTotalPrice()
        {
            double totalPrice = _basePrice;

            if (_carMats) totalPrice += _matPrice;
            if (_engineGuard) totalPrice += _guardPrice;
            if (_winterTires) totalPrice += _tirePrice;
            if (_alloyWheels) totalPrice += _wheelPrice;

            string formattedPrice;

            if (_selectedCurrency == "Долари (USD)")
            {
                double totalPriceInUsd = totalPrice / _usdExchangeRate;
                formattedPrice = $"Ціна: {totalPriceInUsd:F2} USD";
            }
            else
            {
                formattedPrice = $"Ціна: {totalPrice:N2} грн";
            }

            totalPriceLabel.Text = formattedPrice;
        }

        private void carMatsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _carMats = carMatsCheckBox.Checked;
            UpdateTotalPrice();
        }

        private void engineGuardCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _engineGuard = engineGuardCheckBox.Checked;
            UpdateTotalPrice();
        }

        private void winterTiresCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _winterTires = winterTiresCheckBox.Checked;
            UpdateTotalPrice();
        }

        private void alloyWheelsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _alloyWheels = alloyWheelsCheckBox.Checked;
            UpdateTotalPrice();
        }

        private void currencyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedCurrency = currencyComboBox.SelectedItem.ToString();
            UpdateTotalPrice();
        }
    }
}
