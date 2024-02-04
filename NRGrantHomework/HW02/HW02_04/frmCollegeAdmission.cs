namespace HW02_04
{
    public partial class frmCollegeAdmission : Form
    {
        public frmCollegeAdmission()
        {
            InitializeComponent();
        }

        private void btnAdmit_Click(object sender, EventArgs e)
        {
            double GPA = Double.Parse(txtGPA.Text.Trim());
            int testScore = Int32.Parse(txtTestScore.Text.Trim());

            if (GPA >= 3.0 && testScore >= 60)
            {
                lblResults.Text = "Accept";
            }
            else if (GPA < 3.0 && testScore >= 80)
            {
                lblResults.Text = "Accept";
            }
            else
            {
                lblResults.Text = "Reject";
            }
        }
    }
}
