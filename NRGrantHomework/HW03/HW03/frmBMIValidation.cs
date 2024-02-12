namespace HW03
{
    public partial class frmBMIValidation : Form
    {
        private const int MinHeight = 12;
        private const int MaxHeight = 96;
        private const int MinWeight = 1;
        private const int MaxWeight = 777;

        public frmBMIValidation()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (IsInputValid())
            {
                double height = Convert.ToDouble(txtHeight.Text);
                double weight = Convert.ToDouble(txtWeight.Text);
                double bmi = CalculateBMI(height, weight);
                string status = GetStatus(bmi);

                lblResults.Text = $"BMI: {bmi:F2}\nCategory: {status}";
            }
        }

        private bool IsInputValid()
        {
            return IsPresent(txtHeight, "Height")
                && IsPresent(txtWeight, "Weight")
                && IsInt32(txtHeight, "Height")
                && IsInt32(txtWeight, "Weight")
                && IsWithinRange(txtHeight, "Height", MinHeight, MaxHeight)
                && IsWithinRange(txtWeight, "Weight", MinWeight, MaxWeight);
        }

        private bool IsPresent(TextBox textBox, string name)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                MessageBox.Show($"{name} is required.", "INPUT ERROR");
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
                MessageBox.Show($"{name} must be between {min} and {max}.", "INPUT ERROR");
                textBox.Focus();
                return false;
            }
            return true;
        }

        private double CalculateBMI(double height, double weight)
        {
            return (weight / (height * height)) * 703;
        }

        private string GetStatus(double bmi)
        {
            if (bmi < 18.5)
            {
                return "Underweight";
            }
            else if (bmi >= 18.5 && bmi < 25.0)
            {
                return "Optimal Weight";
            }
            else if (bmi >= 25.0 && bmi < 30.0)
            {
                return "Overweight";
            }
            else
            {
                return "Obese";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHeight.Text = string.Empty;
            txtWeight.Text = string.Empty;
            lblResults.Text = string.Empty;
            txtWeight.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
