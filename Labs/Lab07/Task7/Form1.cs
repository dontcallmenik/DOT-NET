using System;
using System.Drawing;
using System.Windows.Forms;

namespace MouseEventsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // ���� ��� MouseDown: �������� �����������
        private void Label_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // ���� ��� ������ ����
            {
                Label label = sender as Label;
                label.Font = new Font(label.Font, label.Font.Style ^ FontStyle.Underline); // ����������� �����������
            }
        }

        // ���� ��� MouseUp: �������� ���������� �����
        private void Label_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Label label = sender as Label;
                label.Font = new Font(label.Font, label.Font.Style ^ FontStyle.Underline); // ³��������� �����
            }
        }
    }
}
