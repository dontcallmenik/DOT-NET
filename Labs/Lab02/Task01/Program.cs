using System;
using System.Drawing;
using System.Windows.Forms;

namespace LabelApp
{
    public class MainForm : Form
    {
        public MainForm()
        {
            // Властивості форми
            this.Text = "Label Task";
            this.Size = new Size(400, 300);

            // Перший Label
            Label label1 = new Label();
            label1.Text = "Перший рядок";
            label1.Font = new Font("Arial", 12, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.Gray;
            label1.BackColor = Color.Red; // Сірий/Червоний фон
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.Dock = DockStyle.Top;

            // Другий Label
            Label label2 = new Label();
            label2.Text = "Другий рядок";
            label2.Font = new Font("Arial", 17, FontStyle.Underline);
            label2.ForeColor = Color.Brown;
            label2.BackColor = Color.Purple; // Коричневий/Пурпурний фон
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Dock = DockStyle.Top;

            // Третій Label
            Label label3 = new Label();
            label3.Text = "Третій рядок";
            label3.Font = new Font("Arial", 13, FontStyle.Bold);
            label3.ForeColor = Color.Pink;
            label3.BackColor = Color.Blue; // Рожевий/Синій фон
            label3.TextAlign = ContentAlignment.MiddleRight;
            label3.Dock = DockStyle.Top;

            // Додавання Label-ів до форми
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
        }

        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new MainForm());
        }
    }
}
