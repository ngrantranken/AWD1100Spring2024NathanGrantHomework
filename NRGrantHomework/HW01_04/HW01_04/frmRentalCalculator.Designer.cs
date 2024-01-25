namespace HW01_04
{
    partial class frmRentalCalculator
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
            lblDays = new Label();
            lblMiles = new Label();
            lblFees = new Label();
            btnCalculate = new Button();
            txtDays = new TextBox();
            txtMiles = new TextBox();
            txtFees = new TextBox();
            SuspendLayout();
            // 
            // lblDays
            // 
            lblDays.Font = new Font("Segoe UI", 12F);
            lblDays.Location = new Point(77, 28);
            lblDays.Name = "lblDays";
            lblDays.Size = new Size(100, 23);
            lblDays.TabIndex = 0;
            lblDays.Text = "Days rented:";
            // 
            // lblMiles
            // 
            lblMiles.Font = new Font("Segoe UI", 12F);
            lblMiles.Location = new Point(77, 64);
            lblMiles.Name = "lblMiles";
            lblMiles.Size = new Size(100, 23);
            lblMiles.TabIndex = 1;
            lblMiles.Text = "Miles driven:";
            // 
            // lblFees
            // 
            lblFees.AutoSize = true;
            lblFees.Font = new Font("Segoe UI", 12F);
            lblFees.Location = new Point(77, 98);
            lblFees.Name = "lblFees";
            lblFees.Size = new Size(77, 21);
            lblFees.TabIndex = 2;
            lblFees.Text = "Total fees:";
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI", 12F);
            btnCalculate.Location = new Point(159, 148);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(86, 31);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // txtDays
            // 
            txtDays.Font = new Font("Segoe UI", 12F);
            txtDays.Location = new Point(209, 25);
            txtDays.Name = "txtDays";
            txtDays.Size = new Size(100, 29);
            txtDays.TabIndex = 0;
            // 
            // txtMiles
            // 
            txtMiles.Font = new Font("Segoe UI", 12F);
            txtMiles.Location = new Point(209, 61);
            txtMiles.Name = "txtMiles";
            txtMiles.Size = new Size(100, 29);
            txtMiles.TabIndex = 1;
            // 
            // txtFees
            // 
            txtFees.Font = new Font("Segoe UI", 12F);
            txtFees.Location = new Point(209, 95);
            txtFees.Name = "txtFees";
            txtFees.ReadOnly = true;
            txtFees.Size = new Size(100, 29);
            txtFees.TabIndex = 6;
            txtFees.TabStop = false;
            // 
            // frmRentalCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 191);
            Controls.Add(txtFees);
            Controls.Add(txtMiles);
            Controls.Add(txtDays);
            Controls.Add(btnCalculate);
            Controls.Add(lblFees);
            Controls.Add(lblMiles);
            Controls.Add(lblDays);
            Name = "frmRentalCalculator";
            Text = "Rental Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDays;
        private Label lblMiles;
        private Label lblFees;
        private Button btnCalculate;
        private TextBox txtDays;
        private TextBox txtMiles;
        private TextBox txtFees;
    }
}
