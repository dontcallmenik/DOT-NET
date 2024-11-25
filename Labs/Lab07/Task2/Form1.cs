using System;
using System.Windows.Forms;

namespace ButtonClickApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // ������ �������� ���� ��� ��� ������
        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;  // ��������� sender �� ���� Button

            if (clickedButton != null)
            {
                Label label = new Label();
                label.Text = $"��������� {clickedButton.Text}";  // �������� ����� ������
                label.Location = new System.Drawing.Point(300, 150 + this.Controls.Count * 30);  // �������� ������������
                this.Controls.Add(label);
            }
        }
    }
}
