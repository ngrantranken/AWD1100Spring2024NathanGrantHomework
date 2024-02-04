namespace HOT2_1
{
    partial class frmDistanceConverter
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
            lblInches = new Label();
            btnConvert = new Button();
            btnClear = new Button();
            btnExit = new Button();
            txtInches = new TextBox();
            lblYards = new Label();
            SuspendLayout();
            // 
            // lblInches
            // 
            lblInches.AutoSize = true;
            lblInches.Location = new Point(134, 84);
            lblInches.Name = "lblInches";
            lblInches.Size = new Size(44, 15);
            lblInches.TabIndex = 0;
            lblInches.Text = "Inches:";
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(52, 177);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(105, 32);
            btnConvert.TabIndex = 1;
            btnConvert.Text = "Convert to Yards";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(163, 177);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(105, 32);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(274, 177);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(105, 32);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtInches
            // 
            txtInches.Location = new Point(184, 81);
            txtInches.Name = "txtInches";
            txtInches.Size = new Size(100, 23);
            txtInches.TabIndex = 4;
            // 
            // lblYards
            // 
            lblYards.Location = new Point(113, 130);
            lblYards.Name = "lblYards";
            lblYards.Size = new Size(224, 23);
            lblYards.TabIndex = 5;
            lblYards.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmDistanceConverter
            // 
            AcceptButton = btnConvert;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(430, 221);
            Controls.Add(lblYards);
            Controls.Add(txtInches);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnConvert);
            Controls.Add(lblInches);
            Name = "frmDistanceConverter";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Distance Converter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInches;
        private Button btnConvert;
        private Button btnClear;
        private Button btnExit;
        private TextBox txtInches;
        private Label lblYards;
    }
}
