namespace MultiWindowApp
{
    partial class FormB
    {
        private System.ComponentModel.IContainer components = null;
        private Button buttonOpenFormE;

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
            this.buttonOpenFormE = new Button();

            // Кнопка для відкриття FormE
            this.buttonOpenFormE.Text = "Відкрити Форму E";
            this.buttonOpenFormE.Click += new EventHandler(this.buttonOpenFormE_Click);
            this.buttonOpenFormE.Location = new System.Drawing.Point(30, 30);

            // FormB
            this.ClientSize = new System.Drawing.Size(200, 150);
            this.Controls.Add(this.buttonOpenFormE);
            this.Name = "FormB";
        }
    }
}
