﻿using System;
using System.Windows.Forms;

namespace ProductPriceCalculator
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        // Обработчик события для кнопки "Розрахувати"
        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Базовая цена продукта
                double basePrice = 100;

                // Добавляем стоимость в зависимости от выбранного размера
                if (radioButtonSmall.Checked) basePrice += 0;
                if (radioButtonMedium.Checked) basePrice += 50;
                if (radioButtonLarge.Checked) basePrice += 100;

                // Добавляем стоимость в зависимости от выбранной упаковки
                if (radioButtonEconomy.Checked) basePrice += 10;
                if (radioButtonStandard.Checked) basePrice += 20;
                if (radioButtonPremium.Checked) basePrice += 30;

                // Добавляем стоимость дополнительных услуг
                if (radioButtonDelivery.Checked) basePrice += 40;
                if (radioButtonGiftWrapping.Checked) basePrice += 30;
                if (radioButtonInstallation.Checked) basePrice += 50;

                // Проверяем, введено ли корректное количество
                int quantity;
                if (!int.TryParse(quantityTextBox.Text, out quantity) || quantity <= 0)
                {
                    MessageBox.Show("Будь ласка, введіть коректну кількість.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Рассчитываем общую стоимость с учетом количества
                double totalPrice = basePrice * quantity;

                // Отображаем результат
                totalPriceLabel.Text = $"Загальна ціна: {totalPrice:N2} грн";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сталася помилка: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
