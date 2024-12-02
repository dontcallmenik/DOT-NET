namespace SquareCalculator
{
    partial class ResultForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox resultTextBox;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            // resultTextBox
            this.resultTextBox.Location = new System.Drawing.Point(20, 20);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(200, 60);
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.TabIndex = 0;

            // ResultForm
            this.ClientSize = new System.Drawing.Size(240, 100);
            this.Controls.Add(this.resultTextBox);
            this.Name = "ResultForm";
            this.Text = "Results";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
