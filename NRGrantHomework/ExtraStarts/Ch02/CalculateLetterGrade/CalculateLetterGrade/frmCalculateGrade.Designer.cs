namespace CalculateLetterGrade
{
    partial class frmCalculateGrade
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
            label1 = new Label();
            label2 = new Label();
            txtNumberGrade = new TextBox();
            txtLetterGrade = new TextBox();
            btnCalculate = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 45);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 0;
            label1.Text = "&Number grade:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 80);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 1;
            label2.Text = "Letter grade:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtNumberGrade
            // 
            txtNumberGrade.Location = new Point(179, 42);
            txtNumberGrade.Name = "txtNumberGrade";
            txtNumberGrade.Size = new Size(100, 23);
            txtNumberGrade.TabIndex = 1;
            // 
            // txtLetterGrade
            // 
            txtLetterGrade.Location = new Point(179, 77);
            txtLetterGrade.Name = "txtLetterGrade";
            txtLetterGrade.ReadOnly = true;
            txtLetterGrade.Size = new Size(100, 23);
            txtLetterGrade.TabIndex = 3;
            txtLetterGrade.TabStop = false;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(50, 120);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "&Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(204, 120);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 3;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(321, 166);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Controls.Add(txtLetterGrade);
            Controls.Add(txtNumberGrade);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculate Letter Grade";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNumberGrade;
        private TextBox txtLetterGrade;
        private Button btnCalculate;
        private Button btnExit;
    }
}
