namespace HW03_01b
{
    public partial class frmBMIException : Form
    {
        public frmBMIException()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double height = Convert.ToDouble(txtHeight.Text);
                double weight = Convert.ToDouble(txtWeight.Text);

                if (height < 12 || height > 96)
                {
                    throw new ArgumentException("Height must be between 12 and 96.");
                }
                if (weight < 1 || weight > 777)
                {
                    throw new ArgumentException("Weight must be between 1 and 777.");
                }

                double bmi = CalculateBMI(height, weight);
                string status = GetStatus(bmi);

                lblResults.Text = $"BMI: {bmi:F1}\nCategory: {status}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values.", "INPUT ERROR");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "INPUT ERROR");
            }
        }

        private double CalculateBMI(double height, double weight)
        {
            return (weight / (height * height)) * 703;
        }

        private string GetStatus(double bmi)
        {
            if (bmi < 18.5)
                return "Underweight";
            else if (bmi >= 18.5 && bmi < 25.0)
                return "Optimal Weight";
            else if (bmi >= 25.0 && bmi < 30.0)
                return "Overweight";
            else
                return "Obese";
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
