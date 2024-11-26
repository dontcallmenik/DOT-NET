using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Windows.Forms;

namespace UserMessageApp
{
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
            // Пример проверки логина и пароля (можно заменить на реальную логику)
            if (txtLogin.Text == "admin" && txtPassword.Text == "password")
            {
                var profileForm = new ProfileForm(); // Открываем профильную форму после успешной авторизации
                profileForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
