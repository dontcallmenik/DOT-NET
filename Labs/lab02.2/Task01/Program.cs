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

            // Инициализация текстовых полей
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();

            // Инициализация кнопок
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();

            // Добавляем контролы на форму
            this.Controls.Add(textBox1);
            this.Controls.Add(textBox2);
            this.Controls.Add(textBox3);
            this.Controls.Add(button1);
            this.Controls.Add(button2);
            this.Controls.Add(button3);

            // Привязка обработчиков событий к кнопкам
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button3.Click += new System.EventHandler(this.button3_Click);
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        // Указываем, что sender может быть null
        private void button1_Click(object? sender, EventArgs e)
        {
            textBox1.Text = "Кнопка 1 нажата";
        }

        private void button2_Click(object? sender, EventArgs e)
        {
            textBox2.Text = "Кнопка 2 нажата";
        }

        private void button3_Click(object? sender, EventArgs e)
        {
            textBox3.Text = "Кнопка 3 нажата";
        }
    }
}
