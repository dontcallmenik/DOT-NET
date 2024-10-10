using System;
using System.Windows.Forms;

namespace ButtonLayout
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Create a TableLayoutPanel to arrange the buttons.
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.RowCount = 2;
            tableLayoutPanel.ColumnCount = 3;
            Controls.Add(tableLayoutPanel);

            // Create the buttons.
            Button button1 = new Button();
            button1.Text = "but1";
            Button button2 = new Button();
            button2.Text = "but2";
            Button button3 = new Button();
            button3.Text = "but3";
            Button button4 = new Button();
            button4.Text = "but4";
            Button button5 = new Button();
            button5.Text = "but5";

            // Add the buttons to the TableLayoutPanel.
            tableLayoutPanel.Controls.Add(button1, 0, 0);
            tableLayoutPanel.Controls.Add(button2, 1, 0);
            tableLayoutPanel.Controls.Add(button3, 2, 0);
            tableLayoutPanel.Controls.Add(button4, 1, 1);
            tableLayoutPanel.Controls.Add(button5, 2, 1);

            // Set the column widths and row heights.
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.34F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));

            // Set the margin around the buttons.
            tableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel.Padding = new Padding(5);
        }

        private void InitializeComponent() => throw new NotImplementedException();
    }
}