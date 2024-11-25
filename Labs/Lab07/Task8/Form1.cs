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

        // ���� �������� ���� ��� MouseDown �� MouseUp
        private void Label_MouseAction(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // ����������, �� �� ��� ������ ����
            {
                Label label = sender as Label; // ��������� sender �� ���� Label
                if (label != null)
                {
                    // ���������� ����������� �� ��������� XOR-��������
                    label.Font = new Font(label.Font, label.Font.Style ^ FontStyle.Underline);
                }
            }
        }
    }
}
