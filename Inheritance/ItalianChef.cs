namespace Inheritance;

class ItalianChef : Chef
{
    public void makePasta()
    {
        Console.WriteLine("The chef makes pasta");
    }

    public override void makeSpecialDish()
    {
        Console.WriteLine("The chef makes pizza");
    }
}