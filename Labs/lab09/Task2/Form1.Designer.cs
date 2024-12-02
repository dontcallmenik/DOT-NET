namespace CurrencyExchangeApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHryvniaAmount;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.ComboBox comboConversionDirection;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtHryvniaAmount = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.comboConversionDirection = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сума у грн.";

            // 
            // txtHryvniaAmount
            // 
            this.txtHryvniaAmount.Location = new System.Drawing.Point(120, 20);
            this.txtHryvniaAmount.Name = "txtHryvniaAmount";
            this.txtHryvniaAmount.Size = new System.Drawing.Size(100, 20);
            this.txtHryvniaAmount.TabIndex = 1;
            this.txtHryvniaAmount.TextChanged += new System.EventHandler(this.txtHryvniaAmount_TextChanged);
            this.txtHryvniaAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHryvniaAmount_KeyPress);

            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(120, 100);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 30);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Enabled = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);

            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(20, 150);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 3;

            // 
            // comboConversionDirection
            // 
            this.comboConversionDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboConversionDirection.Items.AddRange(new object[] {
            "Hryvnia to Krone",
            "Krone to Hryvnia"});
            this.comboConversionDirection.Location = new System.Drawing.Point(20, 60);
            this.comboConversionDirection.Name = "comboConversionDirection";
            this.comboConversionDirection.Size = new System.Drawing.Size(200, 21);
            this.comboConversionDirection.TabIndex = 4;
            this.comboConversionDirection.SelectedIndex = 0;
            this.comboConversionDirection.SelectedIndexChanged += new System.EventHandler(this.comboConversionDirection_SelectedIndexChanged);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 200);
            this.Controls.Add(this.comboConversionDirection);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtHryvniaAmount);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Обмін валют";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
