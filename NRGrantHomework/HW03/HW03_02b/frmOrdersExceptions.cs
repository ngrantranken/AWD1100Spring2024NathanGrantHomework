namespace HW03_02b
{
    public partial class frmOrdersExceptions : Form
    {
        private const int MinItemNumber = 100;
        private const int MaxItemNumber = 999;
        private const int MinQuantity = 1;
        private const int MaxQuantity = 12;
        private const int MinEstDeliveryDays = 1;
        private const int MaxEstDeliveryDays = 12;

        public frmOrdersExceptions()
        {
            InitializeComponent();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            try
            {
                int itemNumber      = Convert.ToInt32(txtItemNumber.Text);
                int quantity        = Convert.ToInt32(txtQuantity.Text);
                int estDeliveryDays = Convert.ToInt32(txtEstDeliveryDays.Text);

                if (itemNumber < MinItemNumber || itemNumber > MaxItemNumber)
                {
                    throw new ArgumentException($"Item Number must be between {MinItemNumber} and {MaxItemNumber}.");
                }
                if (quantity < MinQuantity || quantity > MaxQuantity)
                {
                    throw new ArgumentException($"Quantity must be between {MinQuantity} and {MaxQuantity}.");
                }
                if (estDeliveryDays < MinEstDeliveryDays || estDeliveryDays > MaxEstDeliveryDays)
                {
                    throw new ArgumentException($"Estimated Delivery Days must be between {MinEstDeliveryDays} and {MaxEstDeliveryDays}.");
                }

                lblValidOrNot.Text = "Order is valid.";
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values.", "INPUT ERROR");
                lblValidOrNot.Text = "Order is invalid";
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "INPUT ERROR");
                lblValidOrNot.Text = "Order is invalid";
            }
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
