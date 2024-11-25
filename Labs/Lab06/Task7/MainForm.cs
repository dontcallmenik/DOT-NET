using System;
using System.Windows.Forms;

namespace MultiLevelMenu
{
    public partial class MainForm : Form
    {
        private MenuStrip menuStrip;

        public MainForm()
        {
            InitializeComponent();  // Ініціалізація компонентів форми
            CreateMenu();           // Виклик функції створення меню
        }

        private void CreateMenu()
        {
            // Ініціалізація MenuStrip
            menuStrip = new MenuStrip();
            this.Controls.Add(menuStrip);
            this.MainMenuStrip = menuStrip;

            // Створення першого рівня (6 розділів)
            for (int i = 1; i <= 6; i++)
            {
                ToolStripMenuItem item1 = new ToolStripMenuItem($"Item{i}");

                // Додаємо другий рівень для кожного розділу 1-го рівня
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

                    // Додаємо третій рівень для зазначених розділів другого рівня
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

                // Додаємо перший рівень до MenuStrip
                menuStrip.Items.Add(item1);
            }
        }
    }
}
