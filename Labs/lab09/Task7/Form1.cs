using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PhotoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            // Ціна залежно від формату
            decimal pricePerPhoto = 0;

            if (radioButton1.Checked)
                pricePerPhoto = 5m; // Ціна для формату 9x12
            else if (radioButton2.Checked)
                pricePerPhoto = 7m; // Ціна для формату 10x15
            else if (radioButton3.Checked)
                pricePerPhoto = 10m; // Ціна для формату 18x24

            // Кількість фото
            if (int.TryParse(textBoxQuantity.Text, out int quantity) && quantity > 0)
            {
                decimal totalPrice = pricePerPhoto * quantity;
                labelResult.Text = $"Загальна ціна: {totalPrice:C}";
            }
            else
            {
                MessageBox.Show("Введіть коректну кількість", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
