namespace CitySelector
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;
        private PictureBox pictureBoxCityPhoto;
        private Label labelCityDescription;

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
            this.pictureBoxCityPhoto = new PictureBox();
            this.labelCityDescription = new Label();

            // PictureBox for city photo
            this.pictureBoxCityPhoto.Location = new System.Drawing.Point(30, 30);
            this.pictureBoxCityPhoto.Name = "pictureBoxCityPhoto";
            this.pictureBoxCityPhoto.Size = new System.Drawing.Size(200, 150);

            // Label for city description
            this.labelCityDescription.Location = new System.Drawing.Point(30, 200);
            this.labelCityDescription.Name = "labelCityDescription";
            this.labelCityDescription.Size = new System.Drawing.Size(200, 50);

            // Form2
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.pictureBoxCityPhoto);
            this.Controls.Add(this.labelCityDescription);
            this.Name = "Form2";
            this.Text = "City Information";
            this.ResumeLayout(false);
        }
    }
}
