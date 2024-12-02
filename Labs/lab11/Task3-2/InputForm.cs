using System;
using System.Windows.Forms;

namespace SquareCalculator
{
    public partial class InputForm : Form
    {
        private Form1 mainForm;

        public InputForm(Form1 form)
        {
            mainForm = form;
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(sideTextBox.Text, out double side) && side > 0)
            {
                double perimeter = 4 * side;
                double area = side * side;

                mainForm.DisplayResult(perimeter, area);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter a valid positive number for the side length.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
