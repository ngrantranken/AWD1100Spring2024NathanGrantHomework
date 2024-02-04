namespace HW02_01
{
    public partial class frmDistanceConverter : Form
    {
        public frmDistanceConverter()
        {
            InitializeComponent();
        }

        const double KM_PER_MILE = 1.6;
        double miles;
        double kilometers;

        private void btnConvertToKm_Click(object sender, EventArgs e)
        {
            ConvertToKm();
            UpdateResults();
        }

        private void ConvertToKm()
        {
            miles = Double.Parse(txtMiles.Text);
            kilometers = miles * KM_PER_MILE;
            txtKilometers.Text = kilometers.ToString();
        }

        private void btnConvertToMi_Click(object sender, EventArgs e)
        {
            ConvertToMi();
            UpdateResults();
        }

        private void ConvertToMi()
        {
            kilometers = Double.Parse(txtKilometers.Text);
            miles = kilometers / KM_PER_MILE;
            txtMiles.Text = miles.ToString();
        }

        private void UpdateResults()
        {
            lblResult.Text = $"{miles:0.00} miles is {kilometers:0.00} kilometers";
        }
    }
}
