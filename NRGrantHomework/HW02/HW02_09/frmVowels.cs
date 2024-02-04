namespace HW02_09
{
    public partial class frmVowels : Form
    {
        public frmVowels()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string phrase = txtPhrase.Text;
            int vowelCount = CountVowels(phrase);
            lblVowels.Text = $"There are {vowelCount} vowels in your phrase.";
        }

        private int CountVowels(string phrase)
        {
            int count = 0;
            foreach (char c in phrase)
            {
                switch (char.ToLower(c))
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        count++;
                        break;
                }
            }
            return count;
        }
    }
}
