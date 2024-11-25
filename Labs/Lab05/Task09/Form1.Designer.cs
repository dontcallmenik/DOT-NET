namespace ProductPriceCalculator
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

        #region Код, автоматически созданный конструктором окна

        private void InitializeComponent()
        {
            this.calculateButton = new System.Windows.Forms.Button();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.sizeComboBox = new System.Windows.Forms.ComboBox();
            this.packagingComboBox = new System.Windows.Forms.ComboBox();
            this.deliveryCheckBox = new System.Windows.Forms.CheckBox();
            this.giftWrappingCheckBox = new System.Windows.Forms.CheckBox();
            this.installationCheckBox = new System.Windows.Forms.CheckBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.labelQuantity = new System.Windows.Forms.Label();

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
            // sizeComboBox
            // 
            this.sizeComboBox.FormattingEnabled = true;
            this.sizeComboBox.Items.AddRange(new object[] {
            "Малий",
            "Середній",
            "Великий"});
            this.sizeComboBox.Location = new System.Drawing.Point(150, 20);
            this.sizeComboBox.Name = "sizeComboBox";
            this.sizeComboBox.Size = new System.Drawing.Size(121, 21);
            this.sizeComboBox.TabIndex = 2;

            // 
            // packagingComboBox
            // 
            this.packagingComboBox.FormattingEnabled = true;
            this.packagingComboBox.Items.AddRange(new object[] {
            "Економ",
            "Стандарт",
            "Преміум"});
            this.packagingComboBox.Location = new System.Drawing.Point(150, 60);
            this.packagingComboBox.Name = "packagingComboBox";
            this.packagingComboBox.Size = new System.Drawing.Size(121, 21);
            this.packagingComboBox.TabIndex = 3;

            // 
            // deliveryCheckBox
            // 
            this.deliveryCheckBox.AutoSize = true;
            this.deliveryCheckBox.Location = new System.Drawing.Point(150, 100);
            this.deliveryCheckBox.Name = "deliveryCheckBox";
            this.deliveryCheckBox.Size = new System.Drawing.Size(84, 17);
            this.deliveryCheckBox.TabIndex = 4;
            this.deliveryCheckBox.Text = "Доставка (+40)";
            this.deliveryCheckBox.UseVisualStyleBackColor = true;

            // 
            // giftWrappingCheckBox
            // 
            this.giftWrappingCheckBox.AutoSize = true;
            this.giftWrappingCheckBox.Location = new System.Drawing.Point(150, 130);
            this.giftWrappingCheckBox.Name = "giftWrappingCheckBox";
            this.giftWrappingCheckBox.Size = new System.Drawing.Size(111, 17);
            this.giftWrappingCheckBox.TabIndex = 5;
            this.giftWrappingCheckBox.Text = "Пакування подарунка (+30)";
            this.giftWrappingCheckBox.UseVisualStyleBackColor = true;

            // 
            // installationCheckBox
            // 
            this.installationCheckBox.AutoSize = true;
            this.installationCheckBox.Location = new System.Drawing.Point(150, 160);
            this.installationCheckBox.Name = "installationCheckBox";
            this.installationCheckBox.Size = new System.Drawing.Size(106, 17);
            this.installationCheckBox.TabIndex = 6;
            this.installationCheckBox.Text = "Монтаж (+50)";
            this.installationCheckBox.UseVisualStyleBackColor = true;

            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(150, 260);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantityTextBox.TabIndex = 7;

            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(50, 260);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(80, 20);
            this.labelQuantity.TabIndex = 8;
            this.labelQuantity.Text = "Кількість:";

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.installationCheckBox);
            this.Controls.Add(this.giftWrappingCheckBox);
            this.Controls.Add(this.deliveryCheckBox);
            this.Controls.Add(this.packagingComboBox);
            this.Controls.Add(this.sizeComboBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.totalPriceLabel);
            this.Name = "Form1";
            this.Text = "Калькулятор ціни";
        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.ComboBox sizeComboBox;
        private System.Windows.Forms.ComboBox packagingComboBox;
        private System.Windows.Forms.CheckBox deliveryCheckBox;
        private System.Windows.Forms.CheckBox giftWrappingCheckBox;
        private System.Windows.Forms.CheckBox installationCheckBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label labelQuantity;
    }
}
