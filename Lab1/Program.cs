namespace Lab1;

internal class Program
{
    private static void Main()
    {
        // Rectangle rect = new(10, 10);
        // Console.WriteLine($"Area of the Rectangle equals: {rect.GetArea()}");
        // Console.WriteLine(rect.IsSquare() ? "This Rectangle is square" : "This Rectangle is not square");

        // -----------------------------

        BankAccount acc1 = new("12345678901234567890123456789", 1000);
        BankAccount acc2 = new("12345678901234567890123456780", 2000);
        acc2.Deposit(500);
        BankAccount.TransferFunds(acc2, acc1, 2500);
    }
}