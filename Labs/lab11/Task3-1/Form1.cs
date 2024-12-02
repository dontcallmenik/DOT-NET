using System;
using System.Windows.Forms;

namespace SquareCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Перевірка введених даних і розрахунок площі та периметру
            if (double.TryParse(sideTextBox.Text, out double side) && side > 0)
            {
                double perimeter = 4 * side;
                double area = side * side;

                resultTextBox.Text = $"Perimeter: {perimeter}\nArea: {area}";
            }
            else
            {
                MessageBox.Show("Please enter a valid positive number for the side length.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
