namespace ClassObjects;
class Book
{
    public string title;
    public string auther;
    public int pages;

    public Book()
    {
        
    }

    public Book(string aTitle, string aAuther, int aPages)
    {
        title = aTitle;
        auther = aAuther;
        pages = aPages;
    }
}