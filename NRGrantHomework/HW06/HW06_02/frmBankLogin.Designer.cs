namespace HW06_02
{
    partial class frmBankLogin
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
            lblAccountNumber = new Label();
            lblPinNumber = new Label();
            txtAccountNumber = new TextBox();
            txtPinNumber = new TextBox();
            btnLogin = new Button();
            lblCustomerInfo = new Label();
            btnLogout = new Button();
            btnExit = new Button();
            btnDeposit = new Button();
            btnWithdraw = new Button();
            lblDeposit = new Label();
            lblWithdraw = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // lblAccountNumber
            // 
            lblAccountNumber.AutoSize = true;
            lblAccountNumber.Location = new Point(12, 9);
            lblAccountNumber.Name = "lblAccountNumber";
            lblAccountNumber.Size = new Size(62, 15);
            lblAccountNumber.TabIndex = 0;
            lblAccountNumber.Text = "Account #";
            // 
            // lblPinNumber
            // 
            lblPinNumber.AutoSize = true;
            lblPinNumber.Location = new Point(12, 38);
            lblPinNumber.Name = "lblPinNumber";
            lblPinNumber.Size = new Size(34, 15);
            lblPinNumber.TabIndex = 1;
            lblPinNumber.Text = "Pin #";
            // 
            // txtAccountNumber
            // 
            txtAccountNumber.Location = new Point(79, 6);
            txtAccountNumber.Name = "txtAccountNumber";
            txtAccountNumber.Size = new Size(100, 23);
            txtAccountNumber.TabIndex = 3;
            // 
            // txtPinNumber
            // 
            txtPinNumber.Location = new Point(79, 35);
            txtPinNumber.Name = "txtPinNumber";
            txtPinNumber.Size = new Size(100, 23);
            txtPinNumber.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(185, 35);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "&Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblCustomerInfo
            // 
            lblCustomerInfo.Location = new Point(12, 71);
            lblCustomerInfo.Name = "lblCustomerInfo";
            lblCustomerInfo.Size = new Size(248, 40);
            lblCustomerInfo.TabIndex = 6;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(8, 250);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "L&ogout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(132, 250);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 8;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnDeposit
            // 
            btnDeposit.Location = new Point(132, 138);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(75, 23);
            btnDeposit.TabIndex = 9;
            btnDeposit.Text = "&Deposit";
            btnDeposit.UseVisualStyleBackColor = true;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // btnWithdraw
            // 
            btnWithdraw.Location = new Point(132, 193);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(75, 23);
            btnWithdraw.TabIndex = 10;
            btnWithdraw.Text = "&Withdraw";
            btnWithdraw.UseVisualStyleBackColor = true;
            btnWithdraw.Click += btnWithdraw_Click;
            // 
            // lblDeposit
            // 
            lblDeposit.AutoSize = true;
            lblDeposit.Location = new Point(8, 120);
            lblDeposit.Name = "lblDeposit";
            lblDeposit.Size = new Size(191, 15);
            lblDeposit.TabIndex = 11;
            lblDeposit.Text = "Would you like to make a deposit:?";
            // 
            // lblWithdraw
            // 
            lblWithdraw.AutoSize = true;
            lblWithdraw.Location = new Point(12, 175);
            lblWithdraw.Name = "lblWithdraw";
            lblWithdraw.Size = new Size(207, 15);
            lblWithdraw.TabIndex = 12;
            lblWithdraw.Text = "Would you like to make a withdrawal?";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 138);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(114, 23);
            textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 193);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(114, 23);
            textBox2.TabIndex = 14;
            // 
            // frmBankLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(289, 299);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblWithdraw);
            Controls.Add(lblDeposit);
            Controls.Add(btnWithdraw);
            Controls.Add(btnDeposit);
            Controls.Add(btnExit);
            Controls.Add(btnLogout);
            Controls.Add(lblCustomerInfo);
            Controls.Add(btnLogin);
            Controls.Add(txtPinNumber);
            Controls.Add(txtAccountNumber);
            Controls.Add(lblPinNumber);
            Controls.Add(lblAccountNumber);
            Name = "frmBankLogin";
            Text = "Weyland Bank";
            Load += frmBankLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAccountNumber;
        private Label lblPinNumber;
        private Label label3;
        private TextBox txtAccountNumber;
        private TextBox txtPinNumber;
        private Button btnLogin;
        private Label lblCustomerInfo;
        private Button btnLogout;
        private Button btnExit;
        private Button btnDeposit;
        private Button btnWithdraw;
        private Label lblDeposit;
        private Label lblWithdraw;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}
