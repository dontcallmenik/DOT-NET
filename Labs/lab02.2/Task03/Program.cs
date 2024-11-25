using System;
using System.Drawing;
using System.Windows.Forms;

namespace DblClickExample
{
    public partial class Form1 : Form
    {
        private Label label1;
        private Label label2;
        private Label label3;

        public Form1()
        {
            InitializeComponent();

            // Create labels for text
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();

            // Set label properties
            label1.Text = "Label 1";
            label2.Text = "Label 2";
            label3.Text = "Label 3";
            label1.Font = new Font("Arial", 12);
            label2.Font = new Font("Arial", 12);
            label3.Font = new Font("Arial", 12);
            label1.AutoSize = true;
            label2.AutoSize = true;
            label3.AutoSize = true;

            // Add labels to form
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);

            // Set label positions
            label1.Location = new Point(100, 50);
            label2.Location = new Point(100, 100);
            label3.Location = new Point(100, 150);

            // Add double-click event handlers
            label1.DoubleClick += Label1_DoubleClick;
            label2.DoubleClick += Label2_DoubleClick;
            label3.DoubleClick += Label3_DoubleClick; // Добавляем обработчик для Label3
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Name = "Form1";
            this.ResumeLayout(false);
        }

        // Double-click event handler for Label 1
        private void Label1_DoubleClick(object? sender, EventArgs e)
        {
            // Increase font size
            label1.Font = new Font(label1.Font.FontFamily, label1.Font.Size + 2);
        }

        // Double-click event handler for Label 2
        private void Label2_DoubleClick(object? sender, EventArgs e)
        {
            // Decrease font size
            label2.Font = new Font(label2.Font.FontFamily, label2.Font.Size - 1);
        }

        // Double-click event handler for Label 3
        private void Label3_DoubleClick(object? sender, EventArgs e)
        {
            // Reset font size to default
            label3.Font = new Font(label3.Font.FontFamily, 12);
        }
    }
}
