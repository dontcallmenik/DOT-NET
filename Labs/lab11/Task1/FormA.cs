using System;
using System.Windows.Forms;

namespace MultiWindowApp
{
    public partial class FormA : Form
    {
        public FormA()
        {
            InitializeComponent();
            this.Text = "Форма A";
            this.BackColor = System.Drawing.Color.LightBlue; // Колір для FormA
        }

        private void buttonOpenFormB_Click(object sender, EventArgs e)
        {
            FormB formB = new FormB();
            formB.ShowDialog();
        }

        private void buttonOpenFormC_Click(object sender, EventArgs e)
        {
            FormC formC = new FormC();
            formC.ShowDialog();
        }

        private void buttonOpenFormD_Click(object sender, EventArgs e)
        {
            FormD formD = new FormD();
            formD.ShowDialog();
        }
    }
}
