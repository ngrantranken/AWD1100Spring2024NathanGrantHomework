using System.Drawing.Text;

namespace HW02_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const decimal PERCENT_RAISE = 0.04m;

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            CalculateResults();
        }

        private void CalculateResults()
        {
            string employee1Name = txtName1.Text;
            string employee2Name = txtName2.Text;
            string employee3Name = txtName3.Text;

            decimal employee1Salary1 = Decimal.Parse(txtSalary1.Text);
            decimal employee2Salary1 = Decimal.Parse(txtSalary2.Text);
            decimal employee3Salary1 = Decimal.Parse(txtSalary3.Text);

            decimal employee1Salary2 = employee1Salary1 * (1 + PERCENT_RAISE);
            decimal employee2Salary2 = employee2Salary1 * (1 + PERCENT_RAISE);
            decimal employee3Salary2 = employee3Salary1 * (1 + PERCENT_RAISE);

            decimal employee1Salary3 = employee1Salary2 * (1 + PERCENT_RAISE);
            decimal employee2Salary3 = employee2Salary2 * (1 + PERCENT_RAISE);
            decimal employee3Salary3 = employee3Salary2 * (1 + PERCENT_RAISE);

            string results = String.Format("Year           {0}             {1}               {2}\n", employee1Name, employee2Name, employee3Name);
            results += String.Format("2024     ${0:0.00}     ${1:0.00}     ${2:0.00}\n", employee1Salary1, employee2Salary1, employee3Salary1);
            results += String.Format("2025     ${0:0.00}     ${1:0.00}     ${2:0.00}\n", employee1Salary2, employee2Salary2, employee3Salary2);
            results += String.Format("2026     ${0:0.00}     ${1:0.00}     ${2:0.00}\n", employee1Salary3, employee2Salary3, employee3Salary3);

            lblResults.Text = results;
        }
    }
}
