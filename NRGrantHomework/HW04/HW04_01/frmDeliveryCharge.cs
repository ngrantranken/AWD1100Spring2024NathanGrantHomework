namespace HW04_01
{
    public partial class frmDeliveryCharge : Form
    {
        private string[] zipCodes = { "63101", "63103", "63105", "63109", "63113", "63118", "63130", "63133", "63136", "63137" };
        private decimal[] deliveryCharges = { 20, 12, 25, 15, 10, 23, 18, 20, 17, 12 };

        public frmDeliveryCharge()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            CalculateDeliveryCharge();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtZipCode.Text = string.Empty;
            lblDeliveryCharge.Text = "Delivery Charge";
            txtZipCode.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CalculateDeliveryCharge()
        {
            string userInput = txtZipCode.Text.Trim();
            int index = Array.IndexOf(zipCodes, userInput);

            if (index != -1)
            {
                decimal deliveryCharge = deliveryCharges[index];
                lblDeliveryCharge.Text = $"Delivery Charge\n${deliveryCharge:F2}";
            }
            else
            {
                lblDeliveryCharge.Text = $"{userInput} is not a supported Zip Code.";
            }
        }
    }
}
