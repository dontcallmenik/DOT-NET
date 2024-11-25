using System;
using System.Drawing;
using System.Windows.Forms;

public class Form1 : Form
{
    private ContextMenuStrip contextMenuStrip1;
    private ToolStripMenuItem item1;
    private ToolStripMenuItem item2;
    private ToolStripMenuItem item3;
    private ToolStripMenuItem item11;
    private ToolStripMenuItem item12;
    private ToolStripMenuItem item13;
    private ToolStripMenuItem item21;
    private ToolStripMenuItem item22;
    private ToolStripMenuItem item23;

    public Form1()
    {
        InitializeComponent();

        // Set the ContextMenuStrip to the form
        this.ContextMenuStrip = contextMenuStrip1;
    }

    private void InitializeComponent()
    {
        this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip();
        this.item1 = new System.Windows.Forms.ToolStripMenuItem();
        this.item2 = new System.Windows.Forms.ToolStripMenuItem();
        this.item3 = new System.Windows.Forms.ToolStripMenuItem();
        this.item11 = new System.Windows.Forms.ToolStripMenuItem();
        this.item12 = new System.Windows.Forms.ToolStripMenuItem();
        this.item13 = new System.Windows.Forms.ToolStripMenuItem();
        this.item21 = new System.Windows.Forms.ToolStripMenuItem();
        this.item22 = new System.Windows.Forms.ToolStripMenuItem();
        this.item23 = new System.Windows.Forms.ToolStripMenuItem();

        // 
        // contextMenuStrip1
        // 
        this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item1,
            this.item2,
            this.item3
        });
        this.contextMenuStrip1.Name = "contextMenuStrip1";
        this.contextMenuStrip1.Size = new System.Drawing.Size(153, 70);

        // 
        // item1
        // 
        this.item1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item11,
            this.item12,
            this.item13
        });
        this.item1.Name = "item1";
        this.item1.Size = new System.Drawing.Size(152, 22);
        this.item1.Text = "Item1";

        // 
        // item2
        // 
        this.item2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item21,
            this.item22,
            this.item23
        });
        this.item2.Name = "item2";
        this.item2.Size = new System.Drawing.Size(152, 22);
        this.item2.Text = "Item2";

        // 
        // item3
        // 
        this.item3.Name = "item3";
        this.item3.Size = new System.Drawing.Size(152, 22);
        this.item3.Text = "Item3";

        // 
        // item11
        // 
        this.item11.Name = "item11";
        this.item11.Size = new System.Drawing.Size(152, 22);
        this.item11.Text = "Item11";

        // 
        // item12
        // 
        this.item12.Name = "item12";
        this.item12.Size = new System.Drawing.Size(152, 22);
        this.item12.Text = "Item12";

        // 
        // item13
        // 
        this.item13.Name = "item13";
        this.item13.Size = new System.Drawing.Size(152, 22);
        this.item13.Text = "Item13";

        // 
        // item21
        // 
        this.item21.Name = "item21";
        this.item21.Size = new System.Drawing.Size(152, 22);
        this.item21.Text = "Item21";

        // 
        // item22
        // 
        this.item22.Name = "item22";
        this.item22.Size = new System.Drawing.Size(152, 22);
        this.item22.Text = "Item22";

        // 
        // item23
        // 
        this.item23.Name = "item23";
        this.item23.Size = new System.Drawing.Size(152, 22);
        this.item23.Text = "Item23";

        // Form properties
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Name = "Form1";
        this.Text = "Context Menu Example";

        // Add the ContextMenuStrip to the form's controls
        this.ContextMenuStrip = contextMenuStrip1;
    }

    // Entry point of the program
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.Run(new Form1());
    }
}
