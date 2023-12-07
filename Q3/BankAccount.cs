namespace Q3
{
    public class BankAccount
    {
        private int AccountNumber { get; set; }
        private string AccountHolder { get; set; }
        private double Balance { get; set; }

        public BankAccount(int accountNumber, string accountHolder, double balance)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            Balance = balance;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public void Withdraw(double amount)
        {
            Balance -= amount;
        }
        public override string ToString()
        {
            return $"Account Number: {AccountNumber}\nAccount Holder: {AccountHolder}\nAccount Balance: {Balance:c}";
        }
    }
}