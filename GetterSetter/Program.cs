namespace GetterSetter;
class Program
{
    static void Main(string[] args)
    {
        Movie movie1 = new Movie("The Avengers", "Joss Whedon", "PG-13");
        Movie movie2 = new Movie("Shrek", "Adam Adamson", "PG");
        movie2.Rating = "R";
        Console.WriteLine(movie2.Rating);
    }
}
