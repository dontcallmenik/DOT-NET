﻿using System;
using System.Windows.Forms;

namespace ButtonFontToggle
{
    public partial class Form1 : Form 
    {
        private System.ComponentModel.IContainer components = null;
        private Button button1;
        private Button button2;
        private Button button3;

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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Кнопка 1";
            this.button1.UseVisualStyleBackColor = true;

            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(50, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Кнопка 2";
            this.button2.UseVisualStyleBackColor = true;

            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(50, 130);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 40);
            this.button3.TabIndex = 2;
            this.button3.Text = "Кнопка 3";
            this.button3.UseVisualStyleBackColor = true;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Name = "Form1";
            this.Text = "Перемикання шрифту кнопок";
            this.ResumeLayout(false);
        }
    }
}
