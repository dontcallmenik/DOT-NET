using System;
using System.Windows.Forms;

namespace CalculationApp
{
    public partial class SeparateInputForm : Form
    {
        public event Action<int, int, int> OnInputSubmitted;

        public SeparateInputForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtX.Text, out int x) && int.TryParse(txtY.Text, out int y) && int.TryParse(txtZ.Text, out int z))
            {
                // Trigger the event to pass input data to SeparateOutputForm
                OnInputSubmitted?.Invoke(x, y, z);
                this.Close(); // Close the input form
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter integers for x, y, and z.");
            }
        }
    }
}
