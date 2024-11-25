using System;
using System.Drawing;
using System.Windows.Forms;

namespace MouseDownMouseUp
{
    public partial class Form1 : Form
    {
        private Label label1;
        private Label label2;
        private Label label3;

        public Form1()
        {
            InitializeComponent();

            // Создаем три метки с текстом
            label1 = new Label();
            label1.Text = "Текст 1";
            label1.Location = new Point(10, 10);
            label1.Font = new Font("Arial", 12); // Начальный размер шрифта
            Controls.Add(label1);

            label2 = new Label();
            label2.Text = "Текст 2";
            label2.Location = new Point(10, 40);
            label2.Font = new Font("Arial", 12); // Начальный размер шрифта
            Controls.Add(label2);

            label3 = new Label();
            label3.Text = "Текст 3";
            label3.Location = new Point(10, 70);
            label3.Font = new Font("Arial", 12); // Начальный размер шрифта
            Controls.Add(label3);

            // Добавляем обработчики событий для каждой метки
            label1.MouseDown += Label_MouseDown;
            label1.MouseUp += Label_MouseUp;
            label2.MouseDown += Label_MouseDown;
            label2.MouseUp += Label_MouseUp;
            label3.MouseDown += Label_MouseDown;
            label3.MouseUp += Label_MouseUp;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Name = "Form1";
            this.ResumeLayout(false);
        }

        private void Label_MouseDown(object? sender, MouseEventArgs e) // добавлен ? к sender
        {
            if (sender is Label label && e.Button == MouseButtons.Left) // проверка sender на Label и кнопку
            {
                // Уменьшаем размер шрифта на 1 пункт
                label.Font = new Font(label.Font.FontFamily, label.Font.Size - 1);
            }
        }

        private void Label_MouseUp(object? sender, MouseEventArgs e) // добавлен ? к sender
        {
            if (sender is Label label && e.Button == MouseButtons.Left) // проверка sender на Label и кнопку
            {
                // Увеличиваем размер шрифта на 1 пункт
                label.Font = new Font(label.Font.FontFamily, label.Font.Size + 1);
            }
        }
    }
}
