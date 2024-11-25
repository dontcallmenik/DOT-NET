using System;
using System.Windows.Forms;

namespace CitySelector
{
    public class MainForm : Form
    {
        private ComboBox comboBoxCities;
        private ListBox listBoxCities;

        public MainForm()
        {
            // Викликаємо метод для налаштування форми та створення компонентів
            InitializeForm();
        }

        private void InitializeForm()
        {
            // Налаштування форми
            this.Text = "Вибір міст Туреччини";
            this.Size = new System.Drawing.Size(300, 250);

            // Створення ComboBox програмним шляхом
            comboBoxCities = new ComboBox
            {
                DropDownStyle = ComboBoxStyle.DropDownList,
                Location = new System.Drawing.Point(20, 20),
                Size = new System.Drawing.Size(200, 30)
            };
            comboBoxCities.SelectedIndexChanged += ComboBoxCities_SelectedIndexChanged;

            // Створення ListBox програмним шляхом
            listBoxCities = new ListBox
            {
                Location = new System.Drawing.Point(20, 70),
                Size = new System.Drawing.Size(200, 150)
            };

            // Додаємо компоненти на форму
            this.Controls.Add(comboBoxCities);
            this.Controls.Add(listBoxCities);

            // Заповнюємо ComboBox та ListBox містами Туреччини
            PopulateCityLists();
        }

        private void PopulateCityLists()
        {
            comboBoxCities.Items.AddRange(Cities.TurkishCities);
            listBoxCities.Items.AddRange(Cities.TurkishCities);
        }

        private void ComboBoxCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCity = comboBoxCities.SelectedItem.ToString();
            if (!listBoxCities.Items.Contains(selectedCity))
            {
                listBoxCities.Items.Add(selectedCity);
            }
        }
    }
}
