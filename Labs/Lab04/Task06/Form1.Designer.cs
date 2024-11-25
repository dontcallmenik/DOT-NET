namespace ProductPriceCalculator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Очистка всех используемых ресурсов.
        /// </summary>
        /// <param name="disposing">Если значение true, удаляет все управляемые ресурсы; в противном случае — не удаляет.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором окна

        private void InitializeComponent()
        {
            this.calculateButton = new System.Windows.Forms.Button();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.radioButtonSmall = new System.Windows.Forms.RadioButton();
            this.radioButtonMedium = new System.Windows.Forms.RadioButton();
            this.radioButtonLarge = new System.Windows.Forms.RadioButton();
            this.radioButtonEconomy = new System.Windows.Forms.RadioButton();
            this.radioButtonStandard = new System.Windows.Forms.RadioButton();
            this.radioButtonPremium = new System.Windows.Forms.RadioButton();
            this.radioButtonDelivery = new System.Windows.Forms.RadioButton();
            this.radioButtonGiftWrapping = new System.Windows.Forms.RadioButton();
            this.radioButtonInstallation = new System.Windows.Forms.RadioButton();
            this.quantityTextBox = new System.Windows.Forms.TextBox(); // Добавляем поле для ввода количества
            this.labelQuantity = new System.Windows.Forms.Label(); // Добавляем лейбл для количества

            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(150, 300);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(100, 30);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Розрахувати";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);

            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Location = new System.Drawing.Point(150, 340);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(100, 20);
            this.totalPriceLabel.TabIndex = 1;
            this.totalPriceLabel.Text = "Загальна ціна: 0 грн";

            // 
            // radioButtonSmall
            // 
            this.radioButtonSmall.AutoSize = true;
            this.radioButtonSmall.Location = new System.Drawing.Point(20, 20);
            this.radioButtonSmall.Name = "radioButtonSmall";
            this.radioButtonSmall.Size = new System.Drawing.Size(75, 20);
            this.radioButtonSmall.TabIndex = 2;
            this.radioButtonSmall.TabStop = true;
            this.radioButtonSmall.Text = "Малий";
            this.radioButtonSmall.UseVisualStyleBackColor = true;

            // 
            // radioButtonMedium
            // 
            this.radioButtonMedium.AutoSize = true;
            this.radioButtonMedium.Location = new System.Drawing.Point(20, 60);
            this.radioButtonMedium.Name = "radioButtonMedium";
            this.radioButtonMedium.Size = new System.Drawing.Size(77, 20);
            this.radioButtonMedium.TabIndex = 3;
            this.radioButtonMedium.TabStop = true;
            this.radioButtonMedium.Text = "Середній";
            this.radioButtonMedium.UseVisualStyleBackColor = true;

            // 
            // radioButtonLarge
            // 
            this.radioButtonLarge.AutoSize = true;
            this.radioButtonLarge.Location = new System.Drawing.Point(20, 100);
            this.radioButtonLarge.Name = "radioButtonLarge";
            this.radioButtonLarge.Size = new System.Drawing.Size(65, 20);
            this.radioButtonLarge.TabIndex = 4;
            this.radioButtonLarge.TabStop = true;
            this.radioButtonLarge.Text = "Великий";
            this.radioButtonLarge.UseVisualStyleBackColor = true;

            // Добавляем другие элементы (упаковка, услуги и т. д.)

            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(150, 260);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantityTextBox.TabIndex = 11;

            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(50, 260);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(80, 20);
            this.labelQuantity.TabIndex = 12;
            this.labelQuantity.Text = "Кількість:";

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.radioButtonSmall);
            this.Controls.Add(this.radioButtonMedium);
            this.Controls.Add(this.radioButtonLarge);
            // Добавляем остальные элементы на форму
            this.Name = "Form1";
            this.Text = "Калькулятор ціни";
        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.RadioButton radioButtonSmall;
        private System.Windows.Forms.RadioButton radioButtonMedium;
        private System.Windows.Forms.RadioButton radioButtonLarge;
        private System.Windows.Forms.RadioButton radioButtonEconomy;
        private System.Windows.Forms.RadioButton radioButtonStandard;
        private System.Windows.Forms.RadioButton radioButtonPremium;
        private System.Windows.Forms.RadioButton radioButtonDelivery;
        private System.Windows.Forms.RadioButton radioButtonGiftWrapping;
        private System.Windows.Forms.RadioButton radioButtonInstallation;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label labelQuantity;
    }
}
