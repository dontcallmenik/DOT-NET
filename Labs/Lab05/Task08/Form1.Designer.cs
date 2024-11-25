using System.Windows.Forms;
using System;

namespace ProductPriceCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.calculateButton = new System.Windows.Forms.Button();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.radioButtonSmall = new System.Windows.Forms.RadioButton();
            this.radioButtonMedium = new System.Windows.Forms.RadioButton();
            this.radioButtonLarge = new System.Windows.Forms.RadioButton();
            this.radioButtonRetail = new System.Windows.Forms.RadioButton();
            this.radioButtonWholesale = new System.Windows.Forms.RadioButton();
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

            // 
            // radioButtonRetail
            // 
            this.radioButtonRetail.AutoSize = true;
            this.radioButtonRetail.Location = new System.Drawing.Point(250, 20);
            this.radioButtonRetail.Name = "radioButtonRetail";
            this.radioButtonRetail.Size = new System.Drawing.Size(80, 20);
            this.radioButtonRetail.TabIndex = 5;
            this.radioButtonRetail.TabStop = true;
            this.radioButtonRetail.Text = "Роздрібна";
            this.radioButtonRetail.UseVisualStyleBackColor = true;

            // 
            // radioButtonWholesale
            // 
            this.radioButtonWholesale.AutoSize = true;
            this.radioButtonWholesale.Location = new System.Drawing.Point(250, 60);
            this.radioButtonWholesale.Name = "radioButtonWholesale";
            this.radioButtonWholesale.Size = new System.Drawing.Size(80, 20);
            this.radioButtonWholesale.TabIndex = 6;
            this.radioButtonWholesale.TabStop = true;
            this.radioButtonWholesale.Text = "Оптова";
            this.radioButtonWholesale.UseVisualStyleBackColor = true;

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
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.radioButtonSmall);
            this.Controls.Add(this.radioButtonMedium);
            this.Controls.Add(this.radioButtonLarge);
            this.Controls.Add(this.radioButtonRetail);
            this.Controls.Add(this.radioButtonWholesale);
            this.Name = "Form1";
            this.Text = "Калькулятор ціни";
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double unitPrice = 0;
            double totalPrice = 0;
            int quantity = 0;

            // Перевірка чи введено правильну кількість
            if (int.TryParse(quantityTextBox.Text, out quantity) && quantity > 0)
            {
                // Визначення ціни залежно від розміру
                if (radioButtonSmall.Checked)
                    unitPrice = 100; // ціна для малого продукту
                else if (radioButtonMedium.Checked)
                    unitPrice = 200; // ціна для середнього продукту
                else if (radioButtonLarge.Checked)
                    unitPrice = 300; // ціна для великого продукту

                // Визначення ціни в залежності від вибору (роздріб чи опт)
                if (radioButtonWholesale.Checked)
                {
                    unitPrice *= 0.9; // Знижка 10% для оптової ціни
                }
                else if (radioButtonRetail.Checked)
                {
                    unitPrice *= 1; // Роздрібна ціна без змін
                }

                // Розрахунок загальної ціни
                totalPrice = unitPrice * quantity;

                // Виведення результату
                totalPriceLabel.Text = "Загальна ціна: " + totalPrice.ToString("0.00") + " грн";
            }
            else
            {
                MessageBox.Show("Будь ласка, введіть правильну кількість.");
            }
        }
    }
}
