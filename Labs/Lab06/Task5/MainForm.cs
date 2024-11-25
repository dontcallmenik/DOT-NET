using System;
using System.Windows.Forms;

namespace InterestsFormApp
{
    public class MainForm : Form
    {
        private CheckBox checkBoxSport;
        private CheckBox checkBoxTravel;
        private CheckBox checkBoxCrafting;
        private CheckBox checkBoxDrawing;

        private Button btnSelect;
        private Button btnCancel;

        public MainForm()
        {
            InitializeForm();
        }

        private void InitializeForm()
        {
            // Налаштування форми
            this.Text = "Вибір інтересів";
            this.Size = new System.Drawing.Size(400, 300);

            // Створення та налаштування CheckBox для інтересів
            checkBoxSport = CreateCheckBox("Спорт", 20, 50);
            checkBoxSport.Checked = true;  // Вибрано за замовчуванням

            checkBoxTravel = CreateCheckBox("Мандрівки", 20, 80);
            checkBoxTravel.Checked = true;  // Вибрано за замовчуванням

            checkBoxCrafting = CreateCheckBox("Майстрування", 20, 110);
            checkBoxDrawing = CreateCheckBox("Малювання", 20, 140);

            // Створення та налаштування кнопок
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
            this.Controls.Add(checkBoxSport);
            this.Controls.Add(checkBoxTravel);
            this.Controls.Add(checkBoxCrafting);
            this.Controls.Add(checkBoxDrawing);
            this.Controls.Add(btnSelect);
            this.Controls.Add(btnCancel);
        }

        // Метод для створення CheckBox з заданими параметрами
        private CheckBox CreateCheckBox(string text, int x, int y)
        {
            return new CheckBox
            {
                Text = text,
                Location = new System.Drawing.Point(x, y),
                AutoSize = true
            };
        }

        // Обробник кнопки "Вибрати"
        private void BtnSelect_Click(object sender, EventArgs e)
        {
            string interests = "Ви обрали: ";

            if (checkBoxSport.Checked) interests += "\n- Спорт";
            if (checkBoxTravel.Checked) interests += "\n- Мандрівки";
            if (checkBoxCrafting.Checked) interests += "\n- Майстрування";
            if (checkBoxDrawing.Checked) interests += "\n- Малювання";

            MessageBox.Show(interests, "Інтереси", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
