partial class Form1
{
    private System.ComponentModel.IContainer components = null;
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

    // Ініціалізація компонентів
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
        this.item1 = new System.Windows.Forms.ToolStripMenuItem();
        this.item2 = new System.Windows.Forms.ToolStripMenuItem();
        this.item3 = new System.Windows.Forms.ToolStripMenuItem();
        this.item11 = new System.Windows.Forms.ToolStripMenuItem();
        this.item12 = new System.Windows.Forms.ToolStripMenuItem();
        this.item13 = new System.Windows.Forms.ToolStripMenuItem();
        this.item21 = new System.Windows.Forms.ToolStripMenuItem();
        this.item22 = new System.Windows.Forms.ToolStripMenuItem();
        this.item23 = new System.Windows.Forms.ToolStripMenuItem();

        // Контекстне меню
        this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item1,
            this.item2,
            this.item3
        });
        this.contextMenuStrip1.Name = "contextMenuStrip1";
        this.contextMenuStrip1.Size = new System.Drawing.Size(153, 70);

        // Налаштування першого пункту меню (Item1)
        this.item1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item11,
            this.item12,
            this.item13
        });
        this.item1.Name = "item1";
        this.item1.Size = new System.Drawing.Size(152, 22);
        this.item1.Text = "Item 1";

        // Налаштування другого пункту меню (Item2)
        this.item2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item21,
            this.item22,
            this.item23
        });
        this.item2.Name = "item2";
        this.item2.Size = new System.Drawing.Size(152, 22);
        this.item2.Text = "Item 2";

        // Налаштування третього пункту меню (Item3)
        this.item3.Name = "item3";
        this.item3.Size = new System.Drawing.Size(152, 22);
        this.item3.Text = "Item 3";

        // Налаштування пунктів другого рівня
        this.item11.Name = "item11";
        this.item11.Size = new System.Drawing.Size(152, 22);
        this.item11.Text = "Item 11";
        this.item11.Click += new System.EventHandler(this.MenuItem_Click); // Додаємо один обробник

        this.item12.Name = "item12";
        this.item12.Size = new System.Drawing.Size(152, 22);
        this.item12.Text = "Item 12";
        this.item12.Click += new System.EventHandler(this.MenuItem_Click); // Додаємо один обробник

        this.item13.Name = "item13";
        this.item13.Size = new System.Drawing.Size(152, 22);
        this.item13.Text = "Item 13";
        this.item13.Click += new System.EventHandler(this.MenuItem_Click); // Додаємо один обробник

        // Пункти для другого пункту меню (Item 2)
        this.item21.Name = "item21";
        this.item21.Size = new System.Drawing.Size(152, 22);
        this.item21.Text = "Item 21";
        this.item21.Click += new System.EventHandler(this.MenuItem_Click); // Додаємо один обробник

        this.item22.Name = "item22";
        this.item22.Size = new System.Drawing.Size(152, 22);
        this.item22.Text = "Item 22";
        this.item22.Click += new System.EventHandler(this.MenuItem_Click); // Додаємо один обробник

        this.item23.Name = "item23";
        this.item23.Size = new System.Drawing.Size(152, 22);
        this.item23.Text = "Item 23";
        this.item23.Click += new System.EventHandler(this.MenuItem_Click); // Додаємо один обробник

        // Присвоєння контекстного меню формі
        this.ContextMenuStrip = this.contextMenuStrip1;

        // Налаштування форми
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Name = "Form1";
        this.Text = "Контекстне меню з одним обробником подій";
    }
}
