namespace Lab4;

internal class Program
{
    private static void Main(string[] args)
    {
        SavingAccount savingAccount = new(1000m, "1001", "Abdelrahman", 2m);

        CheckingAccount checkingAccount = new(500m, "1002", "Mostafa", DateTime.Today);


        Console.WriteLine("Savings Account:");
        savingAccount.DisplayBalance();
        savingAccount.Withdraw(100m);
        Console.WriteLine();
        Console.WriteLine("Checking Account Transfer:");
        checkingAccount.Transfer(savingAccount, 200m, "Rent payment");
        checkingAccount.DisplayBalance();
        savingAccount.DisplayBalance();
    }
}