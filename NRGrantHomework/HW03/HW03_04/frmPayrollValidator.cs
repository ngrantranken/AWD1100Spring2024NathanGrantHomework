namespace HW03_04
{
    public partial class frmPayrollValidator : Form
    {
        private const int MinHours = 0;
        private const int MaxHours = 84;
        private const int MinRate = 0;
        private const int MaxRate = 99;
        private const int OverTimePay = 2;

        public frmPayrollValidator()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                decimal hours = Convert.ToDecimal(txtHours.Text);
                decimal rate = Convert.ToDecimal(txtRate.Text);

                txtGrossPay.Text = $"${CalculateGrossPay(hours, rate)}";
            }
        }

        private bool IsValidData()
        {
            return IsPresent(txtHours, "Employee Hours Worked")
                && IsPresent(txtRate, "Employee Hourly Rate")
                && IsDecimal(txtHours, "Employee Hours Worked")
                && IsDecimal(txtRate, "Employee Hourly Rate")
                && IsWithinRange(txtHours, "Employee Hours Worked", MinHours, MaxHours)
                && IsWithinRange(txtRate, "Employee Hourly Rate", MinRate, MaxRate);
        }

        private bool IsPresent(TextBox textBox, string name)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                MessageBox.Show($"{name} is required", "INPUT ERROR");
                textBox.Focus();
                return false;
            }
            return true;
        }

        private bool IsDecimal(TextBox textBox, string name)
        {
            if (!decimal.TryParse(textBox.Text, out _))
            {
                MessageBox.Show($"{name} must be a decimal.", "INPUT ERROR");
                textBox.Focus();
                return false;
            }
            return true;
        }

        private bool IsWithinRange(TextBox textBox, string name, int min, int max)
        {
            decimal value = Convert.ToDecimal(textBox.Text);

            if (value < min || value > max)
            {
                MessageBox.Show($"{name} must be between {min} and {max}");
                textBox.Focus();
                return false;
            }
            return true;
        }

        private decimal CalculateGrossPay(decimal hours, decimal rate)
        {
            if (hours > 40)
            {
                return (((hours - 40) * (2 * rate)) + (40 * rate));
            }
            else
            {
                return (hours * rate);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHours.Text = string.Empty;
            txtRate.Text = string.Empty;
            txtGrossPay.Text = string.Empty;
            txtHours.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
