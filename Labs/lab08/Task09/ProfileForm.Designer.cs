using System;
using System.Drawing;
using System.Windows.Forms;

namespace UserMessageApp
{
    public partial class ProfileForm : Form
    {
        private TextBox txtName;
        private TextBox txtEmail;
        private Button btnSaveChanges;

        public ProfileForm()
        {
            InitializeComponent();
            CreateDesign();
        }

        private void CreateDesign()
        {
            // Инициализация TextBox для имени пользователя
            txtName = new TextBox();
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Введите ваше имя";
            txtName.Location = new Point(50, 50);
            txtName.Width = 200;

            // Инициализация TextBox для email
            txtEmail = new TextBox();
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Введите ваш email";
            txtEmail.Location = new Point(50, 100);
            txtEmail.Width = 200;

            // Инициализация Button для сохранения изменений
            btnSaveChanges = new Button();
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Text = "Сохранить изменения";
            btnSaveChanges.Location = new Point(50, 150);
            btnSaveChanges.Click += BtnSaveChanges_Click;

            // Добавление элементов на форму
            this.Controls.Add(txtName);
            this.Controls.Add(txtEmail);
            this.Controls.Add(btnSaveChanges);
        }

        private void BtnSaveChanges_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Имя: {txtName.Text}\nEmail: {txtEmail.Text}\nИзменения сохранены!", "Успех");
        }
    }
}
