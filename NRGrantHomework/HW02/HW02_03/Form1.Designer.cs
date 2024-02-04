namespace HW02_03
{
    partial class Form1
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
            grpEmployee1 = new GroupBox();
            lblName1 = new Label();
            lblSalary1 = new Label();
            txtName1 = new TextBox();
            txtSalary1 = new TextBox();
            grpEmployee2 = new GroupBox();
            lblName2 = new Label();
            lblSalary2 = new Label();
            txtSalary2 = new TextBox();
            txtName2 = new TextBox();
            grpEmployee3 = new GroupBox();
            txtSalary3 = new TextBox();
            txtName3 = new TextBox();
            lblSalary3 = new Label();
            lblName3 = new Label();
            btnCalculate = new Button();
            lblResults = new Label();
            grpEmployee1.SuspendLayout();
            grpEmployee2.SuspendLayout();
            grpEmployee3.SuspendLayout();
            SuspendLayout();
            // 
            // grpEmployee1
            // 
            grpEmployee1.Controls.Add(lblName1);
            grpEmployee1.Controls.Add(lblSalary1);
            grpEmployee1.Controls.Add(txtName1);
            grpEmployee1.Controls.Add(txtSalary1);
            grpEmployee1.Location = new Point(0, 6);
            grpEmployee1.Name = "grpEmployee1";
            grpEmployee1.Size = new Size(153, 171);
            grpEmployee1.TabIndex = 1;
            grpEmployee1.TabStop = false;
            grpEmployee1.Text = "Employee 1";
            // 
            // lblName1
            // 
            lblName1.AutoSize = true;
            lblName1.Location = new Point(21, 30);
            lblName1.Name = "lblName1";
            lblName1.Size = new Size(39, 15);
            lblName1.TabIndex = 0;
            lblName1.Text = "Name";
            // 
            // lblSalary1
            // 
            lblSalary1.AutoSize = true;
            lblSalary1.Location = new Point(22, 91);
            lblSalary1.Name = "lblSalary1";
            lblSalary1.Size = new Size(38, 15);
            lblSalary1.TabIndex = 1;
            lblSalary1.Text = "Salary";
            // 
            // txtName1
            // 
            txtName1.Location = new Point(22, 48);
            txtName1.Name = "txtName1";
            txtName1.Size = new Size(100, 23);
            txtName1.TabIndex = 0;
            // 
            // txtSalary1
            // 
            txtSalary1.Location = new Point(22, 109);
            txtSalary1.Name = "txtSalary1";
            txtSalary1.Size = new Size(100, 23);
            txtSalary1.TabIndex = 1;
            // 
            // grpEmployee2
            // 
            grpEmployee2.Controls.Add(lblName2);
            grpEmployee2.Controls.Add(lblSalary2);
            grpEmployee2.Controls.Add(txtSalary2);
            grpEmployee2.Controls.Add(txtName2);
            grpEmployee2.Location = new Point(159, 6);
            grpEmployee2.Name = "grpEmployee2";
            grpEmployee2.Size = new Size(170, 171);
            grpEmployee2.TabIndex = 2;
            grpEmployee2.TabStop = false;
            grpEmployee2.Text = "Employee 2";
            // 
            // lblName2
            // 
            lblName2.AutoSize = true;
            lblName2.Location = new Point(20, 30);
            lblName2.Name = "lblName2";
            lblName2.Size = new Size(39, 15);
            lblName2.TabIndex = 2;
            lblName2.Text = "Name";
            // 
            // lblSalary2
            // 
            lblSalary2.AutoSize = true;
            lblSalary2.Location = new Point(20, 91);
            lblSalary2.Name = "lblSalary2";
            lblSalary2.Size = new Size(38, 15);
            lblSalary2.TabIndex = 3;
            lblSalary2.Text = "Salary";
            // 
            // txtSalary2
            // 
            txtSalary2.Location = new Point(20, 109);
            txtSalary2.Name = "txtSalary2";
            txtSalary2.Size = new Size(100, 23);
            txtSalary2.TabIndex = 1;
            // 
            // txtName2
            // 
            txtName2.Location = new Point(20, 48);
            txtName2.Name = "txtName2";
            txtName2.Size = new Size(100, 23);
            txtName2.TabIndex = 0;
            // 
            // grpEmployee3
            // 
            grpEmployee3.Controls.Add(txtSalary3);
            grpEmployee3.Controls.Add(txtName3);
            grpEmployee3.Controls.Add(lblSalary3);
            grpEmployee3.Controls.Add(lblName3);
            grpEmployee3.Location = new Point(335, 6);
            grpEmployee3.Name = "grpEmployee3";
            grpEmployee3.Size = new Size(160, 171);
            grpEmployee3.TabIndex = 3;
            grpEmployee3.TabStop = false;
            grpEmployee3.Text = "Employee 3";
            // 
            // txtSalary3
            // 
            txtSalary3.Location = new Point(22, 109);
            txtSalary3.Name = "txtSalary3";
            txtSalary3.Size = new Size(100, 23);
            txtSalary3.TabIndex = 1;
            // 
            // txtName3
            // 
            txtName3.Location = new Point(22, 48);
            txtName3.Name = "txtName3";
            txtName3.Size = new Size(100, 23);
            txtName3.TabIndex = 0;
            // 
            // lblSalary3
            // 
            lblSalary3.AutoSize = true;
            lblSalary3.Location = new Point(22, 91);
            lblSalary3.Name = "lblSalary3";
            lblSalary3.Size = new Size(38, 15);
            lblSalary3.TabIndex = 5;
            lblSalary3.Text = "Salary";
            // 
            // lblName3
            // 
            lblName3.AutoSize = true;
            lblName3.Location = new Point(22, 30);
            lblName3.Name = "lblName3";
            lblName3.Size = new Size(39, 15);
            lblName3.TabIndex = 4;
            lblName3.Text = "Name";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(22, 183);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblResults
            // 
            lblResults.Location = new Point(12, 219);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(483, 140);
            lblResults.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 368);
            Controls.Add(lblResults);
            Controls.Add(btnCalculate);
            Controls.Add(grpEmployee2);
            Controls.Add(grpEmployee3);
            Controls.Add(grpEmployee1);
            Name = "Form1";
            Text = "Form1";
            grpEmployee1.ResumeLayout(false);
            grpEmployee1.PerformLayout();
            grpEmployee2.ResumeLayout(false);
            grpEmployee2.PerformLayout();
            grpEmployee3.ResumeLayout(false);
            grpEmployee3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpEmployee1;
        private Label lblName1;
        private Label lblSalary1;
        private GroupBox grpEmployee2;
        private GroupBox grpEmployee3;
        private Label lblSalary3;
        private Label lblName3;
        private Label lblSalary2;
        private Label lblName2;
        private TextBox txtName1;
        private TextBox txtSalary1;
        private TextBox txtSalary2;
        private TextBox txtName2;
        private TextBox txtSalary3;
        private TextBox txtName3;
        private Button btnCalculate;
        private Label lblResults;
    }
}
