namespace Arrays;
class Program
{
    static void Main(string[] args)
    {
        int[] luckyNumbers = {4, 6, 12, 24, 25, 75, 96};
        string[] friends = new string[5];

        luckyNumbers[1] = 80;
        friends[0] = "Jim";
        friends[1] = "Kelly";

        Console.WriteLine(luckyNumbers[2]);
        Console.WriteLine(friends[1]);
    }
}
