﻿using System;
using System.Windows.Forms;

namespace MenuStrip_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // Initialize components when the form is constructed
            InitializeComponent();
        }

        // Method to initialize components of the form (including the MenuStrip)
        private void InitializeComponent()
        {
            // Create the MenuStrip
            MenuStrip menuStrip = new MenuStrip();

            // Create the first-level menu items
            ToolStripMenuItem item1 = new ToolStripMenuItem("Item1");
            ToolStripMenuItem item2 = new ToolStripMenuItem("Item2");
            ToolStripMenuItem item3 = new ToolStripMenuItem("Item3");

            // Add first-level menu items to the MenuStrip
            menuStrip.Items.AddRange(new ToolStripItem[] { item1, item2, item3 });

            // Create the second-level menu items
            ToolStripMenuItem item11 = new ToolStripMenuItem("Item11");
            ToolStripMenuItem item12 = new ToolStripMenuItem("Item12");
            ToolStripMenuItem item13 = new ToolStripMenuItem("Item13");
            ToolStripMenuItem item21 = new ToolStripMenuItem("Item21");
            ToolStripMenuItem item22 = new ToolStripMenuItem("Item22");
            ToolStripMenuItem item23 = new ToolStripMenuItem("Item23");

            // Add the second-level menu items to the first-level menu items
            item1.DropDownItems.AddRange(new ToolStripItem[] { item11, item12, item13 });
            item2.DropDownItems.AddRange(new ToolStripItem[] { item21, item22, item23 });
            item3.DropDownItems.AddRange(new ToolStripItem[] { item11, item12, item13 });

            // Create the third-level menu items
            ToolStripMenuItem item111 = new ToolStripMenuItem("Item111");
            ToolStripMenuItem item112 = new ToolStripMenuItem("Item112");
            ToolStripMenuItem item113 = new ToolStripMenuItem("Item113");
            ToolStripMenuItem item211 = new ToolStripMenuItem("Item211");
            ToolStripMenuItem item212 = new ToolStripMenuItem("Item212");
            ToolStripMenuItem item213 = new ToolStripMenuItem("Item213");

            // Add the third-level menu items to the second-level menu items
            item11.DropDownItems.AddRange(new ToolStripItem[] { item111, item112, item113 });
            item21.DropDownItems.AddRange(new ToolStripItem[] { item211, item212, item213 });

            // Set MenuStrip as the top-level menu for the form
            this.MainMenuStrip = menuStrip;
            this.Controls.Add(menuStrip);

            // Configure form properties
            this.Text = "MenuStrip Example";
            this.Size = new System.Drawing.Size(400, 300);

            // Add the MenuStrip to the form
            this.Controls.Add(menuStrip);
        }
    }
}
