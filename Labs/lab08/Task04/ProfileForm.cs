using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace UserProfileApp
{
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Логика сохранения изменений профиля
            string newName = txtName.Text;
            string newEmail = txtEmail.Text;
            string newPassword = txtPassword.Text;

            // Здесь можно добавить валидацию или обновление данных
            MessageBox.Show("Параметры профиля успешно сохранены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Закрываем форму профиля без сохранения
            this.Close();
        }
    }
}
