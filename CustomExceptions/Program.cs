namespace CustomExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try { 
                BankAccount account = new BankAccount("123456", 1000m);
                Console.WriteLine($"Im going to buy flowers:{account.Withdraw(500m)}");
                Console.WriteLine($"Im going to take her to the Cenepolis: {account.Withdraw(450m)}"); // This will throw InsufficientBalanceException

            }
            catch (InsufficientBalanceException ex)
            {
                Console.WriteLine($"Custom Exception Caught: {ex.Message}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Argument Exception Caught: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"General Exception Caught: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Thank you for banking with us.");
            }
        }
    }
    public class  InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException() : base("Insufficient balance for this operation.")
        {
        }
        public InsufficientBalanceException(string message) : base(message)
        {
        }
        public InsufficientBalanceException(string message, Exception inner) : base(message, inner)
        {
        }
    }
    public class BankAccount
    {
        public string AccountNumber { get; private set; }
        public decimal Balance { get; private set; }
        public BankAccount(string accountNumber, decimal initialBalance)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
        }
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be positive.");
            }
            Balance += amount;
        }
        public string Withdraw(decimal amount)
        {
            var originalBalance = Balance;
        
            if (amount <= 0)
            {
                throw new ArgumentException("Withdrawal amount must be positive.");
            }
            if (amount > Balance)
            {
                throw new InsufficientBalanceException($"Attempted to withdraw {amount}, but only {Balance} is available.");
            }
            Balance -= amount;
        return $"Withdrew {amount}. Balance: {originalBalance} -> {Balance}";
        }
    }
}
