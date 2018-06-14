using System;
class Flowers
{
    static void Main()
    {
        int numberOfChrysanthemums = int.Parse(Console.ReadLine());
        int numberOfRoses = int.Parse(Console.ReadLine());
        int numberOfTulips = int.Parse(Console.ReadLine());
        string season = Console.ReadLine();
        char isHoliday = char.Parse(Console.ReadLine());

        double priceBouquet = 2;
        double priceForChrysanthemums = 0;
        double priceRoses = 0;
        double priceTulips = 0;
        int totalFlowers = numberOfChrysanthemums + numberOfRoses + numberOfTulips;
        switch (season)
        {
            case "Spring":
            case "Summer":
                priceForChrysanthemums = 2.00;
                priceRoses = 4.10;
                priceTulips = 2.50;
                break;
            case "Autumn":
            case "Winter":
                priceForChrysanthemums = 3.75;
                priceRoses = 4.50;
                priceTulips = 4.15;
                break;
        }

        double calcPrice =
            numberOfChrysanthemums * priceForChrysanthemums +
            numberOfRoses * priceRoses + numberOfTulips * priceTulips;
        
        if (isHoliday == 'Y')
        {
            double discount = calcPrice + (calcPrice * 0.15);
            calcPrice = discount;
        }
        if (totalFlowers >=20)
        {
            calcPrice = calcPrice - (calcPrice * 0.20);
        }
        if (numberOfTulips > 7 && season == "Spring")
        {
           calcPrice = calcPrice - (calcPrice * 0.05);
        }
        if (numberOfRoses >=10 && season == "Winter")
        {
            calcPrice = calcPrice - (calcPrice * 0.10);
        }
        

        Console.WriteLine($"{calcPrice + priceBouquet:f2}");
    }
}

