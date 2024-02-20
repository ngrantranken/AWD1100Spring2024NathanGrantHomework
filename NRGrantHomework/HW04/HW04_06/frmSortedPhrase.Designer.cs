namespace HW04_06
{
    partial class frmSortedPhrase
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
            txtPhrase = new TextBox();
            btnSort = new Button();
            btnClear = new Button();
            btnExit = new Button();
            lblResults = new Label();
            SuspendLayout();
            // 
            // txtPhrase
            // 
            txtPhrase.Location = new Point(12, 12);
            txtPhrase.Name = "txtPhrase";
            txtPhrase.Size = new Size(237, 23);
            txtPhrase.TabIndex = 0;
            // 
            // btnSort
            // 
            btnSort.Location = new Point(12, 41);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(75, 23);
            btnSort.TabIndex = 1;
            btnSort.Text = "Sort";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(93, 41);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(174, 41);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblResults
            // 
            lblResults.Location = new Point(12, 67);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(237, 66);
            lblResults.TabIndex = 4;
            // 
            // frmSortedPhrase
            // 
            AcceptButton = btnSort;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(262, 142);
            Controls.Add(lblResults);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnSort);
            Controls.Add(txtPhrase);
            Name = "frmSortedPhrase";
            Text = "Sorted Phrase";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPhrase;
        private Button btnSort;
        private Button btnClear;
        private Button btnExit;
        private Label lblResults;
    }
}
