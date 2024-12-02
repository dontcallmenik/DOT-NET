namespace CalculationApp
{
    partial class Form1
    {
        private Button btnSingleForm;
        private Button btnSeparateInputOutput;

        private void InitializeComponent()
        {
            this.btnSingleForm = new Button();
            this.btnSeparateInputOutput = new Button();

            // 
            // btnSingleForm
            // 
            this.btnSingleForm.Text = "Input and Output on Single Form";
            this.btnSingleForm.Click += new EventHandler(this.btnSingleForm_Click);

            // 
            // btnSeparateInputOutput
            // 
            this.btnSeparateInputOutput.Text = "Separate Input and Output Forms";
            this.btnSeparateInputOutput.Click += new EventHandler(this.btnSeparateInputOutput_Click);

            // 
            // Form1
            // 
            this.Controls.Add(this.btnSingleForm);
            this.Controls.Add(this.btnSeparateInputOutput);
            this.Text = "Calculation App";
            this.ResumeLayout(false);
        }
    }
}
