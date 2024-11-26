using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace LoginFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Метод для определения позиции сообщения об ошибке
        private Point GetErrorLabelPosition(int variant)
        {
            // Пример координат из таблицы на основе "номера варианта"
            switch (variant)
            {
                case 1: return new Point(10, 100); // Вариант 1
                case 2: return new Point(200, 100); // Вариант 2
                case 3: return new Point(10, 150); // Вариант 3
                case 4: return new Point(200, 150); // Вариант 4
                case 5: return new Point(10, 200); // Вариант 5
                case 6: return new Point(200, 200); // Вариант 6
                case 7: return new Point(10, 250); // Вариант 7
                case 8: return new Point(200, 250); // Вариант 8
                default: return new Point(10, 300); // По умолчанию
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Предустановленный логин и пароль
            string correctUsername = "admin";
            string correctPassword = "1234";

            // Получение введенных данных
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Пример: задайте номер варианта (1-8)
            int variant = 1; // Поменяйте на нужный номер

            if (username == correctUsername && password == correctPassword)
            {
                MessageBox.Show("Авторизация успешна!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblError.Visible = false; // Скрыть ошибку
            }
            else
            {
                lblError.Text = "Ошибка: неверный логин или пароль!";
                lblError.Visible = true;

                // Переместить метку в позицию из таблицы
                lblError.Location = GetErrorLabelPosition(variant);
            }
        }
    }
}
