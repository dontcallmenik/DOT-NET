using System.Windows.Forms;

private void InitializeComponent() => throw new NotImplementedException();

private void Form1_Load(object sender, EventArgs e)
{
    // Create a GroupBox control.
    GroupBox groupBox = new GroupBox();
    groupBox.Text = "Вибір";
    groupBox.Location = new Point(10, 10);
    groupBox.Size = new Size(200, 100);

    // Create three RadioButtons.
    RadioButton radioButton1 = new RadioButton();
    radioButton1.Text = "Варіант 1";
    radioButton1.Location = new Point(20, 30);

    RadioButton radioButton2 = new RadioButton();
    radioButton2.Text = "Варіант 2";
    radioButton2.Location = new Point(20, 60);

    RadioButton radioButton3 = new RadioButton();
    radioButton3.Text = "Варіант 3";
    radioButton3.Location = new Point(20, 90);

    // Set the Checked property of the first RadioButton to true.
    radioButton1.Checked = true;

    // Add the RadioButtons to the GroupBox.
    groupBox.Controls.Add(radioButton1);
    groupBox.Controls.Add(radioButton2);
    groupBox.Controls.Add(radioButton3);

    // Add the GroupBox to the form.
    Controls.Add(groupBox);
}