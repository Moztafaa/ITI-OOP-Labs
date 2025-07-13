namespace Lab3;

public class Book
{
    public Book(string title, string author, int yearPublished, bool isAvailable, string bookId, Library library)
    {
        Title = title;
        Author = author;
        YearPublished = yearPublished;
        IsAvailable = isAvailable;
        BookId = bookId;
        Library = library;
        Library.AddBook(this);
    }

    public string Title { get; set; }
    public string Author { get; set; }
    public int YearPublished { get; set; }
    public bool IsAvailable { get; set; }
    public string BookId { get; set; }

    private Library Library { get; }

    public virtual void DisplayInfo()
    {
        Console.WriteLine(
            $"\n----Book Details----\n Title: {Title}\n Author: {Author}\n Publish Year: {YearPublished}\n Available? {(IsAvailable ? "yes" : "No")} ");
    }

    public virtual decimal CalculateLateFee(int daysLate)
    {
        return (decimal)(daysLate * 0.50);
    }

    public void CheckOut()
    {
    }

    public void CheckIn()
    {
    }
}