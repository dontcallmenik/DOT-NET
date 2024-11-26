using System;
using System.Windows.Forms;

namespace UserMessageApp
{
    public partial class ViewMessageForm : Form
    {
        public ViewMessageForm(string message)
        {
            InitializeComponent();
            lblMessage.Text = message;
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }
    }
}
