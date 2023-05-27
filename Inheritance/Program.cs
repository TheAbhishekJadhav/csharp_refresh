namespace Inheritance;
class Program
{
    static void Main(string[] args)
    {
        Chef chef = new Chef();
        chef.makeChicken();
        chef.makeSpecialDish();
        ItalianChef italianChef = new ItalianChef();
        italianChef.makeChicken();
        italianChef.makeSpecialDish();
    }
}
