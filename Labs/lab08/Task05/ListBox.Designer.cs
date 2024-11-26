using System.Drawing;
using System.Windows.Forms;

private void InitializeComponent()
{
    this.Text = "Полученные сообщения";
    this.Size = new System.Drawing.Size(400, 400);

    // Список сообщений
    ListBox lstMessages = new ListBox();
    lstMessages.Name = "lstMessages";
    lstMessages.Size = new Size(350, 300);
    lstMessages.Location = new Point(20, 20);
    this.Controls.Add(lstMessages);
}
