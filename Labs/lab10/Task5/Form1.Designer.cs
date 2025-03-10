﻿namespace StopwatchApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;

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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // timer1
            this.timer1.Interval = 1000; // 1 second
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);

            // label1 (Minutes)
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(50, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 39);
            this.label1.Text = "00";

            // label2 (Colon)
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(100, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 39);
            this.label2.Text = ":";

            // label3 (Seconds)
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.Location = new System.Drawing.Point(130, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 39);
            this.label3.Text = "00";

            // startButton
            this.startButton.Location = new System.Drawing.Point(50, 80);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 30);
            this.startButton.Text = "Старт";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);

            // stopButton
            this.stopButton.Location = new System.Drawing.Point(130, 80);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 30);
            this.stopButton.Text = "Стоп";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 150);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.stopButton);
            this.Name = "Form1";
            this.Text = "Секундомір";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
