using System;
using System.Globalization;
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

            // Инициализация выпадающих списков
            comboBoxFrom.Items.AddRange(new[] { "Километры", "Метры", "Мили" });
            comboBoxTo.Items.AddRange(new[] { "Километры", "Метры", "Мили" });

            // Устанавливаем начальное значение (по умолчанию)
            comboBoxFrom.SelectedIndex = 0;
            comboBoxTo.SelectedIndex = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Проверяем, что введённое значение не пустое и корректное число
            if (!string.IsNullOrEmpty(textBox1.Text) && double.TryParse(textBox1.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double distance))
            {
                // Получаем выбранные единицы измерения
                string fromUnit = comboBoxFrom.SelectedItem?.ToString() ?? string.Empty;
                string toUnit = comboBoxTo.SelectedItem?.ToString() ?? string.Empty;

                // Проверяем, что выбраны корректные единицы
                if (string.IsNullOrEmpty(fromUnit) || string.IsNullOrEmpty(toUnit))
                {
                    MessageBox.Show("Пожалуйста, выберите единицы измерения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    // Конвертируем расстояние
                    double result = ConvertDistance(distance, fromUnit, toUnit);

                    // Выводим результат
                    label2.Text = $"Результат: {result:F2} {toUnit}";
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректное число.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private double ConvertDistance(double distance, string fromUnit, string toUnit)
        {
            // Преобразуем входное расстояние в метры
            double distanceInMeters = fromUnit switch
            {
                "Километры" => distance * 1000,
                "Метры" => distance,
                "Мили" => distance * 1609.34,
                _ => throw new ArgumentException($"Неизвестная единица измерения: {fromUnit}")
            };

            // Преобразуем расстояние из метров в нужную единицу
            return toUnit switch
            {
                "Километры" => distanceInMeters / 1000,
                "Метры" => distanceInMeters,
                "Мили" => distanceInMeters / 1609.34,
                _ => throw new ArgumentException($"Неизвестная единица измерения: {toUnit}")
            };
        }
    }
}
