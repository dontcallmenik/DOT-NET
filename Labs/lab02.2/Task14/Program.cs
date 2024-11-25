using System;
using System.Drawing;
using System.Windows.Forms;

namespace LoadFormExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load; // Подписка на событие загрузки формы
        }

        private void InitializeComponent()
        {
            // Настройки формы
            this.ClientSize = new Size(400, 300);
            this.Name = "Form1";
            this.Text = "Пример загрузки формы";
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Отключаем кнопки сворачивания и разворачивания
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void Form1_Load(object? sender, EventArgs e) // Добавлено "?" для sender
        {
            // Диалоговое окно с вопросом о загрузке формы
            DialogResult result = MessageBox.Show(
                "Хотите загрузить форму?",
                "Загрузка формы",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                // Если ответ "НЕТ", закрываем форму
                this.Close();
            }
            else
            {
                // Если ответ "ДА", показываем варианты размещения
                ShowLayoutOptions();
            }
        }

        private void ShowLayoutOptions()
        {
            string[] options = {
                "1. Верхняя половина экрана",
                "2. Нижняя правая четверть экрана",
                "3. Нижняя половина экрана",
                "4. Нижняя левая четверть экрана",
                "5. Левая половина экрана"
            };

            // Выбор размещения формы
            string option = Microsoft.VisualBasic.Interaction.InputBox(
                "Выберите вариант размещения формы:\n1-5",
                "Варианты размещения",
                "1");

            if (int.TryParse(option, out int selectedOption) && selectedOption >= 1 && selectedOption <= 5)
            {
                switch (selectedOption)
                {
                    case 1:
                        this.Location = new Point(0, 0);
                        this.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height / 2);
                        break;
                    case 2:
                        this.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2);
                        this.Size = new Size(Screen.PrimaryScreen.Bounds.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2);
                        break;
                    case 3:
                        this.Location = new Point(0, Screen.PrimaryScreen.Bounds.Height / 2);
                        this.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height / 2);
                        break;
                    case 4:
                        this.Location = new Point(0, Screen.PrimaryScreen.Bounds.Height / 2);
                        this.Size = new Size(Screen.PrimaryScreen.Bounds.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2);
                        break;
                    case 5:
                        this.Location = new Point(0, 0);
                        this.Size = new Size(Screen.PrimaryScreen.Bounds.Width / 2, Screen.PrimaryScreen.Bounds.Height);
                        break;
                }
            }
            else
            {
                MessageBox.Show("Неверный ввод. Форма будет закрыта.");
                this.Close();
            }
        }
    }
}
