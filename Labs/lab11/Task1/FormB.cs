using System;
using System.Windows.Forms;


namespace MultiWindowApp
{
    public partial class FormB : Form
    {
        public FormB()
        {
            InitializeComponent();
            this.Text = "Форма B";
            this.BackColor = System.Drawing.Color.LightGreen; // Колір для FormB
        }

        private void buttonOpenFormE_Click(object sender, EventArgs e)
        {
            FormE formE = new FormE();
            formE.ShowDialog();
        }
    }
}
