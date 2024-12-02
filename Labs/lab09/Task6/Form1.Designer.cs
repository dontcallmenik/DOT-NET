namespace Task6
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

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
            this.checkBoxLighting = new System.Windows.Forms.CheckBox();
            this.checkBoxSound = new System.Windows.Forms.CheckBox();
            this.checkBoxDecoration = new System.Windows.Forms.CheckBox();
            this.checkBoxCatering = new System.Windows.Forms.CheckBox();
            this.labelBasePrice = new System.Windows.Forms.Label();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.comboBoxCurrency = new System.Windows.Forms.ComboBox();
            this.labelConvertedPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // checkBoxLighting
            this.checkBoxLighting.AutoSize = true;
            this.checkBoxLighting.Location = new System.Drawing.Point(20, 50);
            this.checkBoxLighting.Name = "checkBoxLighting";
            this.checkBoxLighting.Size = new System.Drawing.Size(80, 17);
            this.checkBoxLighting.Text = "Освітлення";
            this.checkBoxLighting.UseVisualStyleBackColor = true;

            // checkBoxSound
            this.checkBoxSound.AutoSize = true;
            this.checkBoxSound.Location = new System.Drawing.Point(20, 80);
            this.checkBoxSound.Name = "checkBoxSound";
            this.checkBoxSound.Size = new System.Drawing.Size(80, 17);
            this.checkBoxSound.Text = "Звукова система";
            this.checkBoxSound.UseVisualStyleBackColor = true;

            // checkBoxDecoration
            this.checkBoxDecoration.AutoSize = true;
            this.checkBoxDecoration.Location = new System.Drawing.Point(20, 110);
            this.checkBoxDecoration.Name = "checkBoxDecoration";
            this.checkBoxDecoration.Size = new System.Drawing.Size(80, 17);
            this.checkBoxDecoration.Text = "Оформлення залу";
            this.checkBoxDecoration.UseVisualStyleBackColor = true;

            // checkBoxCatering
            this.checkBoxCatering.AutoSize = true;
            this.checkBoxCatering.Location = new System.Drawing.Point(20, 140);
            this.checkBoxCatering.Name = "checkBoxCatering";
            this.checkBoxCatering.Size = new System.Drawing.Size(80, 17);
            this.checkBoxCatering.Text = "Кейтеринг";
            this.checkBoxCatering.UseVisualStyleBackColor = true;

            // labelBasePrice
            this.labelBasePrice.AutoSize = true;
            this.labelBasePrice.Location = new System.Drawing.Point(20, 20);
            this.labelBasePrice.Name = "labelBasePrice";
            this.labelBasePrice.Size = new System.Drawing.Size(100, 13);
            this.labelBasePrice.Text = "Базова ціна: 20000 грн";

            // labelTotalPrice
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Location = new System.Drawing.Point(20, 180);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(100, 13);
            this.labelTotalPrice.Text = "Загальна ціна: ";

            // buttonCalculate
            this.buttonCalculate.Location = new System.Drawing.Point(20, 210);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.Text = "Розрахувати";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);

            // comboBoxCurrency
            this.comboBoxCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCurrency.FormattingEnabled = true;
            this.comboBoxCurrency.Items.AddRange(new object[] {
            "USD",
            "EUR"});
            this.comboBoxCurrency.Location = new System.Drawing.Point(20, 240);
            this.comboBoxCurrency.Name = "comboBoxCurrency";
            this.comboBoxCurrency.Size = new System.Drawing.Size(100, 21);
            this.comboBoxCurrency.SelectedIndexChanged += new System.EventHandler(this.comboBoxCurrency_SelectedIndexChanged);

            // labelConvertedPrice
            this.labelConvertedPrice.AutoSize = true;
            this.labelConvertedPrice.Location = new System.Drawing.Point(20, 270);
            this.labelConvertedPrice.Name = "labelConvertedPrice";
            this.labelConvertedPrice.Size = new System.Drawing.Size(150, 13);
            this.labelConvertedPrice.Text = "Виберіть валюту для конвертації.";

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.checkBoxLighting);
            this.Controls.Add(this.checkBoxSound);
            this.Controls.Add(this.checkBoxDecoration);
            this.Controls.Add(this.checkBoxCatering);
            this.Controls.Add(this.labelBasePrice);
            this.Controls.Add(this.labelTotalPrice);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.comboBoxCurrency);
            this.Controls.Add(this.labelConvertedPrice);
            this.Name = "Form1";
            this.Text = "Розрахунок ціни оренди";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.CheckBox checkBoxLighting;
        private System.Windows.Forms.CheckBox checkBoxSound;
        private System.Windows.Forms.CheckBox checkBoxDecoration;
        private System.Windows.Forms.CheckBox checkBoxCatering;
        private System.Windows.Forms.Label labelBasePrice;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.ComboBox comboBoxCurrency;
        private System.Windows.Forms.Label labelConvertedPrice;
    }
}
