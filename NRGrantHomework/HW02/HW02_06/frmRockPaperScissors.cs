using System.Xml.Serialization;

namespace HW02_06
{
    public partial class frmRockPaperScissors : Form
    {
        public frmRockPaperScissors()
        {
            InitializeComponent();
        }

        string playerChoice;
        string compChoice;
        int playerScore;
        int compScore;
        int roundCounter;

        private void btnRock_Click(object sender, EventArgs e)
        {
            playerChoice = "Rock";
            GenerateCompChoice();
            ResolveRound();
            ThreeRoundReset();
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            playerChoice = "Paper";
            GenerateCompChoice();
            ResolveRound();
            ThreeRoundReset();
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            playerChoice = "Scissors";
            GenerateCompChoice();
            ResolveRound();
            ThreeRoundReset();
        }

        private void GenerateCompChoice()
        {
            Random rand = new Random();
            int randChoice = rand.Next(1, 4);
            if (randChoice == 1)
            {
                compChoice = "Rock";
            }
            else if (randChoice == 2)
            {
                compChoice = "Paper";
            }
            else if (randChoice == 3)
            {
                compChoice = "Scissors";
            }

            lblComputerPick.Text = $"Computer picked {compChoice}";
        }

        private void ResolveRound()
        {
            if (playerChoice == "Rock" && compChoice == "Scissors")
            {
                playerScore++;
                roundCounter++;
            }
            else if (playerChoice == "Scissors" && compChoice == "Rock")
            {
                compScore++;
                roundCounter++;
            }
            else if (playerChoice == "Paper" && compChoice == "Rock")
            {
                playerScore++;
                roundCounter++;
            }
            else if (playerChoice == "Rock" && compChoice == "Paper")
            {
                compScore++;
                roundCounter++;
            }
            else if (playerChoice == "Scissors" && compChoice == "Paper")
            {
                playerScore++;
                roundCounter++;
            }
            else if (playerChoice == "Paper" && compChoice == "Scissors")
            {
                compScore++;
                roundCounter++;
            }
            else
            {
                roundCounter++;
            }

            lblScores.Text = $"Player Score: {playerScore}      Computer Score: {compScore}";
        }

        private void ThreeRoundReset()
        {
            lblWinner.Text = string.Empty;
            if (roundCounter == 3)
            {
                if (playerScore > compScore)
                {
                    lblWinner.Text = "Player Wins";
                }
                else if (playerScore < compScore)
                {
                    lblWinner.Text = "Computer Wins";
                }
                else
                {
                    lblWinner.Text = "Tie";
                }

                roundCounter = 0;
                playerScore = 0;
                compScore = 0;
            }
        }
    }
}
