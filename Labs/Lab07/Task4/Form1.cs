using System;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace DoubleClickExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // ����'����� �������� DoubleClick �� ��� Label
            label1.DoubleClick += Label_DoubleClick;
            label2.DoubleClick += Label_DoubleClick;
            label3.DoubleClick += Label_DoubleClick;
        }

        // ��������� �������� ��� ��� Label
        private void Label_DoubleClick(object sender, EventArgs e)
        {
            // �������� ��'���, ���� �������� ����
            if (sender is System.Windows.Forms.Label label)
            {
                // ���������� �� ����������� � ��������� �������
                label.Font = label.Font.Underline
                    ? new Font(label.Font, FontStyle.Regular)
                    : new Font(label.Font, FontStyle.Underline);
            }
        }
    }
}
