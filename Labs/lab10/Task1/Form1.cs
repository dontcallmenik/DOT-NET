using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace SlideShowApp
{
    public partial class Form1 : Form
    {
        private List<string> imageFiles;
        private int currentIndex;

        public Form1()
        {
            InitializeComponent();
            imageFiles = new List<string>();
            currentIndex = -1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Load images from the default directory on startup
            LoadImages(@"C:\Users\vladi\Desktop\countries");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Folder selection dialog for custom folder
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    LoadImages(folderDialog.SelectedPath);
                }
            }
        }

        private void LoadImages(string folderPath)
        {
            if (Directory.Exists(folderPath))
            {
                string[] files = Directory.GetFiles(folderPath, "*.jpg");
                imageFiles = new List<string>(files);
                currentIndex = imageFiles.Count > 0 ? 0 : -1;
                ShowImage();
            }
            else
            {
                MessageBox.Show("Directory not found: " + folderPath);
            }
        }

        private void ShowImage()
        {
            if (currentIndex >= 0 && currentIndex < imageFiles.Count)
            {
                pictureBox1.ImageLocation = imageFiles[currentIndex];
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Previous image
            if (imageFiles.Count > 0)
            {
                currentIndex = (currentIndex - 1 + imageFiles.Count) % imageFiles.Count;
                ShowImage();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Next image
            if (imageFiles.Count > 0)
            {
                currentIndex = (currentIndex + 1) % imageFiles.Count;
                ShowImage();
            }
        }
    }
}
