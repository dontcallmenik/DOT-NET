using System;
using System.Drawing;
using System.Windows.Forms;

namespace PictureBoxExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // Этот вызов должен работать, если файл дизайнера настроен правильно
            InitializePictureBoxes(); // Вызовите метод для инициализации PictureBox
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Здесь можно добавить любую логику, необходимую при загрузке формы.
        }

        private void InitializePictureBoxes()
        {
            // Создание PictureBox
            PictureBox pictureBox1 = new PictureBox();
            PictureBox pictureBox2 = new PictureBox();
            PictureBox pictureBox3 = new PictureBox();
            PictureBox pictureBox4 = new PictureBox();
            PictureBox pictureBox5 = new PictureBox();

            // Установка свойств для PictureBox
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Location = new Point(10, 10);
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox2.Name = "pictureBox2";
            pictureBox2.Location = new Point(120, 10);
            pictureBox2.Size = new Size(100, 100);
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox3.Name = "pictureBox3";
            pictureBox3.Location = new Point(230, 10);
            pictureBox3.Size = new Size(100, 100);
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox4.Name = "pictureBox4";
            pictureBox4.Location = new Point(10, 120);
            pictureBox4.Size = new Size(100, 100);
            pictureBox4.BorderStyle = BorderStyle.FixedSingle;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox5.Name = "pictureBox5";
            pictureBox5.Location = new Point(120, 120);
            pictureBox5.Size = new Size(100, 100);
            pictureBox5.BorderStyle = BorderStyle.FixedSingle;
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;

            // Добавление PictureBox на форму
            this.Controls.Add(pictureBox1);
            this.Controls.Add(pictureBox2);
            this.Controls.Add(pictureBox3);
            this.Controls.Add(pictureBox4);
            this.Controls.Add(pictureBox5);
        }
    }
}
