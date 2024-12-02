namespace MultiWindowApp
{
    partial class FormA
    {
        private System.ComponentModel.IContainer components = null;
        private Button buttonOpenFormB;
        private Button buttonOpenFormC;
        private Button buttonOpenFormD;
        private Label labelInfo;

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
            this.buttonOpenFormB = new Button();
            this.buttonOpenFormC = new Button();
            this.buttonOpenFormD = new Button();
            this.labelInfo = new Label();

            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(30, 150);
            this.labelInfo.Text = "Інформація від інших форм:";

            this.buttonOpenFormB.Text = "Відкрити Форму B";
            this.buttonOpenFormB.Click += new EventHandler(this.buttonOpenFormB_Click);
            this.buttonOpenFormB.Location = new System.Drawing.Point(30, 30);

            this.buttonOpenFormC.Text = "Відкрити Форму C";
            this.buttonOpenFormC.Click += new EventHandler(this.buttonOpenFormC_Click);
            this.buttonOpenFormC.Location = new System.Drawing.Point(30, 70);

            this.buttonOpenFormD.Text = "Відкрити Форму D";
            this.buttonOpenFormD.Click += new EventHandler(this.buttonOpenFormD_Click);
            this.buttonOpenFormD.Location = new System.Drawing.Point(30, 110);

            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.buttonOpenFormB);
            this.Controls.Add(this.buttonOpenFormC);
            this.Controls.Add(this.buttonOpenFormD);
            this.Controls.Add(this.labelInfo);
            this.Name = "FormA";
        }
    }
}
