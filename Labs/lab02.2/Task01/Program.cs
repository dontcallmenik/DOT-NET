namespace ButtonClickEvent
{
    public partial class Form1 : Form
    {
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private Button button3;

        public Form1()
        {
            InitializeComponent();

            // ������������� ��������� �����
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();

            // ������������� ������
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();

            // ��������� �������� �� �����
            this.Controls.Add(textBox1);
            this.Controls.Add(textBox2);
            this.Controls.Add(textBox3);
            this.Controls.Add(button1);
            this.Controls.Add(button2);
            this.Controls.Add(button3);

            // �������� ������������ ������� � �������
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button3.Click += new System.EventHandler(this.button3_Click);
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        // ���������, ��� sender ����� ���� null
        private void button1_Click(object? sender, EventArgs e)
        {
            textBox1.Text = "������ 1 ������";
        }

        private void button2_Click(object? sender, EventArgs e)
        {
            textBox2.Text = "������ 2 ������";
        }

        private void button3_Click(object? sender, EventArgs e)
        {
            textBox3.Text = "������ 3 ������";
        }
    }
}
