namespace Lab3;

public class ChildrensBook : FictionBook
{
    public ChildrensBook(string title, string author, int yearPublished, bool isAvailable, string bookId, string genre,
        bool isBestseller, int recommendedAge, bool hasPictures, Library library) : base(title, author, yearPublished,
        isAvailable,
        bookId, genre, isBestseller, library)
    {
        RecommendedAge = recommendedAge;
        HasPictures = hasPictures;
    }

    public int RecommendedAge { get; set; }
    public bool HasPictures { get; set; }

    public override void DisplayInfo()
    {
        Console.WriteLine(
            $"----Book Details----\n Title: {Title}\n Genre: {Genre}\n Age Recommendation: {RecommendedAge} \n Author: {Author}\n Publish Year: {YearPublished}\n Available? {(IsAvailable ? "yes" : "No")} ");
    }

    public override decimal CalculateLateFee(int daysLate)
    {
        return 0;
    }
}