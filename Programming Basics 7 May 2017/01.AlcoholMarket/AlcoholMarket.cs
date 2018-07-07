using System;
class Program
{
    static void Main()
    {
        double priceWhiskeyLv = double.Parse(Console.ReadLine());
        double quantityBeerInLiters = double.Parse(Console.ReadLine());
        double quantityWineInLiters = double.Parse(Console.ReadLine());
        double quantityBrandyInLiters = double.Parse(Console.ReadLine());
        double quantityWhiskeyInLiters = double.Parse(Console.ReadLine());

        double priceBrandyLiter = priceWhiskeyLv / 2;
        double priceWineLiter = priceBrandyLiter - (0.4 * priceBrandyLiter);
        double priceBeerLiter = priceBrandyLiter - (0.8 * priceBrandyLiter);

        double sumBrandy = quantityBrandyInLiters * priceBrandyLiter;
        double sumWine = quantityWineInLiters * priceWineLiter;
        double sumBeer = quantityBeerInLiters * priceBeerLiter;
        double sumShiskey = priceWhiskeyLv * quantityWhiskeyInLiters;
        double totalSum = sumBrandy + sumWine + sumBeer + sumShiskey;

        Console.WriteLine("{0:f2}", totalSum);
    }
}

