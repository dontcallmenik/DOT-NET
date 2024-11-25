using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            // Create the text boxes for the user information
            TextBox txtName = new TextBox();
            txtName.Location = new Point(10, 10);
            txtName.Size = new Size(200, 20);
            txtName.Text = "Ім'я";
            this.Controls.Add(txtName);

            TextBox txtPhone = new TextBox();
            txtPhone.Location = new Point(10, 40);
            txtPhone.Size = new Size(200, 20);
            txtPhone.Text = "Телефон";
            this.Controls.Add(txtPhone);

            TextBox txtEmail = new TextBox();
            txtEmail.Location = new Point(10, 70);
            txtEmail.Size = new Size(200, 20);
            txtEmail.Text = "Поштова скринька";
            this.Controls.Add(txtEmail);

            DateTimePicker dtpDateOfBirth = new DateTimePicker();
            dtpDateOfBirth.Location = new Point(10, 100);
            dtpDateOfBirth.Size = new Size(200, 20);
            dtpDateOfBirth.Format = DateTimePickerFormat.Short;
            dtpDateOfBirth.Text = "Дата народження";
            this.Controls.Add(dtpDateOfBirth);

            // Create the buttons
            Button btnSubmit = new Button();
            btnSubmit.Location = new Point(10, 140);
            btnSubmit.Size = new Size(100, 30);
            btnSubmit.Text = "Відіслати";
            btnSubmit.Click += new EventHandler(btnSubmit_Click);
            this.Controls.Add(btnSubmit);

            Button btnClear = new Button
            {
                Location = new Point(120, 140),
                Size = new Size(100, 30),
                Text = "Очистити"
            };
            btnClear.Click += new EventHandler(btnClear_Click); // This was the incomplete line
            this.Controls.Add(btnClear);
        }

        // Define the click event handler for the Submit button
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Handle the submit logic here
            MessageBox.Show("Form submitted!");
        }

        // Define the click event handler for the Clear button
        private void btnClear_Click(object sender, EventArgs e)
        {
            // Handle the clear logic here
            MessageBox.Show("Form cleared!");
        }
    }
}
