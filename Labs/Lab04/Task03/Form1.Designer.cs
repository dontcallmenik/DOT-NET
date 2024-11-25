using System;
using System.Windows.Forms;

namespace Task03
{
    public partial class Form1 : Form
    {
        private CheckBox checkBoxSport;
        private CheckBox checkBoxTravel;
        private CheckBox checkBoxCrafting;
        private CheckBox checkBoxPainting;
        private Button buttonChoose;
        private Button buttonReject;

        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.checkBoxSport = new System.Windows.Forms.CheckBox();
            this.checkBoxTravel = new System.Windows.Forms.CheckBox();
            this.checkBoxCrafting = new System.Windows.Forms.CheckBox();
            this.checkBoxPainting = new System.Windows.Forms.CheckBox();
            this.buttonChoose = new System.Windows.Forms.Button();
            this.buttonReject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBoxSport
            // 
            this.checkBoxSport.AutoSize = true;
            this.checkBoxSport.Location = new System.Drawing.Point(12, 12);
            this.checkBoxSport.Name = "checkBoxSport";
            this.checkBoxSport.Size = new System.Drawing.Size(61, 17);
            this.checkBoxSport.TabIndex = 0;
            this.checkBoxSport.Text = "Спорт";
            this.checkBoxSport.UseVisualStyleBackColor = true;
            // 
            // checkBoxTravel
            // 
            this.checkBoxTravel.AutoSize = true;
            this.checkBoxTravel.Checked = true;
            this.checkBoxTravel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTravel.Location = new System.Drawing.Point(12, 35);
            this.checkBoxTravel.Name = "checkBoxTravel";
            this.checkBoxTravel.Size = new System.Drawing.Size(85, 17);
            this.checkBoxTravel.TabIndex = 1;
            this.checkBoxTravel.Text = "Мандрівки";
            this.checkBoxTravel.UseVisualStyleBackColor = true;
            // 
            // checkBoxCrafting
            // 
            this.checkBoxCrafting.AutoSize = true;
            this.checkBoxCrafting.Location = new System.Drawing.Point(12, 58);
            this.checkBoxCrafting.Name = "checkBoxCrafting";
            this.checkBoxCrafting.Size = new System.Drawing.Size(94, 17);
            this.checkBoxCrafting.TabIndex = 2;
            this.checkBoxCrafting.Text = "Ремесло";
            this.checkBoxCrafting.UseVisualStyleBackColor = true;
            // 
            // checkBoxPainting
            // 
            this.checkBoxPainting.AutoSize = true;
            this.checkBoxPainting.Location = new System.Drawing.Point(12, 81);
            this.checkBoxPainting.Name = "checkBoxPainting";
            this.checkBoxPainting.Size = new System.Drawing.Size(85, 17);
            this.checkBoxPainting.TabIndex = 3;
            this.checkBoxPainting.Text = "Малювання";
            this.checkBoxPainting.UseVisualStyleBackColor = true;
            // 
            // buttonChoose
            // 
            this.buttonChoose.Location = new System.Drawing.Point(12, 104);
            this.buttonChoose.Name = "buttonChoose";
            this.buttonChoose.Size = new System.Drawing.Size(75, 23);
            this.buttonChoose.TabIndex = 4;
            this.buttonChoose.Text = "Вибрати";
            this.buttonChoose.UseVisualStyleBackColor = true;
            this.buttonChoose.Click += new System.EventHandler(this.buttonChoose_Click);
            // 
            // buttonReject
            // 
            this.buttonReject.Location = new System.Drawing.Point(93, 104);
            this.buttonReject.Name = "buttonReject";
            this.buttonReject.Size = new System.Drawing.Size(75, 23);
            this.buttonReject.TabIndex = 5;
            this.buttonReject.Text = "Відмовитися";
            this.buttonReject.UseVisualStyleBackColor = true;
            this.buttonReject.Click += new System.EventHandler(this.buttonReject_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonReject);
            this.Controls.Add(this.buttonChoose);
            this.Controls.Add(this.checkBoxPainting);
            this.Controls.Add(this.checkBoxCrafting);
            this.Controls.Add(this.checkBoxTravel);
            this.Controls.Add(this.checkBoxSport);
            this.Name = "Form1";
            this.Text = "Вибір варіантів";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void buttonChoose_Click(object sender, EventArgs e)
        {
            string message = "Ви обрали такі варіанти: ";
            if (checkBoxSport.Checked)
            {
                message += "Спорт, ";
            }
            if (checkBoxTravel.Checked)
            {
                message += "Мандрівки, ";
            }
            if (checkBoxCrafting.Checked)
            {
                message += "Ремесло, ";
            }
            if (checkBoxPainting.Checked)
            {
                message += "Малювання, ";
            }
            MessageBox.Show(message.TrimEnd(',', ' '));  // Удаляет лишнюю запятую и пробел
        }

        private void buttonReject_Click(object sender, EventArgs e)
        {
            // Снимаем выделение со всех чекбоксов
            checkBoxSport.Checked = false;
            checkBoxTravel.Checked = false;
            checkBoxCrafting.Checked = false;
            checkBoxPainting.Checked = false;
        }
    }
}
