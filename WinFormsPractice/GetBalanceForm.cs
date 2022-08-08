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
    public partial class GetBalanceForm : Form
    {

        private IBankAccount currentAcct;
        public GetBalanceForm(IBankAccount acct)
        {
            InitializeComponent();
            currentAcct = acct;
            btnDispAcctBal.Text = Convert.ToString(currentAcct.GetBalance());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOrderChecks_Click(object sender, EventArgs e)
        {
            if(currentAcct.OrderChecks()) {
                MessageBox.Show("Checks have been ordered for this account.\nPlease allow up to two weeks for delivery.", "Check Order Confirmation");
            }
            else { MessageBox.Show("Checks have already been ordered for this account.","Check Order Failed"); }
        }
    }
}
