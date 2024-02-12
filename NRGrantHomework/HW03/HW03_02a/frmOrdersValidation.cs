namespace HW03_02a
{
    public partial class frmOrdersValidation : Form
    {
        private const int MinItemNumber = 100;
        private const int MaxItemNumber = 999;
        private const int MinQuantity = 1;
        private const int MaxQuantity = 12;
        private const int MinEstDeliveryDays = 1;
        private const int MaxEstDeliveryDays = 12;

        public frmOrdersValidation()
        {
            InitializeComponent();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                lblValidOrNot.Text = "Order is valid.";
            }
        }

        private bool IsValidData()
        {
            return IsPresent(txtItemNumber, "Item Number")
                && IsPresent(txtQuantity, "Quantity")
                && IsPresent(txtEstDeliveryDays, "Estimated Delivery Days")
                && IsInt32(txtItemNumber, "Item Number")
                && IsInt32(txtQuantity, "Quantity")
                && IsInt32(txtEstDeliveryDays, "Estimated Delivery Days")
                && IsWithinRange(txtItemNumber, "Item Number", MinItemNumber, MaxItemNumber)
                && IsWithinRange(txtQuantity, "Quantity", MinQuantity, MaxQuantity)
                && IsWithinRange(txtEstDeliveryDays, "Estimated Delivery Days", MinEstDeliveryDays, MaxEstDeliveryDays);
        }

        private bool IsPresent(TextBox textBox, string name)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                MessageBox.Show($"{name} is required", "INPUT ERROR");
                lblValidOrNot.Text = "Order is invalid";
                textBox.Focus();
                return false;
            }
            return true;
        }

        private bool IsInt32(TextBox textBox, string name)
        {
            if (!int.TryParse(textBox.Text, out _))
            {
                MessageBox.Show($"{name} must be an integer.", "INPUT ERROR");
                lblValidOrNot.Text = "Order is invalid";
                textBox.Focus();
                return false;
            }
            return true;
        }

        private bool IsWithinRange(TextBox textBox, string name, int min, int max)
        {
            int value = Convert.ToInt32(textBox.Text);
            if (value < min || value > max)
            {
                MessageBox.Show($"{name} must be between {min} and {max}.");
                lblValidOrNot.Text = "Order is invalid";
                textBox.Focus();
                return false;
            }
            return true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtItemNumber.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            txtEstDeliveryDays.Text = string.Empty;
            lblValidOrNot.Text = string.Empty;
            txtItemNumber.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
