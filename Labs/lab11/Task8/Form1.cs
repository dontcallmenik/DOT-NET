using System;
using System.IO;
using System.Windows.Forms;

namespace TextEditorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Add the correct event handlers here
            textBox.TextChanged += textBox_TextChanged;
            textBox.KeyUp += textBox_CursorPositionChanged;
            textBox.MouseUp += textBox_CursorPositionChanged;
        }

        private void newFileButton_Click(object sender, EventArgs e)
        {
            textBox.Clear();
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox.Text = File.ReadAllText(openFileDialog.FileName);
                }
            }
        }

        private void saveFileButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, textBox.Text);
                }
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            UpdateCursorPosition();
        }

        private void textBox_CursorPositionChanged(object sender, EventArgs e)
        {
            UpdateCursorPosition();
        }

        private void UpdateCursorPosition()
        {
            int line = textBox.GetLineFromCharIndex(textBox.SelectionStart) + 1;
            int column = textBox.SelectionStart - textBox.GetFirstCharIndexOfCurrentLine() + 1;
            cursorPositionLabel.Text = $"Line: {line}, Column: {column}";
        }

        private void toUpperButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox.SelectedText))
            {
                textBox.SelectedText = textBox.SelectedText.ToUpper();
            }
        }

        private void toLowerButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox.SelectedText))
            {
                textBox.SelectedText = textBox.SelectedText.ToLower();
            }
        }

        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developer: Your Name", "About");
        }
    }
}
