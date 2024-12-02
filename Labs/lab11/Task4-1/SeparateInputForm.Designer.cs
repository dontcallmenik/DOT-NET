namespace CalculationApp
{
    partial class SeparateInputForm
    {
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtZ;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblZ;

        private void InitializeComponent()
        {
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtZ = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblZ = new System.Windows.Forms.Label();

            // Label X
            this.lblX.Text = "Enter x:";
            this.lblX.Location = new System.Drawing.Point(10, 10);
            this.Controls.Add(this.lblX);

            // TextBox X
            this.txtX.Location = new System.Drawing.Point(80, 10);
            this.Controls.Add(this.txtX);

            // Label Y
            this.lblY.Text = "Enter y:";
            this.lblY.Location = new System.Drawing.Point(10, 40);
            this.Controls.Add(this.lblY);

            // TextBox Y
            this.txtY.Location = new System.Drawing.Point(80, 40);
            this.Controls.Add(this.txtY);

            // Label Z
            this.lblZ.Text = "Enter z:";
            this.lblZ.Location = new System.Drawing.Point(10, 70);
            this.Controls.Add(this.lblZ);

            // TextBox Z
            this.txtZ.Location = new System.Drawing.Point(80, 70);
            this.Controls.Add(this.txtZ);

            // Submit Button
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Location = new System.Drawing.Point(50, 100);
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            this.Controls.Add(this.btnSubmit);

            // SeparateInputForm
            this.ClientSize = new System.Drawing.Size(200, 150);
            this.Text = "Input Form";
            this.ResumeLayout(false);
        }
    }
}
