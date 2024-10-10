using System;
using System.Drawing; // Необхідно для кольорів
using System.Windows.Forms;

namespace Task01
{
    public class MainForm : Form
    {
        private Label label1;
        private Label label2;
        private Label label3;

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
            this.SuspendLayout();

            // Налаштування label1
            this.label1.AutoSize = true;
            this.label1.Location = new Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Text = "Перший рядок тексту!";
            this.label1.ForeColor = Color.Gray; // Задати колір

            // Налаштування label2
            this.label2.AutoSize = true;
            this.label2.Location = new Point(30, 60);
            this.label2.Name = "label2";
            this.label2.Text = "Другий рядок тексту!";
            this.label2.ForeColor = Color.Brown; // Задати колір

            // Налаштування label3
            this.label3.AutoSize = true;
            this.label3.Location = new Point(30, 90);
            this.label3.Name = "label3";
            this.label3.Text = "Третій рядок тексту!";
            this.label3.ForeColor = Color.Pink; // Задати колір

            // Налаштування форми
            this.ClientSize = new Size(400, 200);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "MainForm";
            this.Text = "Task01";
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
