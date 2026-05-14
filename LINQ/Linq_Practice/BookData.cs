public class Book
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Author { get; set; }
    public double Price { get; set; }

    public Book(int Id, string Name, string Author, double Price)
    {
        this.Id = Id;
        this.Name = Name;
        this.Author = Author;
        this.Price = Price;
    }
}

public class BooksData
{
    public static IEnumerable<Book> GetBooks()
    {
        return new List<Book>()
        {
            new Book(1, "5 Am", "Robin Sharma", 199),
            new Book(2, "The Secrate", "Mahesh hood", 500),
            new Book(3, "The Life Lession", "Ashok Chitkara", 199)
        };
    }
}