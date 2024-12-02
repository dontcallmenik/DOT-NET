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
            this.Text = "����� A";
            this.BackColor = System.Drawing.Color.LightBlue;
        }

        private void buttonOpenFormB_Click(object sender, EventArgs e)
        {
            FormB formB = new FormB("����� A");
            if (formB.ShowDialog() == DialogResult.OK)
            {
                labelInfo.Text = "����������� �� ����� B: " + formB.ReturnMessage;
            }
        }

        private void buttonOpenFormC_Click(object sender, EventArgs e)
        {
            FormC formC = new FormC("����� A");
            if (formC.ShowDialog() == DialogResult.OK)
            {
                labelInfo.Text = "����������� �� ����� C: " + formC.ReturnMessage;
            }
        }

        private void buttonOpenFormD_Click(object sender, EventArgs e)
        {
            FormD formD = new FormD("����� A");
            if (formD.ShowDialog() == DialogResult.OK)
            {
                labelInfo.Text = "����������� �� ����� D: " + formD.ReturnMessage;
            }
        }
    }
}
