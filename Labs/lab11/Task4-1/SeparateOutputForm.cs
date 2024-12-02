using System;
using System.Windows.Forms;

namespace CalculationApp
{
    public partial class SeparateOutputForm : Form
    {
        public SeparateOutputForm()
        {
            InitializeComponent();
        }

        public void DisplayResult(int x, int y, int z)
        {
            double result = CalculateExpression(x, y, z);
            lblResult.Text = $"Result: {result}";
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
