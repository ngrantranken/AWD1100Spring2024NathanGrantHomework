namespace HW02_04
{
    partial class frmCollegeAdmission
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
            lblGPA = new Label();
            lblTestScore = new Label();
            lblResults = new Label();
            txtGPA = new TextBox();
            txtTestScore = new TextBox();
            btnAdmit = new Button();
            SuspendLayout();
            // 
            // lblGPA
            // 
            lblGPA.AutoSize = true;
            lblGPA.Location = new Point(12, 36);
            lblGPA.Name = "lblGPA";
            lblGPA.Size = new Size(32, 15);
            lblGPA.TabIndex = 0;
            lblGPA.Text = "GPA:";
            // 
            // lblTestScore
            // 
            lblTestScore.AutoSize = true;
            lblTestScore.Location = new Point(139, 36);
            lblTestScore.Name = "lblTestScore";
            lblTestScore.Size = new Size(121, 15);
            lblTestScore.TabIndex = 1;
            lblTestScore.Text = "Admission Test Score:";
            // 
            // lblResults
            // 
            lblResults.AutoSize = true;
            lblResults.Location = new Point(95, 87);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(0, 15);
            lblResults.TabIndex = 2;
            // 
            // txtGPA
            // 
            txtGPA.Location = new Point(12, 54);
            txtGPA.Name = "txtGPA";
            txtGPA.Size = new Size(121, 23);
            txtGPA.TabIndex = 3;
            // 
            // txtTestScore
            // 
            txtTestScore.Location = new Point(139, 54);
            txtTestScore.Name = "txtTestScore";
            txtTestScore.Size = new Size(121, 23);
            txtTestScore.TabIndex = 4;
            // 
            // btnAdmit
            // 
            btnAdmit.Location = new Point(12, 83);
            btnAdmit.Name = "btnAdmit";
            btnAdmit.Size = new Size(75, 23);
            btnAdmit.TabIndex = 5;
            btnAdmit.Text = "Admit";
            btnAdmit.UseVisualStyleBackColor = true;
            btnAdmit.Click += btnAdmit_Click;
            // 
            // frmCollegeAdmission
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(279, 121);
            Controls.Add(btnAdmit);
            Controls.Add(txtTestScore);
            Controls.Add(txtGPA);
            Controls.Add(lblResults);
            Controls.Add(lblTestScore);
            Controls.Add(lblGPA);
            Name = "frmCollegeAdmission";
            Text = "College Admission";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGPA;
        private Label lblTestScore;
        private Label lblResults;
        private TextBox txtGPA;
        private TextBox txtTestScore;
        private Button btnAdmit;
    }
}
