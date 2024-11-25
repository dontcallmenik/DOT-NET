using System;
using System.Windows.Forms;

namespace RadioFormApp
{
    public class MainForm : Form
    {
        private GroupBox groupBoxCities;
        private GroupBox groupBoxTransport;

        private RadioButton radioKharkiv;
        private RadioButton radioKyiv;
        private RadioButton radioOdesa;
        private RadioButton radioZaporizhzhia;

        private RadioButton radioBus;
        private RadioButton radioTrain;
        private RadioButton radioPlane;

        private Button btnSelect;
        private Button btnCancel;

        public MainForm()
        {
            InitializeForm();
        }

        private void InitializeForm()
        {
            // Налаштування форми
            this.Text = "Вибір міста та транспорту";
            this.Size = new System.Drawing.Size(400, 300);

            // Налаштування GroupBox для міст
            groupBoxCities = new GroupBox
            {
                Text = "Виберіть місто:",
                Location = new System.Drawing.Point(20, 20),
                Size = new System.Drawing.Size(150, 150)
            };

            // Налаштування радіо-кнопок для міст
            radioKharkiv = CreateRadioButton("Харків", 10, 20);
            radioKyiv = CreateRadioButton("Київ", 10, 50);
            radioKyiv.Checked = true; // Вибір за замовчуванням
            radioOdesa = CreateRadioButton("Одеса", 10, 80);
            radioZaporizhzhia = CreateRadioButton("Запоріжжя", 10, 110);

            // Додавання радіо-кнопок до GroupBox міст
            groupBoxCities.Controls.AddRange(new Control[]
            {
                radioKharkiv, radioKyiv, radioOdesa, radioZaporizhzhia
            });

            // Налаштування GroupBox для транспорту
            groupBoxTransport = new GroupBox
            {
                Text = "Виберіть транспорт:",
                Location = new System.Drawing.Point(200, 20),
                Size = new System.Drawing.Size(150, 150)
            };

            // Налаштування радіо-кнопок для транспорту
            radioBus = CreateRadioButton("Автобус", 10, 20);
            radioTrain = CreateRadioButton("Потяг", 10, 50);
            radioPlane = CreateRadioButton("Літак", 10, 80);
            radioPlane.Checked = true; // Вибір за замовчуванням

            // Додавання радіо-кнопок до GroupBox транспорту
            groupBoxTransport.Controls.AddRange(new Control[]
            {
                radioBus, radioTrain, radioPlane
            });

            // Налаштування кнопок
            btnSelect = new Button
            {
                Text = "Вибрати",
                Location = new System.Drawing.Point(50, 200),
                Size = new System.Drawing.Size(100, 30)
            };
            btnSelect.Click += BtnSelect_Click;

            btnCancel = new Button
            {
                Text = "Відмовитися",
                Location = new System.Drawing.Point(200, 200),
                Size = new System.Drawing.Size(100, 30)
            };
            btnCancel.Click += (sender, e) => this.Close();

            // Додавання елементів на форму
            this.Controls.Add(groupBoxCities);
            this.Controls.Add(groupBoxTransport);
            this.Controls.Add(btnSelect);
            this.Controls.Add(btnCancel);
        }

        // Метод для створення радіо-кнопок
        private RadioButton CreateRadioButton(string text, int x, int y)
        {
            return new RadioButton
            {
                Text = text,
                Location = new System.Drawing.Point(x, y),
                AutoSize = true
            };
        }

        // Обробник події для кнопки "Вибрати"
        private void BtnSelect_Click(object sender, EventArgs e)
        {
            string selectedCity = GetSelectedRadioButtonText(groupBoxCities);
            string selectedTransport = GetSelectedRadioButtonText(groupBoxTransport);

            MessageBox.Show(
                $"Ви обрали: {selectedCity}, Транспорт: {selectedTransport}",
                "Вибір",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        // Метод для отримання тексту обраної радіо-кнопки з GroupBox
        private string GetSelectedRadioButtonText(GroupBox groupBox)
        {
            foreach (var control in groupBox.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    return radioButton.Text;
                }
            }
            return string.Empty;
        }
    }
}
