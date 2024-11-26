using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public partial class ReceivedMessagesForm : Form
{
    public ReceivedMessagesForm()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        throw new NotImplementedException();
    }

    private void ReceivedMessagesForm_Load(object sender, EventArgs e)
    {
        // Загрузка сообщений из файла
        var messages = File.ReadAllLines("messages.txt");
        foreach (var message in messages)
        {
            lstMessages.Items.Add(message); // Добавление сообщений в ListBox
        }
    }

    private void btnViewMessage_Click(object sender, EventArgs e)
    {
        if (lstMessages.SelectedItem != null)
        {
            string selectedMessage = lstMessages.SelectedItem.ToString();
            var viewMessageForm = new ViewMessageForm(selectedMessage); // Открытие формы просмотра сообщения
            viewMessageForm.Show();
        }
        else
        {
            MessageBox.Show("Выберите сообщение для просмотра.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
