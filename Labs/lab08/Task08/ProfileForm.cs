using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public partial class ProfileForm : Form
{
    public ProfileForm()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        throw new NotImplementedException();
    }

    private void btnSaveProfile_Click(object sender, EventArgs e)
    {
        // Логика сохранения данных профиля
        MessageBox.Show("Данные профиля сохранены.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        ShowMessageForm(); // Переход к форме отправки сообщений
    }

    private void ShowMessageForm()
    {
        var messageForm = new MessageForm(); // Открытие формы отправки сообщений
        messageForm.Show();
    }
}
