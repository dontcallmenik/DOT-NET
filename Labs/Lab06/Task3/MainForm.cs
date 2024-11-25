using System;
using System.Windows.Forms;

namespace RegistrationForm
{
    public class MainForm : Form
    {
        private TextBox txtName;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtBirthDate;
        private Button btnReset;
        private Button btnSubmit;

        public MainForm()
        {
            InitializeForm();
        }

        private void InitializeForm()
        {
            // Налаштування форми
            this.Text = "Реєстраційна форма";
            this.Size = new System.Drawing.Size(400, 300);

            // Створення і налаштування текстових полів
            txtName = CreateTextBox(150, 20);
            txtPhone = CreateTextBox(150, 60);
            txtEmail = CreateTextBox(150, 100);
            txtBirthDate = CreateTextBox(150, 140);

            // Створення і налаштування кнопок
            btnReset = new Button
            {
                Text = "Скинути",
                Location = new System.Drawing.Point(50, 200),
                Size = new System.Drawing.Size(100, 30)
            };
            btnReset.Click += BtnReset_Click;

            btnSubmit = new Button
            {
                Text = "Відправити",
                Location = new System.Drawing.Point(200, 200),
                Size = new System.Drawing.Size(100, 30)
            };
            btnSubmit.Click += BtnSubmit_Click;

            // Додавання елементів на форму
            this.Controls.Add(CreateLabel("Ім'я", 20, 20));
            this.Controls.Add(CreateLabel("Телефон", 20, 60));
            this.Controls.Add(CreateLabel("Поштова скринька", 20, 100));
            this.Controls.Add(CreateLabel("Дата народження", 20, 140));
            this.Controls.Add(txtName);
            this.Controls.Add(txtPhone);
            this.Controls.Add(txtEmail);
            this.Controls.Add(txtBirthDate);
            this.Controls.Add(btnReset);
            this.Controls.Add(btnSubmit);
        }

        // Метод для створення текстових полів
        private TextBox CreateTextBox(int x, int y)
        {
            return new TextBox
            {
                Location = new System.Drawing.Point(x, y),
                Size = new System.Drawing.Size(200, 30)
            };
        }

        // Метод для створення міток (Label)
        private Label CreateLabel(string text, int x, int y)
        {
            return new Label
            {
                Text = text,
                Location = new System.Drawing.Point(x, y),
                AutoSize = true
            };
        }

        // Обробник кнопки "Скинути"
        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtBirthDate.Clear();
        }

        // Обробник кнопки "Відправити"
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            string message = $"Ім'я: {txtName.Text}\nТелефон: {txtPhone.Text}\n" +
                             $"Пошта: {txtEmail.Text}\nДата народження: {txtBirthDate.Text}";
            MessageBox.Show(message, "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
