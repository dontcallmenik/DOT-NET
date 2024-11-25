using System;
using System.Drawing;
using System.Windows.Forms;

public class Form1 : Form
{
    private Button myButton;
    private Timer myTimer;
    private bool isExpanded;
    private TextBox intervalTextBox;
    private Button startButton;
    private Button stopButton;
    private MenuStrip menuStrip;
    private ToolStripMenuItem menuItem;

    public Form1()
    {
        InitializeComponent();
        isExpanded = true; // ��������� ��������� �����
    }

    private void InitializeComponent()
    {
        this.myButton = new Button();
        this.myTimer = new Timer();
        this.intervalTextBox = new TextBox();
        this.startButton = new Button();
        this.stopButton = new Button();
        this.menuStrip = new MenuStrip();
        this.menuItem = new ToolStripMenuItem("Menu Item");

        // 
        // myButton
        // 
        this.myButton.Text = "Click Me!";
        this.myButton.Size = new Size(100, 50);
        this.myButton.Location = new Point(50, 50);

        // 
        // intervalTextBox
        // 
        this.intervalTextBox.Size = new Size(100, 20);
        this.intervalTextBox.Location = new Point(50, 120);
        this.intervalTextBox.Text = "250"; // ��������� �������� 250 ��

        // 
        // startButton
        // 
        this.startButton.Text = "Start Timer";
        this.startButton.Location = new Point(50, 150);
        this.startButton.Click += StartButton_Click;

        // 
        // stopButton
        // 
        this.stopButton.Text = "Stop Timer";
        this.stopButton.Location = new Point(150, 150);
        this.stopButton.Click += StopButton_Click;

        // 
        // myTimer
        // 
        this.myTimer.Tick += new EventHandler(MyTimer_Tick); // �������� �� ������� Tick

        // 
        // menuStrip
        // 
        this.menuStrip.Items.Add(this.menuItem);
        this.menuItem.Click += new EventHandler(MenuItem_Click);

        // 
        // Form1
        // 
        this.Controls.Add(this.myButton);
        this.Controls.Add(this.intervalTextBox);
        this.Controls.Add(this.startButton);
        this.Controls.Add(this.stopButton);
        this.Controls.Add(this.menuStrip);
        this.MainMenuStrip = this.menuStrip;
        this.Text = "Form with Timer";
        this.Size = new Size(400, 300);
    }

    private void MyTimer_Tick(object sender, EventArgs e)
    {
        // ����������� ��������� ����� � ������
        if (isExpanded)
        {
            // ������� ����� � �������� ���������
            this.Size = new Size(200, 100); // �������� ������ �����
            this.Location = new Point(300, 200); // ������ ��������� �����
            myButton.Visible = false; // �������� ������
        }
        else
        {
            // ������������� ����� � ���������� ������
            this.Size = new Size(400, 300); // ��������������� ������
            this.Location = new Point(100, 100); // ��������������� ���������
            myButton.Visible = true; // ���������� ������
        }

        // ����������� ���������
        isExpanded = !isExpanded;
    }

    private void StartButton_Click(object sender, EventArgs e)
    {
        // �������� �������� ������� � ��������� ���
        if (int.TryParse(intervalTextBox.Text, out int interval) && interval > 0)
        {
            myTimer.Interval = interval; // ������������� �������� �� ���������� ����
            myTimer.Start(); // ��������� ������
        }
        else
        {
            MessageBox.Show("������� ���������� �������� ��������� (��).");
        }
    }

    private void StopButton_Click(object sender, EventArgs e)
    {
        myTimer.Stop(); // ������������� ������
    }

    private void MenuItem_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Menu Item clicked!"); // ���������� ��� ����� �� ����
    }

    // ����� ����� � ���������
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.Run(new Form1());
    }
}
