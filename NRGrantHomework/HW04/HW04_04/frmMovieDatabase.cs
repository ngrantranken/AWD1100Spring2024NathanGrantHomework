namespace HW04_04
{
    public partial class frmMovieDatabase : Form
    {
        const string MNF = "Movie Not Found";
        const string T = "Title:";
        const string DIR = "Director:";
        const string DES = "Description:";

        private string[] movieTitles = { "The Shawshank Redemption", "The Godfather", "The Dark Knight", "The Godfather Part II", "12 Angry Men", "Schindler's List", "The Lord of the Rings: The Return of the King", "Pulp Fiction", "The Lord of the Rings: The Fellowship of the Ring", "The Good, the Bad, and the Ugly" };
        private string[] directors = { "Frank Darabont", "Francis Ford Coppola", "Christopher Nolan", "Francis Ford Coppola", "Sidney Lumet", "Steven Spielberg", "Peter Jackson", "Quentin Tarantino", "Peter Jackson", "Sergio Leone" };
        private string[] descriptions = { "Over the course of several years, two convicts form a friendship, seeking consolation and, eventually, redemption through basic compassion.", 
                                          "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.",
                                          "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.",
                                          "The early life and career of Vito Corleone in 1920s New York City is portrayed, while his son, Michael, expands and tightens his grip on the family crime syndicate.",
                                          "The jury in a New York City murder trial is frustrated by a single member whose skeptical caution forces them to more carefully consider the evidence before jumping to a hasty verdict.",
                                          "In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis.",
                                          "Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring.",
                                          "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.",
                                          "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron.",
                                          "A bounty hunting scam joins two men in an uneasy alliance against a third in a race to find a fortune in gold buried in a remote cemetery."};

        public frmMovieDatabase()
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

            for (int lcv = 0; lcv < movieTitles.Length; lcv++)
            {
                if (movieTitles[lcv].ToLower().Contains(term.ToLower()) || directors[lcv].ToLower().Contains(term.ToLower()))
                {
                    isFound = true;
                    indexNumber = lcv;
                    break;
                }
            }

            if (isFound)
            {
                outputStr += ($"\t{T} {movieTitles[indexNumber]}\r\n");
                outputStr += ($"\t{DIR} {directors[indexNumber]}\r\n");
                outputStr += ($"\t{DES} {descriptions[indexNumber]:F2}\r\n");
            }
            else
            {
                outputStr += ($"\t{T} {MNF}\r\n");
                outputStr += ($"\t{DIR} {MNF}\r\n");
                outputStr += ($"\t{DES} {MNF}\r\n");
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
