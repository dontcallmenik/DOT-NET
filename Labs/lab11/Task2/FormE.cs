using System;
using System.Windows.Forms;

namespace MultiWindowApp
{
    public partial class FormE : Form
    {
        public string ReturnMessage { get; private set; }

        public FormE(string message)
        {
            InitializeComponent();
            this.Text = "Форма B";
            this.BackColor = System.Drawing.Color.LightGreen;
            labelInfo.Text = "Викликано з " + message;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            ReturnMessage = textBoxInput.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
