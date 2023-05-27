namespace Variables;
class Program
{
    static void Main(string[] args)
    {
        string charecterName = "Tom";
        int characterAge = 50;
        Console.WriteLine("There once was a man named " + charecterName);
        Console.WriteLine("He was " + characterAge + " years old");

        charecterName = "Mike";
        Console.WriteLine("He really liked the name " + charecterName);
        Console.WriteLine("But didn't like being " + characterAge);
    }
}
