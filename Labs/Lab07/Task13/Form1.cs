using System;
using System.Windows.Forms;

namespace HotKeysApp
{
    public partial class Form1 : Form
    {
        private ListBox listBox;

        public Form1()
        {
            InitializeComponent();
        }

        // ����� ��� ������� ���������� �����
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.A))
            {
                AddListBox(); // ������ ListBox ��� Ctrl + A
                return true;
            }
            else if (keyData == (Keys.Control | Keys.Shift | Keys.D))
            {
                RemoveListBox(); // ��������� ListBox ��� Ctrl + Shift + D
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        // ����� ��� ��������� ListBox �� �����
        private void AddListBox()
        {
            if (listBox == null)
            {
                listBox = new ListBox
                {
                    Location = new System.Drawing.Point(20, 20),
                    Size = new System.Drawing.Size(200, 100),
                    Name = "listBox"
                };

                // ������ 4 �������� �� ListBox
                listBox.Items.AddRange(new object[] { "������� 1", "������� 2", "������� 3", "������� 4" });
                this.Controls.Add(listBox);
            }
        }

        // ����� ��� ��������� ListBox � �����
        private void RemoveListBox()
        {
            if (listBox != null)
            {
                this.Controls.Remove(listBox);
                listBox.Dispose();
                listBox = null;
            }
        }
    }
}
