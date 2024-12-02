using System;
using System.Windows.Forms;

namespace MultiWindowApp
{
    public partial class FormC : Form
    {
        public string ReturnMessage { get; private set; }

        public FormC(string message)
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
