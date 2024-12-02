using System;
using System.Windows.Forms;
using static System.Runtime.InteropServices.Marshalling.IIUnknownCacheStrategy;

namespace MultiWindowApp
{
    public partial class FormA : Form
    {
        public FormA()
        {
            InitializeComponent();
            this.Text = "Форма A";
            this.BackColor = System.Drawing.Color.LightBlue;
        }

        private void buttonOpenFormB_Click(object sender, EventArgs e)
        {
            FormB formB = new FormB("Форма A");
            if (formB.ShowDialog() == DialogResult.OK)
            {
                labelInfo.Text = "Повідомлення від Форми B: " + formB.ReturnMessage;
            }
        }

        private void buttonOpenFormC_Click(object sender, EventArgs e)
        {
            FormC formC = new FormC("Форма A");
            if (formC.ShowDialog() == DialogResult.OK)
            {
                labelInfo.Text = "Повідомлення від Форми C: " + formC.ReturnMessage;
            }
        }

        private void buttonOpenFormD_Click(object sender, EventArgs e)
        {
            FormD formD = new FormD("Форма A");
            if (formD.ShowDialog() == DialogResult.OK)
            {
                labelInfo.Text = "Повідомлення від Форми D: " + formD.ReturnMessage;
            }
        }
    }
}
