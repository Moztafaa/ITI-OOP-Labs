namespace Lab1;

public class BankAccount(string accountNumber, decimal balance)
{
    public string AccountNumber { get; private set; } = accountNumber;
    public decimal Balance { get; private set; } = balance;

    public void Deposit(decimal addedBalance)
    {
        if (addedBalance < 0)
        {
            Console.WriteLine("Please add a valid number to deposit!");
            return;
        }

        Balance += addedBalance;

        Console.WriteLine("--------------------------------------------------------");
        Console.WriteLine("Dopisit is completed successfully!");
        Console.WriteLine($"Your balance after transaction: {Balance}");
    }

    public static void TransferFunds(BankAccount fundedAccount, BankAccount receivedAccount, decimal fund)
    {
        Console.WriteLine("--------------------------------------------------------");
        Console.WriteLine($"Your balance before transaction: {fundedAccount.Balance}");
        Console.WriteLine("--------------------------------------------------------");
        if (fundedAccount.Balance < fund)
        {
            Console.WriteLine("You don't have enough balance to make the transaction!");
            return;
        }

        fundedAccount.Balance -= fund;
        receivedAccount.Balance += fund;

        Console.WriteLine("Your transaction is completed successfully!");
        Console.WriteLine($"Your balance after transaction: {fundedAccount.Balance} ");
        Console.WriteLine("--------------------------------------------------------");
    }
}