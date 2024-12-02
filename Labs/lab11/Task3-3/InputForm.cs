using System;
using System.Windows.Forms;

namespace SquareCalculator
{
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
        }

        public TextBox SideTextBox
        {
            get { return sideTextBox; }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
