using System;
using System.Windows.Forms;

namespace MenuStrip_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Create the MenuStrip
            MenuStrip menuStrip = new MenuStrip();

            // Create the "File" menu and its sub-items
            ToolStripMenuItem fileMenu = new ToolStripMenuItem("File");
            ToolStripMenuItem newMenuItem = new ToolStripMenuItem("New");
            ToolStripMenuItem openMenuItem = new ToolStripMenuItem("Open");

            // Add event handlers to the menu items
            newMenuItem.Click += MenuItem_Click;
            openMenuItem.Click += MenuItem_Click;

            // Add the menu items to the file menu
            fileMenu.DropDownItems.AddRange(new ToolStripItem[] { newMenuItem, openMenuItem });

            // Add the "File" menu to the MenuStrip
            menuStrip.Items.Add(fileMenu);

            // Set MenuStrip as the top-level menu for the form
            this.MainMenuStrip = menuStrip;

            // Add the MenuStrip to the form's controls
            this.Controls.Add(menuStrip);
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        // Event handler for menu items click event
        private void MenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = sender as ToolStripMenuItem;
            if (clickedItem != null)
            {
                MessageBox.Show($"{clickedItem.Text} clicked!");
            }
        }
    }
}
