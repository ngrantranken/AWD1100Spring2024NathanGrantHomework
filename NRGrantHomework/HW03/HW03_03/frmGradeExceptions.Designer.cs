namespace HW03_03
{
    partial class frmGradeExceptions
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
            lblTest1 = new Label();
            lblTest2 = new Label();
            lblTest3 = new Label();
            lblAverage = new Label();
            txtTest1 = new TextBox();
            txtTest2 = new TextBox();
            txtTest3 = new TextBox();
            txtAverage = new TextBox();
            btnExit = new Button();
            btnCalculate = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // lblTest1
            // 
            lblTest1.AutoSize = true;
            lblTest1.Location = new Point(171, 15);
            lblTest1.Name = "lblTest1";
            lblTest1.Size = new Size(46, 15);
            lblTest1.TabIndex = 0;
            lblTest1.Text = "Test #1:";
            // 
            // lblTest2
            // 
            lblTest2.AutoSize = true;
            lblTest2.Location = new Point(171, 44);
            lblTest2.Name = "lblTest2";
            lblTest2.Size = new Size(46, 15);
            lblTest2.TabIndex = 1;
            lblTest2.Text = "Test #2:";
            // 
            // lblTest3
            // 
            lblTest3.AutoSize = true;
            lblTest3.Location = new Point(171, 73);
            lblTest3.Name = "lblTest3";
            lblTest3.Size = new Size(46, 15);
            lblTest3.TabIndex = 2;
            lblTest3.Text = "Test #3:";
            // 
            // lblAverage
            // 
            lblAverage.AutoSize = true;
            lblAverage.Location = new Point(105, 102);
            lblAverage.Name = "lblAverage";
            lblAverage.Size = new Size(112, 15);
            lblAverage.TabIndex = 3;
            lblAverage.Text = "Test Average/Grade:";
            // 
            // txtTest1
            // 
            txtTest1.Location = new Point(223, 12);
            txtTest1.Name = "txtTest1";
            txtTest1.Size = new Size(100, 23);
            txtTest1.TabIndex = 4;
            // 
            // txtTest2
            // 
            txtTest2.Location = new Point(223, 41);
            txtTest2.Name = "txtTest2";
            txtTest2.Size = new Size(100, 23);
            txtTest2.TabIndex = 5;
            // 
            // txtTest3
            // 
            txtTest3.Location = new Point(223, 70);
            txtTest3.Name = "txtTest3";
            txtTest3.Size = new Size(100, 23);
            txtTest3.TabIndex = 6;
            // 
            // txtAverage
            // 
            txtAverage.Location = new Point(223, 99);
            txtAverage.Name = "txtAverage";
            txtAverage.ReadOnly = true;
            txtAverage.Size = new Size(100, 23);
            txtAverage.TabIndex = 7;
            txtAverage.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(223, 137);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 23);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(11, 137);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(100, 23);
            btnCalculate.TabIndex = 9;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(117, 137);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 23);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // frmGradeCalculator
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(349, 184);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(btnExit);
            Controls.Add(txtAverage);
            Controls.Add(txtTest3);
            Controls.Add(txtTest2);
            Controls.Add(txtTest1);
            Controls.Add(lblAverage);
            Controls.Add(lblTest3);
            Controls.Add(lblTest2);
            Controls.Add(lblTest1);
            Name = "frmGradeCalculator";
            Text = "Grade Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTest1;
        private Label lblTest2;
        private Label lblTest3;
        private Label lblAverage;
        private TextBox txtTest1;
        private TextBox txtTest2;
        private TextBox txtTest3;
        private TextBox txtAverage;
        private Button btnExit;
        private Button btnCalculate;
        private Button btnClear;
    }
}
