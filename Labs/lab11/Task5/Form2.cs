using System;
using System.Windows.Forms;

namespace CitySelector
{
    public partial class Form2 : Form
    {
        private string cityName;

        public Form2(string city)
        {
            InitializeComponent();
            cityName = city;
            DisplayCityInfo();
        }

        private void DisplayCityInfo()
        {
            // Example descriptions and paths to photos
            labelCityDescription.Text = $"{cityName} is a beautiful city in Turkey.";
            pictureBoxCityPhoto.ImageLocation = $"C:\\Users\\vladi\\Desktop\\cities\\{cityName}.jpg";
            pictureBoxCityPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
