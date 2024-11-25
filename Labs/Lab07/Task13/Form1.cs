using System;
using System.Windows.Forms;

namespace HotKeysApp
{
    public partial class Form1 : Form
    {
        private ListBox listBox;

        public Form1()
        {
            InitializeComponent();
        }

        // Метод для обробки натискання клавіш
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.A))
            {
                AddListBox(); // Додаємо ListBox при Ctrl + A
                return true;
            }
            else if (keyData == (Keys.Control | Keys.Shift | Keys.D))
            {
                RemoveListBox(); // Видаляємо ListBox при Ctrl + Shift + D
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        // Метод для додавання ListBox на форму
        private void AddListBox()
        {
            if (listBox == null)
            {
                listBox = new ListBox
                {
                    Location = new System.Drawing.Point(20, 20),
                    Size = new System.Drawing.Size(200, 100),
                    Name = "listBox"
                };

                // Додаємо 4 елементи до ListBox
                listBox.Items.AddRange(new object[] { "Елемент 1", "Елемент 2", "Елемент 3", "Елемент 4" });
                this.Controls.Add(listBox);
            }
        }

        // Метод для видалення ListBox з форми
        private void RemoveListBox()
        {
            if (listBox != null)
            {
                this.Controls.Remove(listBox);
                listBox.Dispose();
                listBox = null;
            }
        }
    }
}
