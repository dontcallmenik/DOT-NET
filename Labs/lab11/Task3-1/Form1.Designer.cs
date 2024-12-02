namespace SquareCalculator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox sideTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox resultTextBox;

        // Очищення ресурсів форми
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Ініціалізація компонентів
        private void InitializeComponent()
        {
            this.sideTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            // sideTextBox
            this.sideTextBox.Location = new System.Drawing.Point(20, 20);
            this.sideTextBox.Name = "sideTextBox";
            this.sideTextBox.Size = new System.Drawing.Size(100, 20);

            // calculateButton
            this.calculateButton.Location = new System.Drawing.Point(140, 20);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);

            // resultTextBox
            this.resultTextBox.Location = new System.Drawing.Point(20, 60);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Size = new System.Drawing.Size(200, 50);
            this.resultTextBox.ReadOnly = true;

            // Form1
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.sideTextBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.resultTextBox);
            this.Name = "Form1";
            this.Text = "Square Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
