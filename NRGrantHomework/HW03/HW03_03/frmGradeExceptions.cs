namespace HW03_03
{
    public partial class frmGradeExceptions : Form
    {
        private const int MinGrade = 0;
        private const int MaxGrade = 100;

        public frmGradeExceptions()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                int test1 = Convert.ToInt32(txtTest1.Text);
                int test2 = Convert.ToInt32(txtTest2.Text);
                int test3 = Convert.ToInt32(txtTest3.Text);

                if (test1 < MinGrade || test1 > MaxGrade || test2 < MinGrade || test2 > MaxGrade || test3 < MinGrade || test3 > MaxGrade)
                {
                    throw new ArgumentException($"Grades must be between {MinGrade} and {MaxGrade}.");
                }

                int gradeAverage = CalculateGradeAverage(test1, test2, test3);
                string gradeLetter = CalculateGradeLetter(gradeAverage);

                txtAverage.Text = $"{gradeAverage} = {gradeLetter}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values.", "INPUT ERROR");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "INPUT ERROR");
            }
        }

        private int CalculateGradeAverage(int test1, int test2, int test3)
        {
            return (test1 + test2 + test3) / 3;
        }

        private string CalculateGradeLetter(int gradeAverage)
        {
            if (gradeAverage >= 90)
            {
                return "A";
            }
            else if (gradeAverage >= 80)
            {
                return "B";
            }
            else if (gradeAverage >= 70)
            {
                return "C";
            }
            else if (gradeAverage >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTest1.Text   = string.Empty;
            txtTest2.Text   = string.Empty;
            txtTest3.Text   = string.Empty;  
            txtAverage.Text = string.Empty;
            txtTest1.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
