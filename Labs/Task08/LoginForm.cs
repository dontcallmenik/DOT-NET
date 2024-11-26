using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public partial class LoginForm : Form
{
    public LoginForm()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        throw new NotImplementedException();
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        // Логика авторизации
        string username = txtUsername.Text;
        string password = txtPassword.Text;

        if (username == "admin" && password == "password") // Пример проверки
        {
            this.Close();
            ShowProfileForm(); // Переход к профильной форме
        }
        else
        {
            MessageBox.Show("Неверный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ShowProfileForm()
    {
        var profileForm = new ProfileForm(); // Открытие формы профиля
        profileForm.Show();
    }
}
