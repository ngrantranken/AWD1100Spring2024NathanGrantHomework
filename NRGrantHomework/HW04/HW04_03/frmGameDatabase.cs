namespace HW04_03
{
    public partial class frmGameDatabase : Form
    {
        const string GNF = "Game Not Found";
        const string N = "Name:";
        const string PUB = "Publisher:";
        const string PR = "Price:";

        private string[] gameNames = { "Player Unknown's Battlegrounds (PUBG)", "League of Legends", "Call of Duty: Black Ops II", "Battlefield 4", "Super Mario Odyssey" };
        private string[] publishers = { "Bluehole", "Riot Games", "Activision", "Electronic Arts (EA)", "Nintendo" };
        private decimal[] prices = { 35m, 0m, 60m, 20m, 60m };

        public frmGameDatabase()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool keepGoing = CheckForNoInput();
            if (keepGoing)
            {
                PerformTheSearch();
            }
        }

        private bool CheckForNoInput()
        {
            bool retVal = true;
            string term = txtSearchTerm.Text.Trim();

            if (term == "")
            {
                MessageBox.Show("You must enter a search term", "Search Term Empty");
                retVal = false;
            }

            return retVal;
        }

        private void PerformTheSearch()
        {
            string term = txtSearchTerm.Text.Trim();
            bool isFound = false;
            int indexNumber = -1;
            string outputStr = "";

            for (int lcv = 0; lcv < gameNames.Length; lcv++)
            {
                if (gameNames[lcv].ToLower().Contains(term.ToLower()) || publishers[lcv].ToLower().Contains(term.ToLower()))
                {
                    isFound = true;
                    indexNumber = lcv;
                    break;
                }
            }

            if (isFound)
            {
                outputStr += ($"\t{N} {gameNames[indexNumber]}\r\n");
                outputStr += ($"\t{PUB} {publishers[indexNumber]}\r\n");
                outputStr += ($"\t{PR} ${prices[indexNumber]:F2}\r\n");
            }
            else
            {
                outputStr += ($"\t{N} {GNF}\r\n");
                outputStr += ($"\t{PUB} {GNF}\r\n");
                outputStr += ($"\t{PR} {GNF}\r\n");
            }

            lblResults.Text = outputStr;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearchTerm.Text = string.Empty;
            lblResults.Text = string.Empty;
            txtSearchTerm.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
