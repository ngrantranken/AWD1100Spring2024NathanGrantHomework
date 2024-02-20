namespace HW04_02
{
    partial class frmResortStay
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
            lblNights = new Label();
            txtNights = new TextBox();
            lblRate = new Label();
            txtRate = new TextBox();
            lblNightlyCost = new Label();
            lblTotalCost = new Label();
            btnCalculate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblNights
            // 
            lblNights.AutoSize = true;
            lblNights.Location = new Point(12, 9);
            lblNights.Name = "lblNights";
            lblNights.Size = new Size(80, 15);
            lblNights.TabIndex = 0;
            lblNights.Text = "Nights Stayed";
            // 
            // txtNights
            // 
            txtNights.Location = new Point(12, 27);
            txtNights.Name = "txtNights";
            txtNights.Size = new Size(100, 23);
            txtNights.TabIndex = 1;
            // 
            // lblRate
            // 
            lblRate.AutoSize = true;
            lblRate.Location = new Point(118, 9);
            lblRate.Name = "lblRate";
            lblRate.Size = new Size(72, 15);
            lblRate.TabIndex = 2;
            lblRate.Text = "Nightly Rate";
            // 
            // txtRate
            // 
            txtRate.Location = new Point(118, 27);
            txtRate.Name = "txtRate";
            txtRate.ReadOnly = true;
            txtRate.Size = new Size(100, 23);
            txtRate.TabIndex = 3;
            txtRate.TabStop = false;
            // 
            // lblNightlyCost
            // 
            lblNightlyCost.Location = new Point(224, 9);
            lblNightlyCost.Name = "lblNightlyCost";
            lblNightlyCost.Size = new Size(73, 44);
            lblNightlyCost.TabIndex = 4;
            lblNightlyCost.Text = "Nightly Cost";
            // 
            // lblTotalCost
            // 
            lblTotalCost.Location = new Point(318, 9);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(100, 44);
            lblTotalCost.TabIndex = 5;
            lblTotalCost.Text = "Total cost of stay";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(17, 56);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(118, 56);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(222, 56);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmResortStay
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(439, 100);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(lblTotalCost);
            Controls.Add(lblNightlyCost);
            Controls.Add(txtRate);
            Controls.Add(lblRate);
            Controls.Add(txtNights);
            Controls.Add(lblNights);
            Name = "frmResortStay";
            Text = "The Carefree Resort";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNights;
        private TextBox txtNights;
        private Label lblRate;
        private TextBox txtRate;
        private Label lblNightlyCost;
        private Label lblTotalCost;
        private Button btnCalculate;
        private Button btnClear;
        private Button btnExit;
    }
}
