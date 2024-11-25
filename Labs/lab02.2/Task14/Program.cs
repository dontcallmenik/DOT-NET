using System;
using System.Drawing;
using System.Windows.Forms;

namespace LoadFormExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load; // �������� �� ������� �������� �����
        }

        private void InitializeComponent()
        {
            // ��������� �����
            this.ClientSize = new Size(400, 300);
            this.Name = "Form1";
            this.Text = "������ �������� �����";
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // ��������� ������ ������������ � ��������������
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void Form1_Load(object? sender, EventArgs e) // ��������� "?" ��� sender
        {
            // ���������� ���� � �������� � �������� �����
            DialogResult result = MessageBox.Show(
                "������ ��������� �����?",
                "�������� �����",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                // ���� ����� "���", ��������� �����
                this.Close();
            }
            else
            {
                // ���� ����� "��", ���������� �������� ����������
                ShowLayoutOptions();
            }
        }

        private void ShowLayoutOptions()
        {
            string[] options = {
                "1. ������� �������� ������",
                "2. ������ ������ �������� ������",
                "3. ������ �������� ������",
                "4. ������ ����� �������� ������",
                "5. ����� �������� ������"
            };

            // ����� ���������� �����
            string option = Microsoft.VisualBasic.Interaction.InputBox(
                "�������� ������� ���������� �����:\n1-5",
                "�������� ����������",
                "1");

            if (int.TryParse(option, out int selectedOption) && selectedOption >= 1 && selectedOption <= 5)
            {
                switch (selectedOption)
                {
                    case 1:
                        this.Location = new Point(0, 0);
                        this.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height / 2);
                        break;
                    case 2:
                        this.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2);
                        this.Size = new Size(Screen.PrimaryScreen.Bounds.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2);
                        break;
                    case 3:
                        this.Location = new Point(0, Screen.PrimaryScreen.Bounds.Height / 2);
                        this.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height / 2);
                        break;
                    case 4:
                        this.Location = new Point(0, Screen.PrimaryScreen.Bounds.Height / 2);
                        this.Size = new Size(Screen.PrimaryScreen.Bounds.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2);
                        break;
                    case 5:
                        this.Location = new Point(0, 0);
                        this.Size = new Size(Screen.PrimaryScreen.Bounds.Width / 2, Screen.PrimaryScreen.Bounds.Height);
                        break;
                }
            }
            else
            {
                MessageBox.Show("�������� ����. ����� ����� �������.");
                this.Close();
            }
        }
    }
}
