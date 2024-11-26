using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public partial class RegistrationForm : Form
{
    public RegistrationForm()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        throw new NotImplementedException();
    }

    private void btnRegister_Click(object sender, EventArgs e)
    {
        // Логика регистрации
        string username = txtUsername.Text;
        string password = txtPassword.Text;
        string email = txtEmail.Text;

        // Сохранение данных в файл или базу данных
        MessageBox.Show("Регистрация успешна!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        this.Close(); // Закрыть форму регистрации и перейти к авторизации
    }
}
