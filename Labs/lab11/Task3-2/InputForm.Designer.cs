namespace SquareCalculator
{
    partial class InputForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox sideTextBox;
        private System.Windows.Forms.Button submitButton;

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
            this.sideTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // sideTextBox
            this.sideTextBox.Location = new System.Drawing.Point(20, 20);
            this.sideTextBox.Name = "sideTextBox";
            this.sideTextBox.Size = new System.Drawing.Size(100, 20);

            // submitButton
            this.submitButton.Location = new System.Drawing.Point(140, 20);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.Text = "Calculate";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);

            // InputForm
            this.ClientSize = new System.Drawing.Size(284, 61);
            this.Controls.Add(this.sideTextBox);
            this.Controls.Add(this.submitButton);
            this.Name = "InputForm";
            this.Text = "Input Side";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
