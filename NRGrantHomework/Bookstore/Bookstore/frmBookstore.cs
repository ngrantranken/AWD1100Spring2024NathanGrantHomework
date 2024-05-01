using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Linq;
using System.Windows.Forms;
using static System.Reflection.Metadata.BlobBuilder;

namespace Bookstore
{
    public partial class frmBookStore : Form
    {
        string theIsbn = "";
        int j = 0;
        public frmBookStore()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ShowSearchResults();
        }

        private void ShowSearchResults()
        {
            var bookContext = new BookContext();

            if (txtSearch.Text.Trim() == "" && cboAuthor.SelectedIndex == -1)
            {
                MessageBox.Show("No Search Term Entered", "EMPTY SEARCH TERM");
                return;
            }

            var books = (from b in bookContext.Books where b.AuthorName.ToString() == cboAuthor.SelectedItem.ToString() select b).ToList();


            // causes search to prioritize search inputs over author inputs.
            if (txtSearch.Text != "")
            {
                books = (from b in bookContext.Books where b.BookName.ToString() == txtSearch.Text select b).ToList();
                
                // checks if user input contains 978 to determine if ISBN is inputted
                if (txtSearch.Text.Contains("978"))
                {
                    books = (from b in bookContext.Books where b.Isbn.ToString() == txtSearch.Text select b).ToList();
                }
            }

            if (books.Count == 0)
            {
                MessageBox.Show("I'm sorry, that book appears to be unavailable.", "BOOK UNAVAILABLE");
                txtSearch.Text = "";
                txtSearch.Focus();
                return;
            }


            var books2 = from b in bookContext.Books select b.Isbn;

            dgvBookshelf.DataSource = books;


            // keeps these events from happening only on the first search
            while (j == 0)
            {
                dgvBookshelf.CellClick += dgvBookshelf_CellContentClick;
                this.dgvBookshelf.Columns[0].Name = "BookId";
                this.dgvBookshelf.Columns[1].Name = "Isbn";
                this.dgvBookshelf.Columns[5].Name = "Img";
                HideColumns();
                AddDetailsButtons();
                j = 1;
                break;
            }
        }

        private void HideColumns()
        {
            this.dgvBookshelf.Columns["BookId"].Visible = false;
            this.dgvBookshelf.Columns["Img"].Visible = false;
        }

        private void AddDetailsButtons()
        {
            DataGridViewButtonColumn btnDetails = new DataGridViewButtonColumn();
            {
                btnDetails.Name = "button";
                btnDetails.HeaderText = "Details";
                btnDetails.Text = "Details";
                btnDetails.UseColumnTextForButtonValue = true;
                this.dgvBookshelf.Columns.Add(btnDetails);
            }
        }

        private void frmBookstore_Load(object sender, EventArgs e)
        {
            this.dgvBookshelf.Rows.Clear();

            var bookContext = new BookContext();
            var authors = (from b in bookContext.Books select b.AuthorName).Distinct();

            foreach (string author in authors) 
            { 
                cboAuthor.Items.Add(author);
            }
            cboAuthor.Text = "Frank Herbert";
        }

        private void dgvBookshelf_CellContentClick(object? sender, DataGridViewCellEventArgs e) 
        {
            if (e.ColumnIndex == dgvBookshelf.Columns["button"].Index)
            {
                var rowIndex = dgvBookshelf.CurrentCellAddress.Y;
                theIsbn = dgvBookshelf.Rows[rowIndex].Cells["Isbn"].Value.ToString();
                frmDetails search = new frmDetails(theIsbn);
                search.Show();
            }
            return;
        }

        private void btnExit_Click_1(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
