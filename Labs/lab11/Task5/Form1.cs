using System;
using System.Windows.Forms;

namespace CitySelector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PopulateCityList();
        }

        private void PopulateCityList()
        {
            // Add 7 cities in Turkey to the ComboBox
            comboBoxCities.Items.AddRange(new string[] { "Istanbul", "Ankara", "Izmir", "Antalya", "Bursa", "Gaziantep", "Konya" });
        }

        private void btnShowCityInfo_Click(object sender, EventArgs e)
        {
            if (comboBoxCities.SelectedItem != null)
            {
                string selectedCity = comboBoxCities.SelectedItem.ToString();
                Form2 cityInfoForm = new Form2(selectedCity);
                cityInfoForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a city.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
