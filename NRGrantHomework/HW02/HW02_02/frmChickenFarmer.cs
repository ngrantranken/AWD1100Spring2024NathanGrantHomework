namespace HW02_02
{
    public partial class frmChickenFarmer : Form
    {
        public frmChickenFarmer()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int alphaEggs = Int32.Parse(txtAlpha.Text);
            int bravoEggs = Int32.Parse(txtBravo.Text);
            int charlieEggs = Int32.Parse(txtCharlie.Text);
            int deltaEggs = Int32.Parse(txtDelta.Text);

            int sum = alphaEggs + bravoEggs + charlieEggs + deltaEggs;
            int dozens = sum / 12;
            int dozensRemainder = sum % 12;

            lblResults.Text = $"{sum} eggs total, or {dozens} dozen and {dozensRemainder} eggs";
        }
    }
}
