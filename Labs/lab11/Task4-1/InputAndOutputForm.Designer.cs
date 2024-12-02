namespace CalculationApp
{
    partial class InputAndOutputForm
    {
        private TextBox txtX;
        private TextBox txtY;
        private TextBox txtZ;
        private Label lblResult;
        private Button btnCalculate;

        private void InitializeComponent()
        {
            this.txtX = new TextBox();
            this.txtY = new TextBox();
            this.txtZ = new TextBox();
            this.lblResult = new Label();
            this.btnCalculate = new Button();

            // TextBox and Label setup omitted for brevity.

            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.Click += new EventHandler(this.btnCalculate_Click);

            // Form setup code here to position controls and set text, etc.
        }
    }
}
