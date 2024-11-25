using System;
using System.Drawing;
using System.Windows.Forms;

namespace MouseDownMouseUp
{
    public partial class Form1 : Form
    {
        private Label label1;
        private Label label2;
        private Label label3;

        public Form1()
        {
            InitializeComponent();

            // ������� ��� ����� � �������
            label1 = new Label();
            label1.Text = "����� 1";
            label1.Location = new Point(10, 10);
            label1.Font = new Font("Arial", 12); // ��������� ������ ������
            Controls.Add(label1);

            label2 = new Label();
            label2.Text = "����� 2";
            label2.Location = new Point(10, 40);
            label2.Font = new Font("Arial", 12); // ��������� ������ ������
            Controls.Add(label2);

            label3 = new Label();
            label3.Text = "����� 3";
            label3.Location = new Point(10, 70);
            label3.Font = new Font("Arial", 12); // ��������� ������ ������
            Controls.Add(label3);

            // ��������� ����������� ������� ��� ������ �����
            label1.MouseDown += Label_MouseDown;
            label1.MouseUp += Label_MouseUp;
            label2.MouseDown += Label_MouseDown;
            label2.MouseUp += Label_MouseUp;
            label3.MouseDown += Label_MouseDown;
            label3.MouseUp += Label_MouseUp;
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

        private void Label_MouseDown(object? sender, MouseEventArgs e) // �������� ? � sender
        {
            if (sender is Label label && e.Button == MouseButtons.Left) // �������� sender �� Label � ������
            {
                // ��������� ������ ������ �� 1 �����
                label.Font = new Font(label.Font.FontFamily, label.Font.Size - 1);
            }
        }

        private void Label_MouseUp(object? sender, MouseEventArgs e) // �������� ? � sender
        {
            if (sender is Label label && e.Button == MouseButtons.Left) // �������� sender �� Label � ������
            {
                // ����������� ������ ������ �� 1 �����
                label.Font = new Font(label.Font.FontFamily, label.Font.Size + 1);
            }
        }
    }
}
