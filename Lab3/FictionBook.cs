namespace Lab3;

public class FictionBook : Book

{
    public FictionBook(string title, string author, int yearPublished, bool isAvailable, string bookId, string genre,
        bool isBestseller, Library library) : base(title, author, yearPublished, isAvailable, bookId, library)
    {
        Genre = genre;
        IsBestseller = isBestseller;
    }

    public string Genre { get; set; }
    public bool IsBestseller { get; set; }

    public override void DisplayInfo()
    {
        Console.WriteLine(
            $"----Book Details----\n Title: {Title}\n Genre: {Genre} \n Author: {Author}\n Publish Year: {YearPublished}\n Available? {(IsAvailable ? "yes" : "No")} ");
    }

    public override decimal CalculateLateFee(int daysLate)
    {
        return daysLate;
    }
}