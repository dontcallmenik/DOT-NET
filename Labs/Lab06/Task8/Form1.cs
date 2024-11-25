using System;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace ContextMenuExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreateContextMenu();
        }

        private void CreateContextMenu()
        {
            // Створюємо контекстне меню
            ContextMenuStrip contextMenu = new ContextMenuStrip();

            // Перший рівень меню
            ToolStripMenuItem item1 = new ToolStripMenuItem("Item1");
            ToolStripMenuItem item2 = new ToolStripMenuItem("Item2");
            ToolStripMenuItem item3 = new ToolStripMenuItem("Item3");
            ToolStripMenuItem item4 = new ToolStripMenuItem("Item4");
            ToolStripMenuItem item5 = new ToolStripMenuItem("Item5");
            ToolStripMenuItem item6 = new ToolStripMenuItem("Item6");

            // Додаємо другий рівень для Item2, Item3, Item5
            ToolStripMenuItem[] subItems2 = {
                new ToolStripMenuItem("Item21"),
                new ToolStripMenuItem("Item22"),
                new ToolStripMenuItem("Item23"),
                new ToolStripMenuItem("Item24"),
                new ToolStripMenuItem("Item25")
            };
            item2.DropDownItems.AddRange(subItems2);

            ToolStripMenuItem[] subItems3 = {
                new ToolStripMenuItem("Item31"),
                new ToolStripMenuItem("Item32"),
                new ToolStripMenuItem("Item33"),
                new ToolStripMenuItem("Item34")
            };
            item3.DropDownItems.AddRange(subItems3);

            ToolStripMenuItem[] subItems5 = {
                new ToolStripMenuItem("Item51"),
                new ToolStripMenuItem("Item52"),
                new ToolStripMenuItem("Item53")
            };
            item5.DropDownItems.AddRange(subItems5);

            // Додаємо елементи першого рівня в контекстне меню
            contextMenu.Items.AddRange(new ToolStripItem[] { item1, item2, item3, item4, item5, item6 });

            // Призначаємо контекстне меню для кожного Label
            label1.ContextMenuStrip = contextMenu;
            label2.ContextMenuStrip = contextMenu;
            label3.ContextMenuStrip = contextMenu;
        }
    }
}
