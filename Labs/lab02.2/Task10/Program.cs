namespace Task10
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    namespace TextBoxEventExample
    {
        public partial class Form1 : Form
        {
            private TextBox[] textBoxes;

            public Form1()
            {
                InitializeComponent();

                // Создаем массив текстовых полей
                textBoxes = new TextBox[3];

                // Создаем текстовые поля и добавляем их на форму
                for (int i = 0; i < textBoxes.Length; i++)
                {
                    textBoxes[i] = new TextBox();
                    textBoxes[i].Location = new Point(100, 50 + (i * 40)); // Устанавливаем позицию
                    textBoxes[i].Size = new Size(200, 30); // Устанавливаем размер
                    textBoxes[i].Enter += TextBox_EnterLeave; // Добавляем обработчик события Enter
                    textBoxes[i].Leave += TextBox_EnterLeave; // Добавляем обработчик события Leave
                    Controls.Add(textBoxes[i]); // Добавляем текстовое поле на форму
                }
            }

            private void InitializeComponent()
            {
                this.SuspendLayout();
                // 
                // Form1
                // 
                this.ClientSize = new System.Drawing.Size(400, 200);
                this.Name = "Form1";
                this.Text = "TextBox Event Example";
                this.ResumeLayout(false);
            }

            // Обработчик события Enter и Leave
            private void TextBox_EnterLeave(object? sender, EventArgs e) // Указываем, что sender может быть null
            {
                if (sender is TextBox textBox) // Проверяем, что sender это TextBox
                {
                    if (e is EventArgs) // Определяем, произошло ли событие Enter или Leave
                    {
                        if (textBox.Focused) // Если TextBox получил фокус (Enter)
                        {
                            textBox.BackColor = Color.LightYellow; // Изменяем цвет фона
                            textBox.Text = "Кафедра САІТ"; // Устанавливаем текст
                        }
                        else // Если TextBox потерял фокус (Leave)
                        {
                            textBox.BackColor = SystemColors.Window; // Сбрасываем цвет фона
                            textBox.Text = ""; // Очищаем текст
                        }
                    }
                }
            }
        }
    }
}
