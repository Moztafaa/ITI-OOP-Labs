namespace Lab3;

public class NonFictionBook : Book
{
    public NonFictionBook(string title, string author, int yearPublished, bool isAvailable, string bookId,
        string subject, int edition, Library library) : base(title, author, yearPublished, isAvailable, bookId, library)
    {
        Subject = subject;
        Edition = edition;
    }

    public string Subject { get; set; }
    public int Edition { get; set; }

    public override void DisplayInfo()
    {
        Console.WriteLine(
            $"----Book Details----\n Title: {Title}\n Subject: {Subject}\n Edition: {Edition}\n Author: {Author}\n Publish Year: {YearPublished}\n Available? {(IsAvailable ? "yes" : "No")} ");
    }

    public override decimal CalculateLateFee(int daysLate)
    {
        return (decimal)(daysLate * 0.25);
    }
}