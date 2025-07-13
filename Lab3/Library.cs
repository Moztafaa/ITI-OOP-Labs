namespace Lab3;

public class Library
{
    public List<Book> Books { get; set; } = new();

    public void AddBook(Book book)
    {
        Books.Add(book);
    }

    public List<Book> FindByAuthor(string author)
    {
        return Books.Where(b => b.Author == author).ToList();
    }

    public void DisplayAllBook()
    {
        foreach (var book in Books)
            Console.WriteLine(
                $"----Book Details----\n Title: {book.Title}\n Author: {book.Author}\n Publish Year: {book.YearPublished}\n Available? {(book.IsAvailable ? "yes" : "No")} \n");
    }
}