using System;
using System.Windows.Forms;

namespace CurrencyExchangeApp
{
    public partial class Form1 : Form
    {
        // Exchange rate from Hryvnia to Norwegian Krone
        private const double ExchangeRate = 0.30; // Replace with the actual rate for your variant

        public Form1()
        {
            InitializeComponent();
        }

        private void txtHryvniaAmount_TextChanged(object sender, EventArgs e)
        {
            // Enable OK button only when the text field is not empty
            btnOk.Enabled = !string.IsNullOrWhiteSpace(txtHryvniaAmount.Text);
        }

        private void txtHryvniaAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and control characters (like backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignore the input if it's not a digit or control character
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            // Try to convert input to double and calculate the converted amount
            if (double.TryParse(txtHryvniaAmount.Text, out double hryvniaAmount))
            {
                double kroneAmount = hryvniaAmount * ExchangeRate;
                lblResult.Text = $"Amount in NOK: {kroneAmount:F2}";
            }
            else
            {
                MessageBox.Show("Please enter a valid amount in hryvnia.");
            }
        }
    }
}
