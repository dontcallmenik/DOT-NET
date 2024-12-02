namespace StopwatchApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownMinutes;
        private System.Windows.Forms.NumericUpDown numericUpDownSeconds;
        private System.Windows.Forms.Button startStopButton;

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
            this.numericUpDownMinutes = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSeconds = new System.Windows.Forms.NumericUpDown();
            this.startStopButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeconds)).BeginInit();
            this.SuspendLayout();

            // timer1
            this.timer1.Interval = 1000; // 1 second
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);

            // label1
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(100, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 39);
            this.label1.Text = "00 : 00";

            // numericUpDownMinutes
            this.numericUpDownMinutes.Location = new System.Drawing.Point(50, 80);
            this.numericUpDownMinutes.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            this.numericUpDownMinutes.Name = "numericUpDownMinutes";
            this.numericUpDownMinutes.Size = new System.Drawing.Size(60, 22);
            this.numericUpDownMinutes.Value = new decimal(new int[] { 0, 0, 0, 0 });

            // numericUpDownSeconds
            this.numericUpDownSeconds.Location = new System.Drawing.Point(130, 80);
            this.numericUpDownSeconds.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            this.numericUpDownSeconds.Name = "numericUpDownSeconds";
            this.numericUpDownSeconds.Size = new System.Drawing.Size(60, 22);
            this.numericUpDownSeconds.Value = new decimal(new int[] { 0, 0, 0, 0 });

            // startStopButton
            this.startStopButton.Location = new System.Drawing.Point(100, 120);
            this.startStopButton.Name = "startStopButton";
            this.startStopButton.Size = new System.Drawing.Size(75, 30);
            this.startStopButton.Text = "Старт";
            this.startStopButton.UseVisualStyleBackColor = true;
            this.startStopButton.Click += new System.EventHandler(this.startStopButton_Click);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 180);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownMinutes);
            this.Controls.Add(this.numericUpDownSeconds);
            this.Controls.Add(this.startStopButton);
            this.Name = "Form1";
            this.Text = "Секундомір";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeconds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
