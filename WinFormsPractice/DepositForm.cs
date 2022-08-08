using System;
using System.Windows.Forms;

namespace BankingApp
{
    public partial class DepositForm : Form
    {

        private IBankAccount currentAcct;
        public DepositForm(IBankAccount acct)
        {
            InitializeComponent();
            currentAcct = acct;
        }

        private void tbDepAmt_TextChanged(object sender, EventArgs e)
        {

        }
        /* TODO: Ensure user can only input number with two decimal places */
        private void btnConfirmDep_Click(object s, EventArgs e)
        {
            double newBalance = 0;
            if(!double.TryParse(tbDepAmt.Text, out newBalance) || newBalance < 0) {
                Error.ShowError("An error occured while trying to make a deposit.\nPlease try again.");
                return;
            }
            else {
                currentAcct.Deposit(newBalance);
                MessageBox.Show($"Deposit confirmed.  Your new balance is {Convert.ToString(currentAcct.GetBalance())}", "Deposit Confirmation");
                tbDepAmt.Text = "0.00";
            }
        }

        public void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
