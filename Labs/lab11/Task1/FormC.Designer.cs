namespace MultiWindowApp
{
    partial class FormC
    {
        private System.ComponentModel.IContainer components = null;
        private Button buttonOpenFormF;

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
            this.buttonOpenFormF = new Button();

            // Кнопка для відкриття FormF
            this.buttonOpenFormF.Text = "Відкрити Форму F";
            this.buttonOpenFormF.Click += new EventHandler(this.buttonOpenFormF_Click);
            this.buttonOpenFormF.Location = new System.Drawing.Point(30, 30);

            // FormC
            this.ClientSize = new System.Drawing.Size(200, 150);
            this.Controls.Add(this.buttonOpenFormF);
            this.Name = "FormC";
        }
    }
}
