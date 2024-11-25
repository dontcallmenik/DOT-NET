using System;
using System.Drawing;
using System.Windows.Forms;

namespace MouseDownMouseUp
{
    public partial class Form1 : Form
    {
        private Label[] labels;

        public Form1()
        {
            InitializeComponent();

            // ������� ������ �����
            labels = new Label[3];

            // ������� ����� � ��������� �� �� �����
            for (int i = 0; i < labels.Length; i++)
            {
                labels[i] = new Label();
                labels[i].Text = $"����� {i + 1}";
                labels[i].Location = new Point(10, 10 + (i * 30));
                labels[i].Font = new Font("Arial", 12); // ��������� ������ ������
                labels[i].MouseDown += Label_MouseDown;
                labels[i].MouseUp += Label_MouseUp;
                Controls.Add(labels[i]);
            }
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

        private void Label_MouseDown(object? sender, MouseEventArgs e) // ���������� MouseDown
        {
            if (sender is Label label && e.Button == MouseButtons.Left) // ��������� sender
            {
                // ��������� ������ ������ �� 1 �����
                label.Font = new Font(label.Font.FontFamily, label.Font.Size - 1);
            }
        }

        private void Label_MouseUp(object? sender, MouseEventArgs e) // ���������� MouseUp
        {
            if (sender is Label label && e.Button == MouseButtons.Left) // ��������� sender
            {
                // ����������� ������ ������ �� 1 �����
                label.Font = new Font(label.Font.FontFamily, label.Font.Size + 1);
            }
        }
    }
}
