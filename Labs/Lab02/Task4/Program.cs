using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task4
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
            this.label1.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            // Налаштування label2
            this.label2.AutoSize = true;
            this.label2.Location = new Point(120, 30);
            this.label2.Name = "label2";
            this.label2.Text = "12pt";
            this.label2.ForeColor = Color.Brown;
            this.label2.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            // Налаштування label3
            this.label3.AutoSize = true;
            this.label3.Location = new Point(180, 30);
            this.label3.Name = "label3";
            this.label3.Text = "Сірий/Червоний Коричневий/Пурпурний";
            this.label3.ForeColor = Color.Pink;
            this.label3.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            // Налаштування label4
            this.label4.AutoSize = true;
            this.label4.Location = new Point(360, 30);
            this.label4.Name = "label4";
            this.label4.Text = "Жирний, курсив";
            this.label4.ForeColor = Color.Pink;
            this.label4.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            // Налаштування label5
            this.label5.AutoSize = true;
            this.label5.Location = new Point(30, 60);
            this.label5.Name = "label5";
            this.label5.Text = "2";
            this.label5.ForeColor = Color.Pink;
            this.label5.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            // Налаштування label6
            this.label6.AutoSize = true;
            this.label6.Location = new Point(120, 60);
            this.label6.Name = "label6";
            this.label6.Text = "17pt";
            this.label6.ForeColor = Color.Pink;
            this.label6.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            // Налаштування label7
            this.label7.AutoSize = true;
            this.label7.Location = new Point(180, 60);
            this.label7.Name = "label7";
            this.label7.Text = "Центр";
            this.label7.ForeColor = Color.Pink;
            this.label7.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            // Налаштування label8
            this.label8.AutoSize = true;
            this.label8.Location = new Point(30, 90);
            this.label8.Name = "label8";
            this.label8.Text = "3";
            this.label8.ForeColor = Color.Pink;
            this.label8.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            // Налаштування label9
            this.label9.AutoSize = true;
            this.label9.Location = new Point(120, 90);
            this.label9.Name = "label9";
            this.label9.Text = "Праве";
            this.label9.ForeColor = Color.Pink;
            this.label9.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            // Налаштування форми
            this.ClientSize = new Size(600, 200);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Name = "MainForm";
            this.Text = "Task04";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}