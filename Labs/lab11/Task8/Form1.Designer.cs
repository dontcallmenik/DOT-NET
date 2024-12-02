namespace TextEditorApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton newFileButton;
        private System.Windows.Forms.ToolStripButton openFileButton;
        private System.Windows.Forms.ToolStripButton saveFileButton;
        private System.Windows.Forms.ToolStripButton toUpperButton;
        private System.Windows.Forms.ToolStripButton toLowerButton;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel cursorPositionLabel;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBox = new System.Windows.Forms.TextBox();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.newFileButton = new System.Windows.Forms.ToolStripButton();
            this.openFileButton = new System.Windows.Forms.ToolStripButton();
            this.saveFileButton = new System.Windows.Forms.ToolStripButton();
            this.toUpperButton = new System.Windows.Forms.ToolStripButton();
            this.toLowerButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.cursorPositionLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            // TextBox setup
            this.textBox.Multiline = true;
            this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;

            // ToolStrip setup
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.newFileButton,
                this.openFileButton,
                this.saveFileButton,
                this.toUpperButton,
                this.toLowerButton
            });

            // New file button
            this.newFileButton.Text = "New";
            this.newFileButton.Click += new System.EventHandler(this.newFileButton_Click);

            // Open file button
            this.openFileButton.Text = "Open";
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);

            // Save file button
            this.saveFileButton.Text = "Save";
            this.saveFileButton.Click += new System.EventHandler(this.saveFileButton_Click);

            // To Upper button
            this.toUpperButton.Text = "Upper";
            this.toUpperButton.Click += new System.EventHandler(this.toUpperButton_Click);

            // To Lower button
            this.toLowerButton.Text = "Lower";
            this.toLowerButton.Click += new System.EventHandler(this.toLowerButton_Click);

            // StatusStrip setup
            this.statusStrip.Items.Add(this.cursorPositionLabel);

            // MenuStrip setup
            this.menuStrip.Items.Add(this.aboutMenuItem);

            // About menu item
            this.aboutMenuItem.Text = "About";
            this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);

            // Form setup
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.statusStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Text = "Text Editor";
        }
    }
}
