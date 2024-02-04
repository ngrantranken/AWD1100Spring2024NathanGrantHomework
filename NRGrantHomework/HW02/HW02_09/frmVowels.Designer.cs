namespace HW02_09
{
    partial class frmVowels
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
            lblPhrase = new Label();
            lblVowels = new Label();
            txtPhrase = new TextBox();
            btnEnter = new Button();
            SuspendLayout();
            // 
            // lblPhrase
            // 
            lblPhrase.AutoSize = true;
            lblPhrase.Location = new Point(12, 9);
            lblPhrase.Name = "lblPhrase";
            lblPhrase.Size = new Size(120, 15);
            lblPhrase.TabIndex = 0;
            lblPhrase.Text = "Please enter a phrase:";
            // 
            // lblVowels
            // 
            lblVowels.AutoSize = true;
            lblVowels.Location = new Point(12, 53);
            lblVowels.Name = "lblVowels";
            lblVowels.Size = new Size(183, 15);
            lblVowels.TabIndex = 1;
            lblVowels.Text = "There are _ vowels in your phrase.";
            // 
            // txtPhrase
            // 
            txtPhrase.Location = new Point(12, 27);
            txtPhrase.Name = "txtPhrase";
            txtPhrase.Size = new Size(120, 23);
            txtPhrase.TabIndex = 2;
            // 
            // btnEnter
            // 
            btnEnter.Location = new Point(138, 27);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(75, 23);
            btnEnter.TabIndex = 3;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += this.btnEnter_Click;
            // 
            // frmVowels
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(229, 81);
            Controls.Add(btnEnter);
            Controls.Add(txtPhrase);
            Controls.Add(lblVowels);
            Controls.Add(lblPhrase);
            Name = "frmVowels";
            Text = "Vowels";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPhrase;
        private Label lblVowels;
        private TextBox txtPhrase;
        private Button btnEnter;
    }
}
