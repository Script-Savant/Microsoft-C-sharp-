namespace BankAccountsApp
{
    public partial class Form1 : Form
    {
        List<BankAccount> BankAccounts = [];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BankAccountsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CreateAccountBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(OwnerTxt.Text))
                return;

            if (InterestRateNum.Value > 0)
                BankAccounts.Add(new SavingsAccount(OwnerTxt.Text, InterestRateNum.Value));
            else 
                BankAccounts.Add(new BankAccount(OwnerTxt.Text));

            RefreshGrid();
            OwnerTxt.Text = "";
            InterestRateNum.Value = 0;
        }

        private void RefreshGrid()
        {
            BankAccountsGrid.DataSource = null;
            BankAccountsGrid.DataSource = BankAccounts;
        }

        private void DepositBtn_Click(object sender, EventArgs e)
        {
            if (BankAccountsGrid.SelectedRows.Count == 1)
            {
                BankAccount? selectedBankAccount = BankAccountsGrid.SelectedRows[0].DataBoundItem as BankAccount;

                string message = selectedBankAccount.Deposit(AmountNum.Value);
                RefreshGrid();
                AmountNum.Value = 0;
                MessageBox.Show(message);
            }
        }

        private void WithdrawBtn_Click(object sender, EventArgs e)
        {
            if (BankAccountsGrid.SelectedRows.Count == 1)
            {
                BankAccount? selectedBankAccount = BankAccountsGrid.SelectedRows[0].DataBoundItem as BankAccount;
                
                string message = selectedBankAccount.Withdraw(AmountNum.Value);
                RefreshGrid();
                AmountNum.Value = 0;
                MessageBox.Show(message);
            }
        }
    }
}
