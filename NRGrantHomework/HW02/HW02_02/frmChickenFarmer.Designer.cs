namespace HW02_02
{
    partial class frmChickenFarmer
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
            lblInputEggs = new Label();
            txtAlpha = new TextBox();
            txtBravo = new TextBox();
            txtDelta = new TextBox();
            txtCharlie = new TextBox();
            btnCalculate = new Button();
            lblResults = new Label();
            SuspendLayout();
            // 
            // lblInputEggs
            // 
            lblInputEggs.AutoSize = true;
            lblInputEggs.Font = new Font("Segoe UI", 12F);
            lblInputEggs.Location = new Point(114, 35);
            lblInputEggs.Name = "lblInputEggs";
            lblInputEggs.Size = new Size(305, 21);
            lblInputEggs.TabIndex = 0;
            lblInputEggs.Text = "Enter number of eggs laid by each chicken:";
            // 
            // txtAlpha
            // 
            txtAlpha.Font = new Font("Segoe UI", 12F);
            txtAlpha.Location = new Point(38, 70);
            txtAlpha.Name = "txtAlpha";
            txtAlpha.Size = new Size(100, 29);
            txtAlpha.TabIndex = 1;
            // 
            // txtBravo
            // 
            txtBravo.Font = new Font("Segoe UI", 12F);
            txtBravo.Location = new Point(165, 70);
            txtBravo.Name = "txtBravo";
            txtBravo.Size = new Size(100, 29);
            txtBravo.TabIndex = 2;
            // 
            // txtDelta
            // 
            txtDelta.Font = new Font("Segoe UI", 12F);
            txtDelta.Location = new Point(408, 70);
            txtDelta.Name = "txtDelta";
            txtDelta.Size = new Size(100, 29);
            txtDelta.TabIndex = 3;
            // 
            // txtCharlie
            // 
            txtCharlie.Font = new Font("Segoe UI", 12F);
            txtCharlie.Location = new Point(289, 70);
            txtCharlie.Name = "txtCharlie";
            txtCharlie.Size = new Size(100, 29);
            txtCharlie.TabIndex = 4;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI", 12F);
            btnCalculate.Location = new Point(216, 123);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(119, 40);
            btnCalculate.TabIndex = 5;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblResults
            // 
            lblResults.Font = new Font("Segoe UI", 12F);
            lblResults.Location = new Point(114, 182);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(305, 33);
            lblResults.TabIndex = 6;
            lblResults.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmChickenFarmer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 253);
            Controls.Add(lblResults);
            Controls.Add(btnCalculate);
            Controls.Add(txtCharlie);
            Controls.Add(txtDelta);
            Controls.Add(txtBravo);
            Controls.Add(txtAlpha);
            Controls.Add(lblInputEggs);
            Name = "frmChickenFarmer";
            Text = "Chicken Farmer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInputEggs;
        private TextBox txtAlpha;
        private TextBox txtBravo;
        private TextBox txtDelta;
        private TextBox txtCharlie;
        private Button btnCalculate;
        private Label lblResults;
    }
}
