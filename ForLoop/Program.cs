namespace ForLoop;
class Program
{
    static void Main(string[] args)
    {
        int[] luckyNumber = {2, 8, 14, 26, 35, 57};

        for(int i = 0; i < luckyNumber.Length; i++)
            Console.WriteLine(luckyNumber[i]);
    }
}
