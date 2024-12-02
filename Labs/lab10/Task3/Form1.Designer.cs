namespace ImageViewerApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBoxImages;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button buttonFolder;

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
            this.listBoxImages = new System.Windows.Forms.ListBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.buttonFolder = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();

            // listBoxImages
            this.listBoxImages.Location = new System.Drawing.Point(10, 10);
            this.listBoxImages.Size = new System.Drawing.Size(150, 380);
            this.listBoxImages.SelectedIndexChanged += new System.EventHandler(this.listBoxImages_SelectedIndexChanged);

            // pictureBox
            this.pictureBox.Location = new System.Drawing.Point(170, 10);
            this.pictureBox.Size = new System.Drawing.Size(400, 300);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            // buttonFolder
            this.buttonFolder.Text = "Папка...";
            this.buttonFolder.Location = new System.Drawing.Point(10, 400);
            this.buttonFolder.Size = new System.Drawing.Size(150, 30);
            this.buttonFolder.Click += new System.EventHandler(this.buttonFolder_Click);

            // Form1
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.listBoxImages);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.buttonFolder);
            this.Text = "Просмотр иллюстраций";
            this.Load += new System.EventHandler(this.Form1_Load);

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
