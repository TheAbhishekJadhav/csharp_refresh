namespace Strings;
class Program
{
    static void Main(string[] args)
    {
        string phrase = "Abhishek Jadhav";

        Console.WriteLine(phrase);
        Console.WriteLine(phrase.Length);
        Console.WriteLine(phrase.ToUpper());
        Console.WriteLine(phrase.ToLower());
        Console.WriteLine(phrase.Contains("Jadhav"));
        Console.WriteLine(phrase[0]);
        Console.WriteLine(phrase.IndexOf('J'));
        Console.WriteLine(phrase.IndexOf('z')); // -1 represents value doesnt exist
        Console.WriteLine(phrase.Substring(9, 3));
    }
}
