using System.Xml.Serialization;

namespace HW04_02
{
    public partial class frmResortStay : Form
    {
        private int[] nightRanges = { 1, 3, 5, 8 };
        private decimal[] nightlyRates = {200, 180, 160, 145};

        public frmResortStay()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNights.Text, out int nightsStayed) && nightsStayed != 0)
            {
                decimal nightlyRate = 0;
                for (int i = nightRanges.Length - 1; i >= 0; i--)
                {
                    if (nightsStayed >= nightRanges[i])
                    {
                        nightlyRate = nightlyRates[i];
                        break;
                    }
                }

                decimal nightlyCost = nightsStayed * nightlyRate;
                decimal totalCost = nightlyCost;

                if (nightsStayed == 1 || nightsStayed == 2)
                {
                    txtRate.Text = "One or Two";
                }
                else if (nightsStayed == 3 || nightsStayed == 4)
                {
                    txtRate.Text = "Three or Four";
                }
                else if (nightsStayed >= 5 && nightsStayed < 8)
                {
                    txtRate.Text = "Five to Seven";
                }
                else if (nightsStayed >= 8)
                {
                    txtRate.Text = "Eight or more";
                }

                lblNightlyCost.Text = $"Nightly Cost\n${nightlyCost:F2}";
                lblTotalCost.Text   = $"Total Cost\n${totalCost:F2}";
            }
            else
            {
                MessageBox.Show("Please enter a valid number of nights.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNights.Text = string.Empty;
            txtRate.Text = string.Empty;
            lblNightlyCost.Text = "Nightly Cost";
            lblTotalCost.Text = "Total cost of stay";
            txtNights.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
