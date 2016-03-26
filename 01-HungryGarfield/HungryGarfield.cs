using System;

class HungryGarfield
{
    static void Main()
    {
        decimal totalMonay = decimal.Parse(Console.ReadLine());
        decimal exchangeRate = decimal.Parse(Console.ReadLine());
        decimal pizzaPrice = decimal.Parse(Console.ReadLine());
        decimal lasagnaPrice = decimal.Parse(Console.ReadLine());
        decimal sandwichPrice = decimal.Parse(Console.ReadLine());
        decimal pizzaQuantity = decimal.Parse(Console.ReadLine());
        decimal lasagnaQuantity = decimal.Parse(Console.ReadLine());
        decimal sandwichQuantity = decimal.Parse(Console.ReadLine());

        pizzaPrice = pizzaPrice / exchangeRate;
        lasagnaPrice = lasagnaPrice / exchangeRate;
        sandwichPrice = sandwichPrice / exchangeRate;

        decimal totalCost = pizzaPrice * pizzaQuantity +
                            lasagnaPrice * lasagnaQuantity +
                            sandwichPrice * sandwichQuantity;

        if (totalCost <= totalMonay)
        {
            Console.WriteLine("Garfield is well fed, John is awesome. Money left: ${0:F2}.", (totalMonay - totalCost));
        }
        else
        {
            Console.WriteLine("Garfield is hungry. John is a badass. Money needed: ${0:F2}.", (totalCost - totalMonay));
        }
    }
}