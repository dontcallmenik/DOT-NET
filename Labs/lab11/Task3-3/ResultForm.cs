using System.Windows.Forms;

namespace SquareCalculator
{
    public partial class ResultForm : Form
    {
        public ResultForm()
        {
            InitializeComponent();
        }

        public TextBox ResultTextBox
        {
            get { return resultTextBox; }
        }
    }
}
