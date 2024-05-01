using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore
{
    public partial class frmDetails : Form
    {
        private string receivedIsbn;

        public frmDetails(string data)
        {
            InitializeComponent();
            receivedIsbn = data;
            FillInTheFields();
        }

        private void FillInTheFields()
        {
            var bookContext = new BookContext();

            var book = bookContext.Books.Where(b1 => b1.Isbn.ToString() == receivedIsbn).Select(b2 => new { b2.Img, b2.Isbn, b2.BookName, b2.AuthorName, b2.PublishYear }).FirstOrDefault();

            if (book != null)
            {
                picBookCover.Image = Image.FromFile(book.Img);
                lblIsbn.Text = book.Isbn;
                lblBookName.Text = book.BookName;
                lblAuthorName.Text = book.AuthorName;
                lblPublishYear.Text = $"({book.PublishYear})";
            }
            else
            {
                MessageBox.Show("Ooopsie", "BAD QUERY");
            }

        }

        private PictureBox picBookCover;
        private Label lblIsbn;
        private Label lblBookName;
        private Label lblAuthorName;
        private Label lblISBNLabel;
        private Label lblBookBy;
        private Button btnClose;
        private Label lblPublishYear;

        private void InitializeComponent()
        {
            picBookCover = new PictureBox();
            lblIsbn = new Label();
            lblBookName = new Label();
            lblAuthorName = new Label();
            lblPublishYear = new Label();
            lblISBNLabel = new Label();
            lblBookBy = new Label();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)picBookCover).BeginInit();
            SuspendLayout();
            // 
            // picBookCover
            // 
            picBookCover.Location = new Point(12, 12);
            picBookCover.Name = "picBookCover";
            picBookCover.Size = new Size(305, 500);
            picBookCover.TabIndex = 0;
            picBookCover.TabStop = false;
            // 
            // lblIsbn
            // 
            lblIsbn.AutoSize = true;
            lblIsbn.Font = new Font("Segoe UI", 12F);
            lblIsbn.Location = new Point(65, 515);
            lblIsbn.Name = "lblIsbn";
            lblIsbn.Size = new Size(52, 21);
            lblIsbn.TabIndex = 1;
            lblIsbn.Text = "label1";
            // 
            // lblBookName
            // 
            lblBookName.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblBookName.Location = new Point(12, 536);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(305, 82);
            lblBookName.TabIndex = 2;
            lblBookName.Text = "label2";
            // 
            // lblAuthorName
            // 
            lblAuthorName.AutoSize = true;
            lblAuthorName.Font = new Font("Segoe UI", 14F);
            lblAuthorName.Location = new Point(45, 648);
            lblAuthorName.Name = "lblAuthorName";
            lblAuthorName.Size = new Size(63, 25);
            lblAuthorName.TabIndex = 3;
            lblAuthorName.Text = "label3";
            // 
            // lblPublishYear
            // 
            lblPublishYear.AutoSize = true;
            lblPublishYear.Font = new Font("Segoe UI", 16F);
            lblPublishYear.Location = new Point(12, 618);
            lblPublishYear.Name = "lblPublishYear";
            lblPublishYear.Size = new Size(71, 30);
            lblPublishYear.TabIndex = 4;
            lblPublishYear.Text = "label4";
            // 
            // lblISBNLabel
            // 
            lblISBNLabel.AutoSize = true;
            lblISBNLabel.Font = new Font("Segoe UI", 12F);
            lblISBNLabel.Location = new Point(12, 515);
            lblISBNLabel.Name = "lblISBNLabel";
            lblISBNLabel.Size = new Size(47, 21);
            lblISBNLabel.TabIndex = 5;
            lblISBNLabel.Text = "ISBN:";
            // 
            // lblBookBy
            // 
            lblBookBy.AutoSize = true;
            lblBookBy.Font = new Font("Segoe UI", 14F);
            lblBookBy.Location = new Point(12, 648);
            lblBookBy.Name = "lblBookBy";
            lblBookBy.Size = new Size(36, 25);
            lblBookBy.TabIndex = 6;
            lblBookBy.Text = "By:";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(242, 652);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 0;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmDetails
            // 
            AcceptButton = btnClose;
            CancelButton = btnClose;
            ClientSize = new Size(333, 686);
            Controls.Add(btnClose);
            Controls.Add(lblBookBy);
            Controls.Add(lblISBNLabel);
            Controls.Add(lblPublishYear);
            Controls.Add(lblAuthorName);
            Controls.Add(lblBookName);
            Controls.Add(lblIsbn);
            Controls.Add(picBookCover);
            Name = "frmDetails";
            Text = "Book Details";
            ((System.ComponentModel.ISupportInitialize)picBookCover).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
