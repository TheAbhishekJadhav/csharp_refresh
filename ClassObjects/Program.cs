namespace ClassObjects;
class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book();
        book1.title = "Harry Potter";
        book1.auther = "JK Rowling";
        book1.pages = 400;

        Book book2 = new Book("Lord of the Rings", "Tolkien", 700);
        book2.title = "Hobbit";

        Book book3 = new Book();

        Console.WriteLine(book1.title);
        Console.WriteLine(book2.title);
    }
}
