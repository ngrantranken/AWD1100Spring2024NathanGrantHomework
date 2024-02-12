namespace HW03_04
{
    partial class frmPayrollValidator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblHours = new Label();
            lblRate = new Label();
            lblGrossPay = new Label();
            txtHours = new TextBox();
            txtRate = new TextBox();
            txtGrossPay = new TextBox();
            btnCalculate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblHours
            // 
            lblHours.AutoSize = true;
            lblHours.Location = new Point(84, 24);
            lblHours.Name = "lblHours";
            lblHours.Size = new Size(141, 15);
            lblHours.TabIndex = 0;
            lblHours.Text = "Employee Hours Worked:";
            // 
            // lblRate
            // 
            lblRate.AutoSize = true;
            lblRate.Location = new Point(98, 53);
            lblRate.Name = "lblRate";
            lblRate.Size = new Size(127, 15);
            lblRate.TabIndex = 1;
            lblRate.Text = "Employee Hourly Rate:";
            // 
            // lblGrossPay
            // 
            lblGrossPay.AutoSize = true;
            lblGrossPay.Location = new Point(109, 82);
            lblGrossPay.Name = "lblGrossPay";
            lblGrossPay.Size = new Size(116, 15);
            lblGrossPay.TabIndex = 2;
            lblGrossPay.Text = "Employee Gross Pay:";
            // 
            // txtHours
            // 
            txtHours.Location = new Point(231, 21);
            txtHours.Name = "txtHours";
            txtHours.Size = new Size(100, 23);
            txtHours.TabIndex = 3;
            // 
            // txtRate
            // 
            txtRate.Location = new Point(231, 50);
            txtRate.Name = "txtRate";
            txtRate.Size = new Size(100, 23);
            txtRate.TabIndex = 4;
            // 
            // txtGrossPay
            // 
            txtGrossPay.Location = new Point(231, 79);
            txtGrossPay.Name = "txtGrossPay";
            txtGrossPay.ReadOnly = true;
            txtGrossPay.Size = new Size(100, 23);
            txtGrossPay.TabIndex = 5;
            txtGrossPay.TabStop = false;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(19, 108);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(100, 23);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(125, 108);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 23);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(231, 108);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 23);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmPayrollValidator
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(361, 158);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(txtGrossPay);
            Controls.Add(txtRate);
            Controls.Add(txtHours);
            Controls.Add(lblGrossPay);
            Controls.Add(lblRate);
            Controls.Add(lblHours);
            Name = "frmPayrollValidator";
            Text = "Employee Payroll";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHours;
        private Label lblRate;
        private Label lblGrossPay;
        private TextBox txtHours;
        private TextBox txtRate;
        private TextBox txtGrossPay;
        private Button btnCalculate;
        private Button btnClear;
        private Button btnExit;
    }
}
