namespace Methods;
class Program
{
    static void Main(string[] args)
    {
        SayHi("Mike", 38);
        SayHi("John", 57);
        SayHi("Tom", 13);
        Console.WriteLine(Cube(5));
    }

    static void SayHi(string name, int age)
    {
        Console.WriteLine("Hello " + name + " you are " + age);
    }

    static int Cube(int num)
    {
        int result = num * num * num;
        return result;
    }
}
