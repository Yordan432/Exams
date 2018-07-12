using System;
class Program
{
    static void Main()
    {
        int numberOfPackagePaper = int.Parse(Console.ReadLine());
        int numberOfPackageFabric = int.Parse(Console.ReadLine());
        double littersGlue = double.Parse(Console.ReadLine());
        int percentageReduction = int.Parse(Console.ReadLine());

        double pricePackagePeper = 5.80;
        double priceFabric = 7.20;
        double priceGlue = 1.20;

        double totalPackagePeper = numberOfPackagePaper * pricePackagePeper;
        double totalPackageFabric = numberOfPackageFabric * priceFabric;
        double totalReduction = littersGlue * priceGlue;

        double totalPrice = totalPackagePeper + totalPackageFabric + totalReduction;
        double percentage = totalPrice -
            ((totalPrice * percentageReduction) / 100);

        Console.WriteLine("{0:f3}", percentage);
    }
}

