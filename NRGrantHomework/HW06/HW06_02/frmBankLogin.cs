namespace HW06_02
{
    public partial class frmBankLogin : Form
    {
        List<Account> accounts = new List<Account>();
        string currentAccountNumber = "";
        string currentPinNumber = "";
        int accountNumberLocation = 0;
        int pinNumberLocation = 0;
        bool loggedIn = false;

        public frmBankLogin()
        {
            InitializeComponent();
        }

        private void frmBankLogin_Load(object sender, EventArgs e)
        {
            accounts.Add(new Account("Mr.", "Jeffrey", "Scott", "123-45-6789", "1234", 10000.00m));
            accounts.Add(new Account("Mr.", "Evan", "Gudmestad", "234-56-7890", "2345", 2578.00m));
            accounts.Add(new Account("Mr.", "Doug", "Geggleman", "345-67-8901", "3456", 7654.00m));
            accounts.Add(new Account("Mr.", "James", "Kaufmann", "456-78-9012", "4567", 87654.00m));
            accounts.Add(new Account("Ms.", "Shannon", "Corrigan", "567-89-0123", "5678", 782.00m));

            DisplayAllCustomers();
        }

        private void DisplayAllCustomers()
        {
            string outputStr = "";
            foreach (Account account in accounts)
            {
                outputStr += account.GetTitle() + " " + account.GetFirstName() + " " + account.GetLastName() + "\n" + account.GetAccountNumber() + "\n" + account.GetPinNumber() + "\n" + account.GetBalance().ToString("c") + "\n\n";
            }

            MessageBox.Show(outputStr, "CURRENT CUSTOMERS");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            AttemptToLogin();
        }

        private void AttemptToLogin()
        {
            bool keepGoing = ValidateAccountNumber();

            if (keepGoing)
            {
                keepGoing = ValidatePinNumber();
            }

            if (accountNumberLocation == pinNumberLocation)
            {
                loggedIn = true;
                DisplayCustomerInfo();
            }
        }

        private bool ValidateAccountNumber()
        {
            string acctNumber = txtAccountNumber.Text.Trim();
            
            for (int lcv = 0; lcv < accounts.Count; lcv++)
            {
                if (acctNumber == accounts[lcv].GetAccountNumber())
                {
                    currentAccountNumber = acctNumber;
                    accountNumberLocation = lcv;
                    return true;
                }
            }
            ShowErrorMessage("That Account Number Does Not Exist.", "INVALID ACCOUNT NUMBER");
            return false;
        }

        private bool ValidatePinNumber()
        {
            string pinNumber = txtAccountNumber.Text.Trim();

            for (int lcv = 0; lcv < accounts.Count; lcv++)
            {
                if (pinNumber == accounts[lcv].GetPinNumber())
                {
                    currentPinNumber = pinNumber;
                    accountNumberLocation = lcv;
                    return true;
                }
            }
            
            return false;
        }

        public void DisplayCustomerInfo()
        {
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {

        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowErrorMessage(string msg, string title)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
