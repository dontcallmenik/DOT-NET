using System;
using System.Windows.Forms;

namespace CalculationApp
{
    public partial class InputAndOutputForm : Form
    {
        public InputAndOutputForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtX.Text, out int x) && int.TryParse(txtY.Text, out int y) && int.TryParse(txtZ.Text, out int z))
            {
                double result = CalculateExpression(x, y, z);
                lblResult.Text = $"Result: {result}";
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter integers for x, y, and z.");
            }
        }

        private double CalculateExpression(int x, int y, int z)
        {
            double sum = 0;
            for (int i = 1; i <= x; i++)
            {
                for (int j = 1; j <= y; j++)
                {
                    sum += (double)(i - j) / (i + j + z);
                }
            }
            return sum;
        }
    }
}
