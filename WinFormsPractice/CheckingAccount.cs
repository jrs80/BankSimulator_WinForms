namespace BankingApp
{
    internal class CheckingAccount : IBankAccount
    {
        private double AccountBalance { get; set; }
        private bool ChecksOrdered { get; set; }
        
        public CheckingAccount(double newBalance=0)
        {
            AccountBalance = newBalance;
            ChecksOrdered = false;
        }

        public double GetBalance() => AccountBalance;

        public bool OrderChecks()
        {
            if(!ChecksOrdered) {
                ChecksOrdered = true;
                return true;
            }
            else { return false; }
        }
        public double Deposit(double amt) {
            if(amt <= 0) {
                Error.ShowError("Invalid amount; you must enter an amount greater than zero.");
                return -1;
            }
            AccountBalance += amt;
            return AccountBalance;
            
        }
        public double Withdraw(double amt)
        {
            if(amt <= 0) {
                Error.ShowError("Invalid amount; you must enter an amount greater than zero.");
                return -1;
            }
            AccountBalance -= amt;
            if(AccountBalance >= 0) return AccountBalance;
            else {
                Error.ShowError("Cannot make withdrawal.  Balance would be less than zero.");
                AccountBalance += amt;
                return -1;
            }
        }

    }
}
