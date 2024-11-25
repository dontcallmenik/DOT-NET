namespace Task02
{
    partial class Form1
    {
        /// <summary>
        /// Требуемый дизайнер.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Очистка ресурсов, используемых компонентами.
        /// </summary>
        /// <param name="disposing">Если true, уничтожаются все компоненты.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, созданный конструктором конструктора формы

        /// <summary>
        /// Требуется для поддержки конструктора форм.
        /// Не изменяйте содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.TextBox3 = new System.Windows.Forms.TextBox();
            this.ButtonOk = new System.Windows.Forms.Button();
            this.ButtonConvertBack = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(150, 30);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(100, 20);
            this.TextBox1.TabIndex = 0;
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(150, 60);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.ReadOnly = true;
            this.TextBox2.Size = new System.Drawing.Size(100, 20);
            this.TextBox2.TabIndex = 1;
            // 
            // TextBox3
            // 
            this.TextBox3.Location = new System.Drawing.Point(150, 90);
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.Size = new System.Drawing.Size(100, 20);
            this.TextBox3.TabIndex = 2;
            // 
            // ButtonOk
            // 
            this.ButtonOk.Location = new System.Drawing.Point(150, 120);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new System.Drawing.Size(75, 23);
            this.ButtonOk.TabIndex = 3;
            this.ButtonOk.Text = "ОК";
            this.ButtonOk.UseVisualStyleBackColor = true;
            this.ButtonOk.Click += new System.EventHandler(this.ButtonOk_Click);
            // 
            // ButtonConvertBack
            // 
            this.ButtonConvertBack.Location = new System.Drawing.Point(150, 150);
            this.ButtonConvertBack.Name = "ButtonConvertBack";
            this.ButtonConvertBack.Size = new System.Drawing.Size(75, 23);
            this.ButtonConvertBack.TabIndex = 4;
            this.ButtonConvertBack.Text = "Конвертировать";
            this.ButtonConvertBack.UseVisualStyleBackColor = true;
            this.ButtonConvertBack.Click += new System.EventHandler(this.ButtonConvertBack_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(30, 30);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(77, 13);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "Сумма в грн.";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(30, 60);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(122, 13);
            this.Label2.TabIndex = 6;
            this.Label2.Text = "Азербайджанский манат";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 211);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.ButtonConvertBack);
            this.Controls.Add(this.ButtonOk);
            this.Controls.Add(this.TextBox3);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.TextBox1);
            this.Name = "Form1";
            this.Text = "Конвертер валют";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.TextBox TextBox2;
        private System.Windows.Forms.TextBox TextBox3;
        private System.Windows.Forms.Button ButtonOk;
        private System.Windows.Forms.Button ButtonConvertBack;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label2;
    }
}
