namespace CitySelector
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private ComboBox comboBoxCities;
        private Button btnShowCityInfo;

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
            this.comboBoxCities = new ComboBox();
            this.btnShowCityInfo = new Button();

            // ComboBox for cities
            this.comboBoxCities.Location = new System.Drawing.Point(30, 30);
            this.comboBoxCities.Name = "comboBoxCities";
            this.comboBoxCities.Size = new System.Drawing.Size(200, 25);

            // Button to show city info
            this.btnShowCityInfo.Location = new System.Drawing.Point(30, 80);
            this.btnShowCityInfo.Name = "btnShowCityInfo";
            this.btnShowCityInfo.Size = new System.Drawing.Size(100, 30);
            this.btnShowCityInfo.Text = "Show Info";
            this.btnShowCityInfo.UseVisualStyleBackColor = true;
            this.btnShowCityInfo.Click += new System.EventHandler(this.btnShowCityInfo_Click);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 150);
            this.Controls.Add(this.comboBoxCities);
            this.Controls.Add(this.btnShowCityInfo);
            this.Name = "Form1";
            this.Text = "City Selector";
            this.ResumeLayout(false);
        }
    }
}
