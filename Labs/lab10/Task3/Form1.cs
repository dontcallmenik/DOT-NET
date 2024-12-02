using System;
using System.IO;
using System.Windows.Forms;

namespace ImageViewerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Load images from the default directory on startup
            LoadImages(@"C:\Users\vladi\Desktop\countries");
        }

        private void buttonFolder_Click(object sender, EventArgs e)
        {
            // Open folder selection dialog
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
            listBoxImages.Items.Clear();
            pictureBox.Image = null;

            if (Directory.Exists(folderPath))
            {
                string[] files = Directory.GetFiles(folderPath, "*.jpg");
                foreach (string file in files)
                {
                    listBoxImages.Items.Add(Path.GetFileName(file));
                }

                // Store the full file paths for easy access later
                listBoxImages.Tag = files;
            }
            else
            {
                MessageBox.Show("Directory not found: " + folderPath);
            }
        }

        private void listBoxImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxImages.SelectedIndex != -1)
            {
                string[] files = (string[])listBoxImages.Tag;
                string selectedFile = files[listBoxImages.SelectedIndex];
                pictureBox.ImageLocation = selectedFile;
            }
        }
    }
}
