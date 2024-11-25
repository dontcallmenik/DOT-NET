private System.Windows.Forms.ComboBox currencyComboBox;

private void InitializeComponent()
{
    this.currencyComboBox = new System.Windows.Forms.ComboBox();
    // 
    // currencyComboBox
    // 
    this.currencyComboBox.FormattingEnabled = true;
    this.currencyComboBox.Items.AddRange(new object[] {
        "Гривні (UAH)",
        "Долари (USD)"
    });
    this.currencyComboBox.Location = new System.Drawing.Point(20, 170);
    this.currencyComboBox.Name = "currencyComboBox";
    this.currencyComboBox.Size = new System.Drawing.Size(150, 23);
    this.currencyComboBox.TabIndex = 7;
    this.currencyComboBox.SelectedIndexChanged += new System.EventHandler(this.currencyComboBox_SelectedIndexChanged);
    // 
    // Add components to form
    this.Controls.Add(this.currencyComboBox);
}
