namespace HW04_05
{
    public partial class frmFortuneCookie : Form
    {
        private string[] fortunes = { "Birthdays are like friends. The more you have the better",
                                      "Your smile is a treasure to all who know you.",
                                      "You never hesitate to tackle the most difficult problems.",
                                      "The most obvious solution is not always the best.",
                                      "If you want the rainbow, you will have to tolerate the rain.",
                                      "The early bird gets the worm, but the second mouse gets the cheese.",
                                      "From listening comes wisdom and from speaking repentance.",
                                      "A smile is your personal welcome mat.",
                                      "Courage is not the absence of fear; it is the conquest of it.",
                                      "A ship in harbor is safe, but that's not why ships are built.",
                                      "The wise man is the one that makes you think that he is dumb.",
                                      "One that would have the fruit must climb the tree."};

        public frmFortuneCookie()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            GenerateFortune();
        }

        private void GenerateFortune()
        {
            Random random = new Random();
            int index1 = random.Next(0, fortunes.Length);
            int index2;

            do
            {
                index2 = random.Next(0, fortunes.Length);
            }
            while (index2 == index1);

            lblFortune.Text = $"{fortunes[index1]}\n{fortunes[index2]}";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblFortune.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
