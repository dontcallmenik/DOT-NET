namespace MouseEventsApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Label label1;
        private Label label2;
        private Label label3;

        /// <summary>
        /// Очищення ресурсів
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Ініціалізація компонентів
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new Label();
            this.label2 = new Label();
            this.label3 = new Label();
            this.SuspendLayout();

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            this.label1.Location = new Point(100, 50);
            this.label1.Text = "Рядок 1";
            this.label1.MouseDown += new MouseEventHandler(Label_MouseAction);
            this.label1.MouseUp += new MouseEventHandler(Label_MouseAction);

            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            this.label2.Location = new Point(100, 100);
            this.label2.Text = "Рядок 2";
            this.label2.MouseDown += new MouseEventHandler(Label_MouseAction);
            this.label2.MouseUp += new MouseEventHandler(Label_MouseAction);

            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            this.label3.Location = new Point(100, 150);
            this.label3.Text = "Рядок 3";
            this.label3.MouseDown += new MouseEventHandler(Label_MouseAction);
            this.label3.MouseUp += new MouseEventHandler(Label_MouseAction);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(300, 250);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "Mouse Events Example";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
