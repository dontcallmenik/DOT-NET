using System;
using System.Windows.Forms;

namespace CalculationApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSingleForm_Click(object sender, EventArgs e)
        {
            var form = new InputAndOutputForm();
            form.Show();
        }

        private void btnSeparateInputOutput_Click(object sender, EventArgs e)
        {
            var inputForm = new SeparateInputForm();
            var outputForm = new SeparateOutputForm();

            inputForm.OnInputSubmitted += (x, y, z) =>
            {
                outputForm.DisplayResult(x, y, z);
                outputForm.Show();
            };

            inputForm.Show();
        }
    }
}
