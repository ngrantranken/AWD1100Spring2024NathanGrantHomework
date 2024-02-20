namespace HW04_06
{
    public partial class frmSortedPhrase : Form
    {
        public frmSortedPhrase()
        {
            InitializeComponent();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            SortWords();
        }

        private void SortWords()
        {
            string input = txtPhrase.Text.Trim();

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Please enter a phrase in the textbox.", "Empty Text Box");
                return;
            }

            string[] words = input.Split(new char[] { ' ' });
            Array.Sort(words);
            lblResults.Text = string.Join(" ", words);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPhrase.Text = string.Empty;
            lblResults.Text = string.Empty;
            txtPhrase.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
