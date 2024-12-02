namespace SquareCalculator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button openInputFormButton;

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
            this.SuspendLayout();

            // openInputFormButton
            this.openInputFormButton.Location = new System.Drawing.Point(20, 20);
            this.openInputFormButton.Name = "openInputFormButton";
            this.openInputFormButton.Size = new System.Drawing.Size(120, 30);
            this.openInputFormButton.Text = "Enter Side Length";
            this.openInputFormButton.UseVisualStyleBackColor = true;
            this.openInputFormButton.Click += new System.EventHandler(this.openInputFormButton_Click);

            // Form1
            this.ClientSize = new System.Drawing.Size(160, 80);
            this.Controls.Add(this.openInputFormButton);
            this.Name = "Form1";
            this.Text = "Square Calculator";
            this.ResumeLayout(false);
        }
    }
}
