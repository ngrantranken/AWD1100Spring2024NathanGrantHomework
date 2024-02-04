using System.Xml.Serialization;

namespace HW02_05
{
    public partial class frmHurricaneScale : Form
    {
        public frmHurricaneScale()
        {
            InitializeComponent();
        }

        private void btnEstimate_Click(object sender, EventArgs e)
        {
            double windSpeed = Double.Parse(txtWindSpeed.Text.Trim());

            if (windSpeed >= 157)
            {
                txtCategory.Text = "Category 5";
            }
            else if (windSpeed >= 130)
            {
                txtCategory.Text = "Category 4";
            }
            else if (windSpeed >= 111)
            {
                txtCategory.Text = "Category 3";
            }
            else if (windSpeed >= 96)
            {
                txtCategory.Text = "Category 2";
            }
            else if (windSpeed >= 74)
            {
                txtCategory.Text = "Category 1";
            }
            else
            {
                txtCategory.Text = "Not a hurricane";
            }
        }
    }
}
