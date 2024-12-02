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

        public void DisplayResult(double perimeter, double area)
        {
            resultTextBox.Text = $"Perimeter: {perimeter}\nArea: {area}";
        }

        private void openInputFormButton_Click(object sender, EventArgs e)
        {
            InputForm inputForm = new InputForm(this);
            inputForm.Show();
        }
    }
}
