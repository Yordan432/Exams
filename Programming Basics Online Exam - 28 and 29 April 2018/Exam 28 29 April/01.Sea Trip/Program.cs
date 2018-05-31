using System;
class Program
{
    static void Main()
    {
        double moneyForFood = double.Parse(Console.ReadLine());
        double moneyForSouvenirs = double.Parse(Console.ReadLine());
        double moneyForHotel = double.Parse(Console.ReadLine());

        double roadToSea = 210;
        double totalRoadKm = roadToSea * 2;

        double litersGasoline = 7;
        double killometers = 100;
        double priceGasoline = 1.85;
        int numberOfDay = 3;

        double literGasoline = (totalRoadKm / killometers) * litersGasoline;
        double gasoline = literGasoline * priceGasoline;

        double cost = numberOfDay * moneyForFood + numberOfDay * moneyForSouvenirs;

        double firstDayReduction = moneyForHotel * 0.9;
        double secondDayReduction = moneyForHotel * 0.85;
        double thirdDayReduction = moneyForHotel * 0.8;

        double totalSum = gasoline + cost + firstDayReduction +
            secondDayReduction + thirdDayReduction;

        Console.WriteLine($"Money needed: {totalSum}");
    }
}

