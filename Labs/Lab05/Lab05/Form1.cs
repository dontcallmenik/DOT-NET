using System;
using System.Windows.Forms;

namespace CarConfiguration
{
    public partial class CarConfigurationForm : Form
    {
        // Модель автомобиля и базовая цена
        private string _carModel = "Chevrolet LACETTI";
        private double _basePrice = 415000;

        // Опции
        private bool _carMats = false;
        private bool _engineGuard = false;
        private bool _winterTires = false;
        private bool _alloyWheels = false;

        // Стоимость опций
        private double _matPrice = 5000;
        private double _guardPrice = 10000;
        private double _tirePrice = 20000;
        private double _wheelPrice = 15000;

        public CarConfigurationForm()
        {
            InitializeComponent();
            // Установить модель на форму
            carModelLabel.Text = _carModel;
            UpdateTotalPrice();
        }

        private void UpdateTotalPrice()
        {
            double totalPrice = _basePrice;

            if (_carMats) totalPrice += _matPrice;
            if (_engineGuard) totalPrice += _guardPrice;
            if (_winterTires) totalPrice += _tirePrice;
            if (_alloyWheels) totalPrice += _wheelPrice;

            totalPriceLabel.Text = $"Ціна у вибраній комплектації: {totalPrice:N2} грн";
        }

        // Обработчики событий для флажков
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
    }
}
