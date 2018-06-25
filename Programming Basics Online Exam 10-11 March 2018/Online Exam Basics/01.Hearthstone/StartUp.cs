using System;
public class StartUp
{
    public static void Main()
    {
        double timeOfHolidays = double.Parse(Console.ReadLine());
        double priceOfCards = double.Parse(Console.ReadLine());
        double priceOfAdventure = double.Parse(Console.ReadLine());
        double priceOfCoffe = double.Parse(Console.ReadLine());

        double timeOfCoffe = timeOfHolidays - 5;
        double timeOfBuyPacektsCards = 3 * 2;
        double timeBuyAdventure = 2 * 2;

        double holidays = timeOfCoffe - (timeOfBuyPacektsCards + timeBuyAdventure);

        double moneyOfPacekts = priceOfCoffe * priceOfCards;
        double moneyOfAdventure = priceOfCards * timeBuyAdventure;

        double total = moneyOfAdventure + moneyOfPacekts + moneyOfPacekts/2;

        Console.WriteLine("{0:f2}", total);
        Console.WriteLine(holidays);
    }
}

