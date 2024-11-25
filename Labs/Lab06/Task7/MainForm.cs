using System;
using System.Windows.Forms;

namespace MultiLevelMenu
{
    public partial class MainForm : Form
    {
        private MenuStrip menuStrip;

        public MainForm()
        {
            InitializeComponent();  // ����������� ���������� �����
            CreateMenu();           // ������ ������� ��������� ����
        }

        private void CreateMenu()
        {
            // ����������� MenuStrip
            menuStrip = new MenuStrip();
            this.Controls.Add(menuStrip);
            this.MainMenuStrip = menuStrip;

            // ��������� ������� ���� (6 ������)
            for (int i = 1; i <= 6; i++)
            {
                ToolStripMenuItem item1 = new ToolStripMenuItem($"Item{i}");

                // ������ ������ ����� ��� ������� ������ 1-�� ����
                int subItemCount = i switch
                {
                    1 => 3,
                    2 => 3,
                    3 => 4,
                    4 => 5,
                    5 => 6,
                    6 => 6,
                    _ => 0
                };

                for (int j = 1; j <= subItemCount; j++)
                {
                    ToolStripMenuItem item2 = new ToolStripMenuItem($"Item{i}{j}");
                    item1.DropDownItems.Add(item2);

                    // ������ ����� ����� ��� ���������� ������ ������� ����
                    if ((i == 2 && j == 2) ||  // Item22
                        (i == 3 && j == 4) ||  // Item34
                        (i == 5 && j == 4))    // Item54
                    {
                        int thirdLevelCount = (i == 2) ? 5 : (i == 3) ? 4 : 3;

                        for (int k = 1; k <= thirdLevelCount; k++)
                        {
                            ToolStripMenuItem item3 = new ToolStripMenuItem($"Item{i}{j}{k}");
                            item2.DropDownItems.Add(item3);
                        }
                    }
                }

                // ������ ������ ����� �� MenuStrip
                menuStrip.Items.Add(item1);
            }
        }
    }
}
