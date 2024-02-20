namespace HW04_04
{
    partial class frmMovieDatabase
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
            btnExit = new Button();
            btnClear = new Button();
            btnSearch = new Button();
            lblResults = new Label();
            txtSearchTerm = new TextBox();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Location = new Point(381, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 11;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(300, 12);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(219, 12);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblResults
            // 
            lblResults.Location = new Point(12, 49);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(444, 97);
            lblResults.TabIndex = 8;
            // 
            // txtSearchTerm
            // 
            txtSearchTerm.Location = new Point(12, 12);
            txtSearchTerm.Name = "txtSearchTerm";
            txtSearchTerm.Size = new Size(201, 23);
            txtSearchTerm.TabIndex = 7;
            // 
            // frmMovieDatabase
            // 
            AcceptButton = btnSearch;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(526, 171);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnSearch);
            Controls.Add(lblResults);
            Controls.Add(txtSearchTerm);
            Name = "frmMovieDatabase";
            Text = "MovieDatabase";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private Button btnClear;
        private Button btnSearch;
        private Label lblResults;
        private TextBox txtSearchTerm;
    }
}
