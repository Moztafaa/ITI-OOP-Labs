namespace Lab4;

public abstract class Account
{
    public Account(string accountNumber, string ownerName, decimal balance)
    {
        AccountNumber = accountNumber;
        OwnerName = ownerName;

        Balance = balance;
    }

    public string AccountNumber { get; }
    public decimal Balance { get; protected set; }
    public string OwnerName { get; set; }

    public void Deposit(decimal amount)
    {
        Balance += amount;
    }

    public virtual bool Withdraw(decimal amount)
    {
        if (amount > Balance) return false;

        Balance -= amount;
        return true;
    }

    public void DisplayBalance()
    {
        Console.WriteLine($"Balance: ${Balance}");
    }

    public void Transfer(Account destination, decimal amount)
    {
        if (Balance < amount)
        {
            Console.WriteLine("Your Balance Can't do this transaction");
            return;
        }

        Withdraw(amount);
        destination.Deposit(amount);
        Console.WriteLine(
            $"Transferred ${amount} to {destination.AccountNumber} (Description: {destination.AccountNumber})");
    }
}