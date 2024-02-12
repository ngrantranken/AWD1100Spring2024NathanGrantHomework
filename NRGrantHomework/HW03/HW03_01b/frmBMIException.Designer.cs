namespace HW03_01b
{
    partial class frmBMIException
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
            lblWeight = new Label();
            lblHeight = new Label();
            lblResults = new Label();
            txtWeight = new TextBox();
            txtHeight = new TextBox();
            btnCalculate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Location = new Point(12, 9);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(69, 15);
            lblWeight.TabIndex = 0;
            lblWeight.Text = "Weight (lb):";
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Location = new Point(12, 39);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(67, 15);
            lblHeight.TabIndex = 1;
            lblHeight.Text = "Height (in):";
            // 
            // lblResults
            // 
            lblResults.AutoSize = true;
            lblResults.Location = new Point(87, 148);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(0, 15);
            lblResults.TabIndex = 2;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(87, 6);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(100, 23);
            txtWeight.TabIndex = 3;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(87, 35);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(100, 23);
            txtHeight.TabIndex = 4;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(87, 64);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(100, 23);
            btnCalculate.TabIndex = 5;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += this.btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(83, 93);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(104, 23);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += this.btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(83, 122);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(104, 23);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += this.btnExit_Click;
            // 
            // frmBMIException
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClear;
            ClientSize = new Size(259, 235);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(txtHeight);
            Controls.Add(txtWeight);
            Controls.Add(lblResults);
            Controls.Add(lblHeight);
            Controls.Add(lblWeight);
            Name = "frmBMIException";
            Text = "Body Mass Index";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWeight;
        private Label lblHeight;
        private Label lblResults;
        private TextBox txtWeight;
        private TextBox txtHeight;
        private Button btnCalculate;
        private Button btnClear;
        private Button btnExit;
    }
}
