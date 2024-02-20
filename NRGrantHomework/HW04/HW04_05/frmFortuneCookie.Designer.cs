namespace HW04_05
{
    partial class frmFortuneCookie
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
            btnOpen = new Button();
            btnClear = new Button();
            btnExit = new Button();
            lblFortune = new Label();
            SuspendLayout();
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(12, 12);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(75, 23);
            btnOpen.TabIndex = 0;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(93, 12);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 1;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(174, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblFortune
            // 
            lblFortune.Location = new Point(12, 38);
            lblFortune.Name = "lblFortune";
            lblFortune.Size = new Size(369, 73);
            lblFortune.TabIndex = 3;
            // 
            // frmFortuneCookie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 138);
            Controls.Add(lblFortune);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnOpen);
            Name = "frmFortuneCookie";
            Text = "Fortune Cookie";
            ResumeLayout(false);
        }

        #endregion

        private Button btnOpen;
        private Button btnClear;
        private Button btnExit;
        private Label lblFortune;
    }
}
