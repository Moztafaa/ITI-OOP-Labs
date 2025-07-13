namespace Lab4;

public class SavingAccount : Account
{
    public SavingAccount(decimal balance, string accountNumber, string ownerName, decimal interestRate) : base(
        accountNumber, ownerName, balance)
    {
        InterestRate = interestRate;
    }

    public decimal InterestRate { get; set; }

    public override bool Withdraw(decimal amount)
    {
        if (amount >= Balance)
        {
            Console.WriteLine("You don't have enough Balance!!");
            return false;
        }

        Balance -= amount + 5;

        Console.WriteLine(
            $"After withdrawal of ${amount}:\nBalance: ${Balance} ({InterestRate}% interest) [$5 fee applied]");
        return true;
    }

    public new void DisplayBalance()
    {
        Console.WriteLine($"Balance: ${Balance} ({InterestRate}% interest)");
    }

    public decimal CalculateInterest()
    {
        return Balance * InterestRate / 100;
    }
}