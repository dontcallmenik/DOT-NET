using System;
using System.Windows.Forms;

namespace CitySelector
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            PopulateCityLists();
        }

        private void PopulateCityLists()
        {
            // Додаємо міста до ComboBox та ListBox
            comboBoxCities.Items.AddRange(Cities.TurkishCities);
            listBoxCities.Items.AddRange(Cities.TurkishCities);
        }

        private void comboBoxCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            // При виборі елемента в ComboBox додаємо його в ListBox
            string selectedCity = comboBoxCities.SelectedItem.ToString();
            if (!listBoxCities.Items.Contains(selectedCity))
            {
                listBoxCities.Items.Add(selectedCity);
            }
        }
    }
}
