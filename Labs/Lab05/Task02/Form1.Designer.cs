namespace Task02
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.TextBox TextBox2;
        private System.Windows.Forms.TextBox TextBox3;
        private System.Windows.Forms.Button ButtonOk;
        private System.Windows.Forms.Button ButtonConvertBack;

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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.TextBox3 = new System.Windows.Forms.TextBox();
            this.ButtonOk = new System.Windows.Forms.Button();
            this.ButtonConvertBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сумма в грн.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Азербайджанский манат.";
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(150, 30);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(100, 20);
            this.TextBox1.TabIndex = 2;
            this.TextBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(150, 80);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.ReadOnly = true;
            this.TextBox2.Size = new System.Drawing.Size(100, 20);
            this.TextBox2.TabIndex = 3;
            // 
            // TextBox3
            // 
            this.TextBox3.Location = new System.Drawing.Point(150, 130);
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.Size = new System.Drawing.Size(100, 20);
            this.TextBox3.TabIndex = 4;
            // 
            // ButtonOk
            // 
            this.ButtonOk.Location = new System.Drawing.Point(30, 180);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new System.Drawing.Size(100, 30);
            this.ButtonOk.TabIndex = 5;
            this.ButtonOk.Text = "ОК";
            this.ButtonOk.UseVisualStyleBackColor = true;
            this.ButtonOk.Click += new System.EventHandler(this.ButtonOk_Click);
            // 
            // ButtonConvertBack
            // 
            this.ButtonConvertBack.Location = new System.Drawing.Point(150, 180);
            this.ButtonConvertBack.Name = "ButtonConvertBack";
            this.ButtonConvertBack.Size = new System.Drawing.Size(120, 30);
            this.ButtonConvertBack.TabIndex = 6;
            this.ButtonConvertBack.Text = "Конвертировать";
            this.ButtonConvertBack.UseVisualStyleBackColor = true;
            this.ButtonConvertBack.Click += new System.EventHandler(this.ButtonConvertBack_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(300, 250);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.TextBox3);
            this.Controls.Add(this.ButtonOk);
            this.Controls.Add(this.ButtonConvertBack);
            this.Name = "Form1";
            this.Text = "Конвертация валют";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
