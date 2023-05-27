namespace Inheritance;

class Chef
{
    public void makeChicken()
    {
        Console.WriteLine("The chef makes chicken");
    }

    public void makeSalad()
    {
        Console.WriteLine("The chef makes salad");
    }

    public virtual void makeSpecialDish()
    {
        Console.WriteLine("The chef makes bbq ribs");
    }
}