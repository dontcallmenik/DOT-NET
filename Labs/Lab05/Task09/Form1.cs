using System;
using System.Windows.Forms;

namespace ProductPriceCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Обработчик события для кнопки "Розрахувати"
        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Базовая цена продукта
                double basePrice = 100;

                // Получаем выбранный размер из ComboBox
                string selectedSize = sizeComboBox.SelectedItem?.ToString();
                if (selectedSize == "Малий") basePrice += 0;
                else if (selectedSize == "Середній") basePrice += 50;
                else if (selectedSize == "Великий") basePrice += 100;

                // Получаем выбранную упаковку
                string selectedPackaging = packagingComboBox.SelectedItem?.ToString();
                if (selectedPackaging == "Економ") basePrice += 10;
                else if (selectedPackaging == "Стандарт") basePrice += 20;
                else if (selectedPackaging == "Преміум") basePrice += 30;

                // Добавляем стоимость дополнительных услуг
                if (deliveryCheckBox.Checked) basePrice += 40;
                if (giftWrappingCheckBox.Checked) basePrice += 30;
                if (installationCheckBox.Checked) basePrice += 50;

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
