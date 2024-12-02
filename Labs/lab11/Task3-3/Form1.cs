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

        private void openInputFormButton_Click(object sender, EventArgs e)
        {
            InputForm inputForm = new InputForm();
            if (inputForm.ShowDialog() == DialogResult.OK)
            {
                double sideLength;
                if (double.TryParse(inputForm.SideTextBox.Text, out sideLength))
                {
                    double perimeter = 4 * sideLength;
                    double area = sideLength * sideLength;

                    ResultForm resultForm = new ResultForm();
                    resultForm.ResultTextBox.Text = $"Perimeter: {perimeter}\nArea: {area}";
                    resultForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid input. Please enter a numeric value for the side length.");
                }
            }
        }
    }
}
