using System.Security.Claims;

namespace HW02_08
{
    public partial class frmHomeSales : Form
    {
        public frmHomeSales()
        {
            InitializeComponent();
        }

        double dSales = 0.0;
        double eSales = 0.0;
        double fSales = 0.0;
        double grandTotal = 0.0;

        private void btnDanielle_Click(object sender, EventArgs e)
        {
            dSales += Double.Parse(txtSale.Text.Trim());
            CalculateGrandTotal();
            UpdateSales();
            TopSalesperson();
        }

        private void btnEdward_Click(object sender, EventArgs e)
        {
            eSales += Double.Parse(txtSale.Text.Trim());
            CalculateGrandTotal();
            UpdateSales();
            TopSalesperson();
        }

        private void btnFrancis_Click(object sender, EventArgs e)
        {
            fSales += Double.Parse(txtSale.Text.Trim());
            CalculateGrandTotal();
            UpdateSales();
            TopSalesperson();
        }
        
        private void CalculateGrandTotal()
        {
            grandTotal += Double.Parse(txtSale.Text.Trim());
        }

        private void UpdateSales()
        {
            lblDSales.Text = $"Danielle Sales: ${dSales}";
            lblESales.Text = $"Edward Sales: ${eSales}";
            lblFSales.Text = $"Francis Sales: ${fSales}";
            lblTotalSales.Text = $"Grand Total: ${grandTotal}";
        }

        private void TopSalesperson()
        {
            double topSales = Math.Max(Math.Max(dSales, eSales), fSales);
            if (topSales == dSales)
            {
                lblTopSalesperson.Text = "Danielle has the most sales";
            }
            else if (topSales == eSales)
            {
                lblTopSalesperson.Text = "Edward has the most sales";
            }
            else if (topSales == fSales)
            {
                lblTopSalesperson.Text = "Francis has the most sales";
            }
        }
    }
}
