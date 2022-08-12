using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApp
{
    public partial class WithdrawForm : Form
    {

        private IBankAccount currentAcct;

        public WithdrawForm(IBankAccount acct)
        {
            InitializeComponent();
            currentAcct = acct;
        }
        private void btnConfirmWd_Click(object s, EventArgs e)
        {
            double newBalance = 0;
            if(!double.TryParse(tbWdAmt.Text, out newBalance) || newBalance < 0) {
                Error.ShowError("An error occured while trying to make a withdrawal.\nPlease try again.");
                return;
            }
            else {
                double newBal = currentAcct.Withdraw(newBalance);
                if(newBal == -1) return;
                MessageBox.Show($"Withdrawal confirmed.  Your new balance is {Convert.ToString(newBal)}", "Withdrawal Confirmation");
                tbWdAmt.Text = "0.00";
            }
        }

        public void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
