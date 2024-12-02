using System;
using System.Windows.Forms;

namespace FinancialCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            listViewPayments.Items.Clear();

            // Input values
            if (decimal.TryParse(txtAmount.Text, out decimal amount) &&
                int.TryParse(txtTerm.Text, out int term) &&
                decimal.TryParse(txtInterestRate.Text, out decimal interestRate))
            {
                decimal monthlyRate = interestRate / 12 / 100;
                decimal balance = amount;

                for (int month = 1; month <= term; month++)
                {
                    decimal interestPayment = balance * monthlyRate;
                    decimal principalPayment = amount / term;
                    decimal totalPayment = principalPayment + interestPayment;
                    balance -= principalPayment;

                    // Add row to ListView
                    var item = new ListViewItem(month.ToString());
                    item.SubItems.Add(balance.ToString("F2"));
                    item.SubItems.Add(interestPayment.ToString("F2"));
                    item.SubItems.Add(totalPayment.ToString("F2"));
                    listViewPayments.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("Please enter valid values for all fields.");
            }
        }
    }
}
