namespace Lab3;

internal class Program
{
    private static void Main(string[] args)
    {
        var library = new Library();

        Book regularBook = new("The Great Gatsby", "F. Scott Fitzgerald", 1925, true, "B001", library);
        Book regularBook2 = new("1984", "George Orwell", 1949, false, "B002", library);
        FictionBook fictionBook =
            new("To Kill a Mockingbird", "Harper Lee", 1960, true, "B003", "Drama", true, library);

        FictionBook fictionBook2 =
            new("The Catcher in the Rye", "J.D. Salinger", 1951, true, "B004", "Fiction", false, library);

        ChildrensBook childrensBook = new("The Very Hungry Caterpillar", "Eric Carle", 1969, true, "B005",
            "Children's Literature", true, 3, true, library);
        ChildrensBook childrensBook2 = new("Where the Wild Things Are", "Maurice Sendak", 1963, true, "B006",
            "Children's Literature", true, 4, true, library);

        Console.WriteLine("\n------------------- Regular Books -------------------");
        regularBook.DisplayInfo();
        regularBook.CalculateLateFee(10);
        regularBook2.DisplayInfo();
        regularBook2.CalculateLateFee(10);


        Console.WriteLine("\n------------------- Fiction Books -------------------");
        fictionBook.DisplayInfo();
        fictionBook.CalculateLateFee(10);
        fictionBook2.DisplayInfo();
        fictionBook2.CalculateLateFee(10);

        Console.WriteLine("\n------------------- Children's Books -------------------");
        childrensBook.DisplayInfo();
        childrensBook.CalculateLateFee(10);
        childrensBook2.DisplayInfo();
        childrensBook2.CalculateLateFee(10);

        Console.WriteLine("\n------------------- Library Books -------------------");
        library.DisplayAllBook();
    }
}