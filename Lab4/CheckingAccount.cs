namespace Lab4;

public class CheckingAccount : Account
{
    public const decimal MonthlyFee = 25m;


    private static int _dayLimit = 3;

    public CheckingAccount(decimal balance, string accountNumber, string ownerName,
        DateTime withdrawalDate) : base(
        accountNumber, ownerName, balance)
    {
        WithdrawalDate = withdrawalDate;
    }

    public DateTime WithdrawalDate { get; set; }

    public override bool Withdraw(decimal amount)
    {
        if (amount > Balance && _dayLimit <= 0)
        {
            Console.WriteLine("Your Balance Can't do this transaction or your exceed the daily limit withdraw");
            return false;
        }

        Balance -= amount;
        _dayLimit -= 1;
        if (DateTime.Today > WithdrawalDate) _dayLimit = 3;

        // Console.WriteLine("Done!");
        return true;
    }

    public void Transfer(Account destination, decimal amount, string description)
    {
        if (Balance < amount)
        {
            Console.WriteLine("Your Balance Can't do this transaction");
            return;
        }

        Withdraw(amount);
        destination.Deposit(amount);
        Console.WriteLine($"Transferred ${amount} to {destination.AccountNumber} (Description: {description})");
    }
}