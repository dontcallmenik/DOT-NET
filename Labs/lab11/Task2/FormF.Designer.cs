namespace MultiWindowApp
{
    partial class FormF
    {
        private System.ComponentModel.IContainer components = null;
        private Label labelInfo;
        private TextBox textBoxInput;
        private Button buttonSubmit;

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
            this.labelInfo = new Label();
            this.textBoxInput = new TextBox();
            this.buttonSubmit = new Button();

            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(30, 30);
            this.labelInfo.Text = "Повідомлення від викликаючої форми:";

            this.textBoxInput.Location = new System.Drawing.Point(30, 60);
            this.textBoxInput.Size = new System.Drawing.Size(200, 20);

            this.buttonSubmit.Text = "Надіслати відповідь";
            this.buttonSubmit.Click += new EventHandler(this.buttonSubmit_Click);
            this.buttonSubmit.Location = new System.Drawing.Point(30, 100);

            this.ClientSize = new System.Drawing.Size(300, 150);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.buttonSubmit);
            this.Name = "FormF";
        }
    }
}
