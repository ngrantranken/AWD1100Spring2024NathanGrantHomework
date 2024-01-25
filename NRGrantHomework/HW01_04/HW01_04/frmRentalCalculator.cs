namespace HW01_04
{
    public partial class frmRentalCalculator : Form
    {
        public frmRentalCalculator()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double dayCost = 100.00;
            double milesCost = 0.50;
            int days = Convert.ToInt32(txtDays.Text);
            int miles = Convert.ToInt32(txtMiles.Text);
            double fees = (dayCost * days) + (milesCost * miles);

            txtFees.Text = fees.ToString();
            txtDays.Focus();
        }
    }
}
