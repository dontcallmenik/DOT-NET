using System;
using System.Drawing;
using System.Windows.Forms;  // Импортируем Windows Forms

namespace DoubleClickExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Привязываем обработчики событий DoubleClick
            label1.DoubleClick += Label_DoubleClick;
            label2.DoubleClick += Label_DoubleClick;
            label3.DoubleClick += Label_DoubleClick;
        }

        // Обработчик события DoubleClick
        private void Label_DoubleClick(object sender, EventArgs e)
        {
            // Используем полное имя типа для избежания конфликта
            System.Windows.Forms.Label label = sender as System.Windows.Forms.Label;
            if (label != null)
            {
                // Переключаем между обычным и подчёркнутым шрифтом
                if (label.Font.Underline)
                {
                    label.Font = new Font(label.Font, FontStyle.Regular);
                }
                else
                {
                    label.Font = new Font(label.Font, FontStyle.Underline);
                }
            }
        }
    }
}
