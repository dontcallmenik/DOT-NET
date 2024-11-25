namespace CitySelector
{
    partial class MainForm
    {
        private ComboBox comboBoxCities;
        private ListBox listBoxCities;

        private void InitializeComponent()
        {
            this.comboBoxCities = new ComboBox();
            this.listBoxCities = new ListBox();

            // Налаштування ComboBox
            this.comboBoxCities.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxCities.Location = new System.Drawing.Point(20, 20);
            this.comboBoxCities.Size = new System.Drawing.Size(200, 30);
            this.comboBoxCities.SelectedIndexChanged += new EventHandler(comboBoxCities_SelectedIndexChanged);

            // Налаштування ListBox
            this.listBoxCities.Location = new System.Drawing.Point(20, 70);
            this.listBoxCities.Size = new System.Drawing.Size(200, 150);

            // Налаштування форми
            this.ClientSize = new System.Drawing.Size(300, 250);
            this.Controls.Add(this.comboBoxCities);
            this.Controls.Add(this.listBoxCities);
            this.Text = "Вибір міст Туреччини";
        }
    }
}
