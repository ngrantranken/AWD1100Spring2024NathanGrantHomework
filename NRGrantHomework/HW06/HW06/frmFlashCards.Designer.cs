namespace HW06
{
    partial class frmFlashCards
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
            lblTerm = new Label();
            txtTerm = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            txtDefinition = new Label();
            textBox1 = new TextBox();
            button4 = new Button();
            SuspendLayout();
            // 
            // lblTerm
            // 
            lblTerm.AutoSize = true;
            lblTerm.Location = new Point(12, 9);
            lblTerm.Name = "lblTerm";
            lblTerm.Size = new Size(207, 15);
            lblTerm.TabIndex = 0;
            lblTerm.Text = "What term do you want me to define?";
            // 
            // txtTerm
            // 
            txtTerm.Location = new Point(12, 27);
            txtTerm.Name = "txtTerm";
            txtTerm.Size = new Size(207, 23);
            txtTerm.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(225, 27);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(225, 109);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(225, 138);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 4;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // txtDefinition
            // 
            txtDefinition.AutoSize = true;
            txtDefinition.Location = new Point(12, 53);
            txtDefinition.Name = "txtDefinition";
            txtDefinition.Size = new Size(144, 15);
            txtDefinition.TabIndex = 5;
            txtDefinition.Text = "I don't know that term yet";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 81);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(207, 23);
            textBox1.TabIndex = 6;
            // 
            // button4
            // 
            button4.Location = new Point(225, 80);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 7;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // frmFlashCards
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(textBox1);
            Controls.Add(txtDefinition);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtTerm);
            Controls.Add(lblTerm);
            Name = "frmFlashCards";
            Text = "Flash Cards";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTerm;
        private TextBox txtTerm;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label txtDefinition;
        private TextBox textBox1;
        private Button button4;
    }
}
