namespace SquareCalculator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button openInputFormButton;
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
            this.openInputFormButton = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            // openInputFormButton
            this.openInputFormButton.Location = new System.Drawing.Point(20, 20);
            this.openInputFormButton.Name = "openInputFormButton";
            this.openInputFormButton.Size = new System.Drawing.Size(100, 23);
            this.openInputFormButton.Text = "Enter Side";
            this.openInputFormButton.UseVisualStyleBackColor = true;
            this.openInputFormButton.Click += new System.EventHandler(this.openInputFormButton_Click);

            // resultTextBox
            this.resultTextBox.Location = new System.Drawing.Point(20, 60);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Size = new System.Drawing.Size(200, 50);
            this.resultTextBox.ReadOnly = true;

            // Form1
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.openInputFormButton);
            this.Controls.Add(this.resultTextBox);
            this.Name = "Form1";
            this.Text = "Square Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
