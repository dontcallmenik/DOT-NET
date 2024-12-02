using System;
using System.Windows.Forms;

namespace CurrencyExchangeApp
{
    public partial class Form1 : Form
    {
        // Exchange rate from Hryvnia to Norwegian Krone
        private const double ExchangeRate = 0.30; // Replace with the actual rate for your assignment

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
            if (double.TryParse(txtHryvniaAmount.Text, out double amount))
            {
                double resultAmount;
                string resultText;

                if (comboConversionDirection.SelectedIndex == 0) // Hryvnia to Krone
                {
                    resultAmount = amount * ExchangeRate;
                    resultText = $"Amount in NOK: {resultAmount:F2}";
                }
                else // Krone to Hryvnia
                {
                    resultAmount = amount / ExchangeRate;
                    resultText = $"Amount in UAH: {resultAmount:F2}";
                }

                lblResult.Text = resultText;
            }
            else
            {
                MessageBox.Show("Please enter a valid amount.");
            }
        }

        private void comboConversionDirection_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear result label and input field when the direction is changed
            lblResult.Text = string.Empty;
            txtHryvniaAmount.Text = string.Empty;
            btnOk.Enabled = false;
        }
    }
}
