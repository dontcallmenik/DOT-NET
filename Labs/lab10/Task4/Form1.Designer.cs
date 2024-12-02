namespace FinancialCalculator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtAmount;
        private TextBox txtTerm;
        private TextBox txtInterestRate;
        private Button btnCalculate;
        private ListView listViewPayments;
        private ColumnHeader colMonth;
        private ColumnHeader colDebt;
        private ColumnHeader colInterest;
        private ColumnHeader colPayment;

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
            this.txtAmount = new TextBox();
            this.txtTerm = new TextBox();
            this.txtInterestRate = new TextBox();
            this.btnCalculate = new Button();
            this.listViewPayments = new ListView();
            this.colMonth = new ColumnHeader();
            this.colDebt = new ColumnHeader();
            this.colInterest = new ColumnHeader();
            this.colPayment = new ColumnHeader();

            // Form Properties
            this.Text = "Фінансовий калькулятор";
            this.ClientSize = new System.Drawing.Size(400, 300);

            // txtAmount
            this.txtAmount.Location = new System.Drawing.Point(120, 20);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(200, 20);

            // txtTerm
            this.txtTerm.Location = new System.Drawing.Point(120, 50);
            this.txtTerm.Name = "txtTerm";
            this.txtTerm.Size = new System.Drawing.Size(200, 20);

            // txtInterestRate
            this.txtInterestRate.Location = new System.Drawing.Point(120, 80);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(200, 20);

            // btnCalculate
            this.btnCalculate.Location = new System.Drawing.Point(160, 120);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.Text = "OK";
            this.btnCalculate.Click += new EventHandler(this.btnCalculate_Click);

            // listViewPayments
            this.listViewPayments.Location = new System.Drawing.Point(20, 160);
            this.listViewPayments.Size = new System.Drawing.Size(360, 100);
            this.listViewPayments.View = View.Details;
            this.listViewPayments.Columns.AddRange(new ColumnHeader[] {
                this.colMonth,
                this.colDebt,
                this.colInterest,
                this.colPayment
            });

            // Column Headers
            this.colMonth.Text = "Місяць";
            this.colMonth.Width = 80;
            this.colDebt.Text = "Борг";
            this.colDebt.Width = 80;
            this.colInterest.Text = "Відсоток";
            this.colInterest.Width = 80;
            this.colPayment.Text = "Платіж";
            this.colPayment.Width = 80;

            // Adding Controls to Form
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtTerm);
            this.Controls.Add(this.txtInterestRate);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.listViewPayments);
        }
    }
}
