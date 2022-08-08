using System;
using System.Windows.Forms;

namespace BankingApp
{
    public partial class MainForm : Form
    {
        protected IBankAccount newAcct;
        public MainForm()
        {
            InitializeComponent();
            newAcct = new CheckingAccount(1234.56);
        }


         private void btnViewBalance_Click(object sender, EventArgs e)
        {
            GetBalanceForm dlg = new GetBalanceForm(newAcct);
            DialogResult dialogResult = dlg.ShowDialog();
            if(dialogResult != DialogResult.OK && dialogResult != DialogResult.Cancel) { 
                Error.ShowError("Error viewing balance."); 
                Close(); 
            }
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            DepositForm dlg = new DepositForm(newAcct);
            DialogResult dlgResult = dlg.ShowDialog();
            if(dlgResult != DialogResult.Cancel && dlgResult != DialogResult.OK) { 
                Error.ShowError("Error making deposit."); 
                Close(); 
            }
        }
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            WithdrawForm dlg = new WithdrawForm(newAcct);
            DialogResult dlgResult = dlg.ShowDialog();
            if(dlgResult != DialogResult.Cancel && dlgResult != DialogResult.OK) { 
                Error.ShowError("Error making withdrawal."); 
                Close(); 
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
