using System;
public class StartUp
{
    public static void Main()
    {
        int needQuantityCompote = int.Parse(Console.ReadLine());
        int needQuantityJarsWithJam = int.Parse(Console.ReadLine());

        int jarsCompote = needQuantityCompote + 1;
        int jarsJam = needQuantityJarsWithJam + 1;

        double quantityCherry = (jarsCompote * 0.300);
        double percentOfCherry = (quantityCherry * 0.05) + quantityCherry;

        double quantityCherryPerSweet = (jarsJam * 0.650);
        double percentOfCherryPerSweet = (quantityCherryPerSweet * 0.10) + quantityCherryPerSweet;

        double totalQuantatyCherry = percentOfCherry + percentOfCherryPerSweet;

        double priceCherry = totalQuantatyCherry * 3.2;
        Console.WriteLine("{0:f2}",priceCherry);
    }
}

