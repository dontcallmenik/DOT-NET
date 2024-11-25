using System;
using System.Drawing;
using System.Windows.Forms;

namespace CheckBoxExample
{
    public partial class Form1 : Form
    {
        private CheckBox checkBoxBold;
        private CheckBox checkBoxItalic;
        private CheckBox checkBoxUnderline;
        private Button buttonApply;
        private Button buttonReset;
        private TextBox textBox;

        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.checkBoxBold = new System.Windows.Forms.CheckBox();
            this.checkBoxItalic = new System.Windows.Forms.CheckBox();
            this.checkBoxUnderline = new System.Windows.Forms.CheckBox();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkBoxBold
            // 
            this.checkBoxBold.AutoSize = true;
            this.checkBoxBold.Location = new System.Drawing.Point(12, 12);
            this.checkBoxBold.Name = "checkBoxBold";
            this.checkBoxBold.Size = new System.Drawing.Size(61, 17);
            this.checkBoxBold.TabIndex = 0;
            this.checkBoxBold.Text = "Жирний";
            this.checkBoxBold.UseVisualStyleBackColor = true;
            // 
            // checkBoxItalic
            // 
            this.checkBoxItalic.AutoSize = true;
            this.checkBoxItalic.Location = new System.Drawing.Point(12, 35);
            this.checkBoxItalic.Name = "checkBoxItalic";
            this.checkBoxItalic.Size = new System.Drawing.Size(73, 17);
            this.checkBoxItalic.TabIndex = 1;
            this.checkBoxItalic.Text = "Курсивний";
            this.checkBoxItalic.UseVisualStyleBackColor = true;
            // 
            // checkBoxUnderline
            // 
            this.checkBoxUnderline.AutoSize = true;
            this.checkBoxUnderline.Location = new System.Drawing.Point(12, 58);
            this.checkBoxUnderline.Name = "checkBoxUnderline";
            this.checkBoxUnderline.Size = new System.Drawing.Size(85, 17);
            this.checkBoxUnderline.TabIndex = 2;
            this.checkBoxUnderline.Text = "Підкреслений";
            this.checkBoxUnderline.UseVisualStyleBackColor = true;
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(12, 90);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 3;
            this.buttonApply.Text = "Застосувати";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(93, 90);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 4;
            this.buttonReset.Text = "Скинути";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 120);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(156, 20);
            this.textBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(200, 160);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.checkBoxUnderline);
            this.Controls.Add(this.checkBoxItalic);
            this.Controls.Add(this.checkBoxBold);
            this.Name = "Form1";
            this.Text = "CheckBox Example";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            // Применение стилей к тексту в TextBox
            FontStyle style = FontStyle.Regular;

            if (checkBoxBold.Checked)
                style |= FontStyle.Bold;
            if (checkBoxItalic.Checked)
                style |= FontStyle.Italic;
            if (checkBoxUnderline.Checked)
                style |= FontStyle.Underline;

            textBox.Font = new Font(textBox.Font, style);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            // Сброс всех стилей
            checkBoxBold.Checked = false;
            checkBoxItalic.Checked = false;
            checkBoxUnderline.Checked = false;
            textBox.Font = new Font(textBox.Font, FontStyle.Regular);
        }
    }
}
