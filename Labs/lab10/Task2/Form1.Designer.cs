namespace SlideShowApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBoxAutoPlay;
        private System.Windows.Forms.TrackBar trackBarSpeed;
        private System.Windows.Forms.Timer slideShowTimer;

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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.checkBoxAutoPlay = new System.Windows.Forms.CheckBox();
            this.trackBarSpeed = new System.Windows.Forms.TrackBar();
            this.slideShowTimer = new System.Windows.Forms.Timer();

            // panel1
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Size = new System.Drawing.Size(600, 400);
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // pictureBox1
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            // button1 (Folder)
            this.button1.Text = "Папка";
            this.button1.Location = new System.Drawing.Point(10, 410);
            this.button1.Click += new System.EventHandler(this.button1_Click);

            // button3 (Previous)
            this.button3.Text = "<";
            this.button3.Location = new System.Drawing.Point(100, 410);
            this.button3.Click += new System.EventHandler(this.button3_Click);

            // button2 (Next)
            this.button2.Text = ">";
            this.button2.Location = new System.Drawing.Point(160, 410);
            this.button2.Click += new System.EventHandler(this.button2_Click);

            // checkBoxAutoPlay (Auto Play)
            this.checkBoxAutoPlay.Text = "Авто";
            this.checkBoxAutoPlay.Location = new System.Drawing.Point(220, 410);
            this.checkBoxAutoPlay.CheckedChanged += new System.EventHandler(this.checkBoxAutoPlay_CheckedChanged);

            // trackBarSpeed (Speed Control)
            this.trackBarSpeed.Minimum = 1;
            this.trackBarSpeed.Maximum = 10;
            this.trackBarSpeed.Value = 5; // Default speed
            this.trackBarSpeed.Location = new System.Drawing.Point(280, 410);
            this.trackBarSpeed.Size = new System.Drawing.Size(100, 45);
            this.trackBarSpeed.Scroll += new System.EventHandler(this.trackBarSpeed_Scroll);

            // slideShowTimer (Timer)
            this.slideShowTimer.Interval = 1000; // Default interval
            this.slideShowTimer.Tick += new System.EventHandler(this.slideShowTimer_Tick);

            // Form1
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.checkBoxAutoPlay);
            this.Controls.Add(this.trackBarSpeed);
            this.Controls.Add(this.panel1);
            this.Text = "Слайд-шоу (перегляд фотографій)";
            this.Load += new System.EventHandler(this.Form1_Load);

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).EndInit();
        }
    }
}
