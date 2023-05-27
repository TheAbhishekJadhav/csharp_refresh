namespace GuessingGame;
class Program
{
    static void Main(string[] args)
    {
        string secretWord = "Abhishek";
        string guess = "";
        int guessCount = 0;
        int guessLimit = 3;
        bool outOfGuesses = false;

        while(guess != secretWord && !outOfGuesses)
        {
            if(guessCount < guessLimit)
            {
                Console.Write("Enter guess: ");
                guess = Console.ReadLine();
                guessCount++;
            }
            else
            {
                outOfGuesses = true;
            }
        }

        if(outOfGuesses)
        {
            Console.WriteLine("You Lose!");
        }
        else{
            Console.WriteLine("You win!");
        }
    }
}
