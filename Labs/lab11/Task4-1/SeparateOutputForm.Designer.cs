namespace CalculationApp
{
    partial class SeparateOutputForm
    {
        private System.Windows.Forms.Label lblResult;

        private void InitializeComponent()
        {
            this.lblResult = new System.Windows.Forms.Label();

            // Label for Result
            this.lblResult.Text = "Result: ";
            this.lblResult.Location = new System.Drawing.Point(10, 10);
            this.lblResult.Size = new System.Drawing.Size(300, 25);
            this.Controls.Add(this.lblResult);

            // SeparateOutputForm
            this.ClientSize = new System.Drawing.Size(300, 50);
            this.Text = "Output Form";
            this.ResumeLayout(false);
        }
    }
}
