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

            // �������� �����
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();

            // ��������� ������� �����
            label1.Text = "Label 1";
            label2.Text = "Label 2";
            label3.Text = "Label 3";
            label1.Font = new Font("Arial", 12);
            label2.Font = new Font("Arial", 12);
            label3.Font = new Font("Arial", 12);
            label1.AutoSize = true;
            label2.AutoSize = true;
            label3.AutoSize = true;

            // ���������� ����� �� �����
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);

            // ��������� ������������ �����
            label1.Location = new Point(100, 50);
            label2.Location = new Point(100, 100);
            label3.Location = new Point(100, 150);

            // �������� ������ ����������� ������� �� ���� ������
            label1.DoubleClick += Label_DoubleClick;
            label2.DoubleClick += Label_DoubleClick;
            label3.DoubleClick += Label_DoubleClick;
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

        // ���������� �������� ������ ��� ���� �����
        private void Label_DoubleClick(object? sender, EventArgs e)
        {
            if (sender is Label label) // ���������, �������� �� sender ������
            {
                switch (label.Text) // ���������� ����� ����� ��� ����������� ��������
                {
                    case "Label 1":
                        // ����������� ������ ������ ��� Label 1
                        label.Font = new Font(label.Font.FontFamily, label.Font.Size + 2);
                        break;

                    case "Label 2":
                        // ��������� ������ ������ ��� Label 2
                        label.Font = new Font(label.Font.FontFamily, label.Font.Size - 1);
                        break;

                    case "Label 3":
                        // ���������� ������ ������ ��� Label 3
                        label.Font = new Font(label.Font.FontFamily, 12);
                        break;
                }
            }
        }
    }
}
