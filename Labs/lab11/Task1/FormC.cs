using System;
using System.Windows.Forms;


namespace MultiWindowApp
{
    public partial class FormC : Form
    {
        public FormC()
        {
            InitializeComponent();
            this.Text = "Форма C";
            this.BackColor = System.Drawing.Color.LightCoral; // Колір для FormC
        }

        private void buttonOpenFormF_Click(object sender, EventArgs e)
        {
            FormF formF = new FormF();
            formF.ShowDialog();
        }
    }
}
