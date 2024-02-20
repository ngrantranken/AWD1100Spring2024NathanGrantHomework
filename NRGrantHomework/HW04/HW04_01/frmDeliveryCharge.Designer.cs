namespace HW04_01
{
    partial class frmDeliveryCharge
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
            lblZipCode = new Label();
            lblDeliveryCharge = new Label();
            txtZipCode = new TextBox();
            btnCalculate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblZipCode
            // 
            lblZipCode.AutoSize = true;
            lblZipCode.Location = new Point(12, 9);
            lblZipCode.Name = "lblZipCode";
            lblZipCode.Size = new Size(55, 15);
            lblZipCode.TabIndex = 0;
            lblZipCode.Text = "Zip Code";
            // 
            // lblDeliveryCharge
            // 
            lblDeliveryCharge.Location = new Point(210, 30);
            lblDeliveryCharge.Name = "lblDeliveryCharge";
            lblDeliveryCharge.Size = new Size(90, 48);
            lblDeliveryCharge.TabIndex = 1;
            lblDeliveryCharge.Text = "Delivery Charge";
            // 
            // txtZipCode
            // 
            txtZipCode.Location = new Point(12, 27);
            txtZipCode.Name = "txtZipCode";
            txtZipCode.Size = new Size(100, 23);
            txtZipCode.TabIndex = 2;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(118, 26);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 3;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(118, 55);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(37, 56);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmDeliveryCharge
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(313, 107);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(txtZipCode);
            Controls.Add(lblDeliveryCharge);
            Controls.Add(lblZipCode);
            Name = "frmDeliveryCharge";
            Text = "Delivery Charge";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblZipCode;
        private Label lblDeliveryCharge;
        private TextBox txtZipCode;
        private Button btnCalculate;
        private Button btnClear;
        private Button btnExit;
    }
}
