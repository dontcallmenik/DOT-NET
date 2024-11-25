namespace CarConfiguration
{
    partial class CarConfigurationForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Очистка всех используемых ресурсов.
        /// </summary>
        /// <param name="disposing">истинно, если управляемые ресурсы должны быть удалены; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте
        /// его содержимое с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.carModelLabel = new System.Windows.Forms.Label();
            this.carMatsCheckBox = new System.Windows.Forms.CheckBox();
            this.engineGuardCheckBox = new System.Windows.Forms.CheckBox();
            this.winterTiresCheckBox = new System.Windows.Forms.CheckBox();
            this.alloyWheelsCheckBox = new System.Windows.Forms.CheckBox();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // carModelLabel
            // 
            this.carModelLabel.AutoSize = true;
            this.carModelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.carModelLabel.Location = new System.Drawing.Point(20, 20);
            this.carModelLabel.Name = "carModelLabel";
            this.carModelLabel.Size = new System.Drawing.Size(176, 20);
            this.carModelLabel.TabIndex = 0;
            this.carModelLabel.Text = "Модель автомобиля";
            // 
            // carMatsCheckBox
            // 
            this.carMatsCheckBox.AutoSize = true;
            this.carMatsCheckBox.Location = new System.Drawing.Point(25, 60);
            this.carMatsCheckBox.Name = "carMatsCheckBox";
            this.carMatsCheckBox.Size = new System.Drawing.Size(150, 17);
            this.carMatsCheckBox.TabIndex = 1;
            this.carMatsCheckBox.Text = "Коврики (+5000 грн)";
            this.carMatsCheckBox.UseVisualStyleBackColor = true;
            this.carMatsCheckBox.CheckedChanged += new System.EventHandler(this.carMatsCheckBox_CheckedChanged);
            // 
            // engineGuardCheckBox
            // 
            this.engineGuardCheckBox.AutoSize = true;
            this.engineGuardCheckBox.Location = new System.Drawing.Point(25, 90);
            this.engineGuardCheckBox.Name = "engineGuardCheckBox";
            this.engineGuardCheckBox.Size = new System.Drawing.Size(198, 17);
            this.engineGuardCheckBox.TabIndex = 2;
            this.engineGuardCheckBox.Text = "Защита двигателя (+10000 грн)";
            this.engineGuardCheckBox.UseVisualStyleBackColor = true;
            this.engineGuardCheckBox.CheckedChanged += new System.EventHandler(this.engineGuardCheckBox_CheckedChanged);
            // 
            // winterTiresCheckBox
            // 
            this.winterTiresCheckBox.AutoSize = true;
            this.winterTiresCheckBox.Location = new System.Drawing.Point(25, 120);
            this.winterTiresCheckBox.Name = "winterTiresCheckBox";
            this.winterTiresCheckBox.Size = new System.Drawing.Size(176, 17);
            this.winterTiresCheckBox.TabIndex = 3;
            this.winterTiresCheckBox.Text = "Зимние шины (+20000 грн)";
            this.winterTiresCheckBox.UseVisualStyleBackColor = true;
            this.winterTiresCheckBox.CheckedChanged += new System.EventHandler(this.winterTiresCheckBox_CheckedChanged);
            // 
            // alloyWheelsCheckBox
            // 
            this.alloyWheelsCheckBox.AutoSize = true;
            this.alloyWheelsCheckBox.Location = new System.Drawing.Point(25, 150);
            this.alloyWheelsCheckBox.Name = "alloyWheelsCheckBox";
            this.alloyWheelsCheckBox.Size = new System.Drawing.Size(185, 17);
            this.alloyWheelsCheckBox.TabIndex = 4;
            this.alloyWheelsCheckBox.Text = "Легкосплавные диски (+15000 грн)";
            this.alloyWheelsCheckBox.UseVisualStyleBackColor = true;
            this.alloyWheelsCheckBox.CheckedChanged += new System.EventHandler(this.alloyWheelsCheckBox_CheckedChanged);
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.totalPriceLabel.Location = new System.Drawing.Point(25, 200);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(215, 17);
            this.totalPriceLabel.TabIndex = 5;
            this.totalPriceLabel.Text = "Ціна у вибраній комплектації:";
            // 
            // CarConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.alloyWheelsCheckBox);
            this.Controls.Add(this.winterTiresCheckBox);
            this.Controls.Add(this.engineGuardCheckBox);
            this.Controls.Add(this.carMatsCheckBox);
            this.Controls.Add(this.carModelLabel);
            this.Name = "CarConfigurationForm";
            this.Text = "Конфигуратор автомобиля";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label carModelLabel;
        private System.Windows.Forms.CheckBox carMatsCheckBox;
        private System.Windows.Forms.CheckBox engineGuardCheckBox;
        private System.Windows.Forms.CheckBox winterTiresCheckBox;
        private System.Windows.Forms.CheckBox alloyWheelsCheckBox;
        private System.Windows.Forms.Label totalPriceLabel;
    }
}
