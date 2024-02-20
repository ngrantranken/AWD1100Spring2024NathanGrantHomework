namespace HW04_03
{
    partial class frmGameDatabase
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
            txtSearchTerm = new TextBox();
            lblResults = new Label();
            btnSearch = new Button();
            btnClear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // txtSearchTerm
            // 
            txtSearchTerm.Location = new Point(12, 12);
            txtSearchTerm.Name = "txtSearchTerm";
            txtSearchTerm.Size = new Size(201, 23);
            txtSearchTerm.TabIndex = 0;
            // 
            // lblResults
            // 
            lblResults.Location = new Point(12, 49);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(191, 97);
            lblResults.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(219, 12);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(219, 41);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(219, 70);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmGameDatabase
            // 
            AcceptButton = btnSearch;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(323, 155);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnSearch);
            Controls.Add(lblResults);
            Controls.Add(txtSearchTerm);
            Name = "frmGameDatabase";
            Text = "GameBreak";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearchTerm;
        private Label lblResults;
        private Button btnSearch;
        private Button btnClear;
        private Button btnExit;
    }
}
