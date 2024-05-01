namespace Bookstore
{
    partial class frmBookStore
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
            lblSearch = new Label();
            txtSearch = new TextBox();
            cboAuthor = new ComboBox();
            lblAuthor = new Label();
            btnSearch = new Button();
            dgvBookshelf = new DataGridView();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBookshelf).BeginInit();
            SuspendLayout();
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(12, 9);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(155, 15);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search by Book Title or ISBN";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 27);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(215, 23);
            txtSearch.TabIndex = 0;
            // 
            // cboAuthor
            // 
            cboAuthor.FormattingEnabled = true;
            cboAuthor.Location = new Point(233, 27);
            cboAuthor.Name = "cboAuthor";
            cboAuthor.Size = new Size(121, 23);
            cboAuthor.TabIndex = 1;
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(233, 9);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(44, 15);
            lblAuthor.TabIndex = 3;
            lblAuthor.Text = "Author";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(360, 27);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(95, 23);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvBookshelf
            // 
            dgvBookshelf.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookshelf.Location = new Point(12, 56);
            dgvBookshelf.Name = "dgvBookshelf";
            dgvBookshelf.Size = new Size(543, 354);
            dgvBookshelf.TabIndex = 9;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(461, 27);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 23);
            btnExit.TabIndex = 10;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click_1;
            // 
            // frmBookStore
            // 
            AcceptButton = btnSearch;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(568, 424);
            Controls.Add(btnExit);
            Controls.Add(dgvBookshelf);
            Controls.Add(btnSearch);
            Controls.Add(lblAuthor);
            Controls.Add(cboAuthor);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Name = "frmBookStore";
            Text = "3 Authors Bookstore";
            Load += frmBookstore_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBookshelf).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSearch;
        private TextBox txtSearch;
        private ComboBox cboAuthor;
        private Label lblAuthor;
        private Button btnSearch;
        private Button btnPreviousPage;
        private Button btnNextPage;
        private Label lblPageInfo;
        private DataGridView dgvBookshelf;
        private Button btnExit;
    }
}
