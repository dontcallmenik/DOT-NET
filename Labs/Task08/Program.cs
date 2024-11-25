using System;
using System.Windows.Forms;

public partial class Form1 : Form
{
    private ToolStrip toolStrip1;
    private ToolStripButton button1;
    private ToolStripButton button2;
    private ToolStripButton button3;

    public Form1()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        this.toolStrip1 = new System.Windows.Forms.ToolStrip();
        this.button1 = new System.Windows.Forms.ToolStripButton();
        this.button2 = new System.Windows.Forms.ToolStripButton();
        this.button3 = new System.Windows.Forms.ToolStripButton();

        // 
        // toolStrip1
        // 
        this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.button1,
            this.button2,
            this.button3
        });
        this.toolStrip1.Location = new System.Drawing.Point(0, 0);
        this.toolStrip1.Name = "toolStrip1";
        this.toolStrip1.Size = new System.Drawing.Size(800, 25);
        this.toolStrip1.TabIndex = 0;
        this.toolStrip1.Text = "toolStrip1";

        // 
        // button1
        // 
        this.button1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        this.button1.Image = System.Drawing.Image.FromFile("path_to_icon1.png"); // Додайте шлях до вашої іконки
        this.button1.ImageTransparentColor = System.Drawing.Color.Magenta;
        this.button1.Name = "button1";
        this.button1.Size = new System.Drawing.Size(23, 22);
        this.button1.Text = "Button 1";
        this.button1.ToolTipText = "Підказка для кнопки 1";
        this.button1.Click += new System.EventHandler(this.ToolStripButton_Click);

        // 
        // button2
        // 
        this.button2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        this.button2.Image = System.Drawing.Image.FromFile("path_to_icon2.png"); // Додайте шлях до вашої іконки
        this.button2.ImageTransparentColor = System.Drawing.Color.Magenta;
        this.button2.Name = "button2";
        this.button2.Size = new System.Drawing.Size(23, 22);
        this.button2.Text = "Button 2";
        this.button2.ToolTipText = "Підказка для кнопки 2";
        this.button2.Click += new System.EventHandler(this.ToolStripButton_Click);

        // 
        // button3
        // 
        this.button3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        this.button3.Image = System.Drawing.Image.FromFile("path_to_icon3.png"); // Додайте шлях до вашої іконки
        this.button3.ImageTransparentColor = System.Drawing.Color.Magenta;
        this.button3.Name = "button3";
        this.button3.Size = new System.Drawing.Size(23, 22);
        this.button3.Text = "Button 3";
        this.button3.ToolTipText = "Підказка для кнопки 3";
        this.button3.Click += new System.EventHandler(this.ToolStripButton_Click);

        // 
        // Form1
        // 
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Controls.Add(this.toolStrip1);
        this.Name = "Form1";
        this.Text = "Завдання 9 Лабораторна 2";
    }

    // Загальний обробник подій для всіх кнопок на панелі інструментів
    private void ToolStripButton_Click(object sender, EventArgs e)
    {
        if (sender is ToolStripButton toolStripButton)
        {
            string toolTipText = toolStripButton.ToolTipText;
            MessageBox.Show(toolTipText, "Підказка");
        }
    }

    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.Run(new Form1());
    }
}
