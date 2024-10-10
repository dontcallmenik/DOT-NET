using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task3
{
    public class MainForm : Form
    {
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;

        public MainForm()
        {
            // Ініціалізація елементів управління
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.label1 = new Label();
            this.label2 = new Label();
            this.label3 = new Label();
            this.label4 = new Label();
            this.label5 = new Label();
            this.label6 = new Label();
            this.label7 = new Label();
            this.label8 = new Label();
            this.label9 = new Label();
            this.SuspendLayout();

            // Налаштування label1
            this.label1.AutoSize = true;
            this.label1.Location = new Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Text = "1";
            this.label1.ForeColor = Color.Gray;
            this.label1.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);

            // Налаштування label2
            this.label2.AutoSize = true;
            this.label2.Location = new Point(120, 30);
            this.label2.Name = "label2";
            this.label2.Text = "12pt";
            this.label2.ForeColor = Color.Brown;
            this.label2.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);

            // Налаштування label3
            this.label3.AutoSize = true;
            this.label3.Location = new Point(180, 30);
            this.label3.Name = "label3";
            this.label3.Text = "Сірий/Червоний Коричне