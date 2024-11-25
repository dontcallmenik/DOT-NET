namespace KeyPressExample
{
    partial class Form1
    {
        /// <summary>
        /// Обов'язкова змінна конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Очистити всі використовувані ресурси.
        /// </summary>
        /// <param name="disposing">Чи потрібно звільнити керовані ресурси.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, створений Конструктором Windows Forms

        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 100); // Розміщення текстового поля
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 22);
            this.textBox1.TabIndex = 0;

            // Додаємо обробник події KeyPress
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300); // Розмір форми
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "KeyPress Example";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
    }
}
