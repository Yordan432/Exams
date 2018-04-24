using System;
public class StartUp
{
    public static void Main()
    {
        string nameEarth = Console.ReadLine();
        int countDaysOfEarth = int.Parse(Console.ReadLine());

        double distanceOfEathMercury = 0.61;
        double maxNumberDaysOfMercury = 7;

        double distanceOfEarthVenus = 0.28;
        double maxNumberDaysOfVenus = 14;

        double distanceOfEarthMars = 0.52;
        double maxNumberDaysOfMars = 20;

        double distanceOfEathJupiter = 4.2;
        double maxNumberDaysOfJupiter = 5;

        double distanceOfEathSaturn = 8.52;
        double maxNumberDaysOfSaturn = 3;

        double distanceOfEathUranus = 18.21;
        double maxNumberDaysUranus = 3;

        double distanceOfEathNeptune = 29.09;
        double maxNumberDaysNeptune = 2;

        double totalDistance = 0.0;
        double days = 0.0;

        double unitPerDays = 226;
        bool isValidNumberDays = true;
        switch (nameEarth)
        {
            case "Mercury":
                totalDistance = distanceOfEathMercury * 2;
                days = (2 * (unitPerDays * distanceOfEathMercury)) + countDaysOfEarth;
                if (countDaysOfEarth > maxNumberDaysOfMercury)
                {
                    isValidNumberDays = false;
                }
                break;
            case "Venus":
                totalDistance = distanceOfEarthVenus * 2;
                days = 2 * (unitPerDays * distanceOfEarthVenus) + countDaysOfEarth;
                if (countDaysOfEarth > maxNumberDaysOfVenus)
                {
                    isValidNumberDays = false;
                }
                break;
            case "Mars":
                totalDistance = distanceOfEarthMars * 2;
                days = 2 * (unitPerDays * distanceOfEarthMars) + countDaysOfEarth;
                if (countDaysOfEarth > maxNumberDaysOfMars)
                {
                    isValidNumberDays = false;
                }
                break;
            case "Jupiter":
                totalDistance = distanceOfEathJupiter * 2;
                days = 2 * (unitPerDays * distanceOfEathJupiter) + countDaysOfEarth;
                if (countDaysOfEarth > maxNumberDaysOfJupiter)
                {
                    isValidNumberDays = false;
                }
                break;
            case "Saturn":
                totalDistance = distanceOfEathSaturn * 2;
                days = 2 * (unitPerDays * distanceOfEathSaturn) + countDaysOfEarth;
                if (countDaysOfEarth > maxNumberDaysOfSaturn)
                {
                    isValidNumberDays = false;
                }
                break;
            case "Uranus":
                totalDistance = distanceOfEathUranus * 2;
                days = 2 * (unitPerDays * distanceOfEathUranus) + countDaysOfEarth;
                if (countDaysOfEarth > maxNumberDaysUranus)
                {
                    isValidNumberDays = false;
                }
                break;
            case "Neptune":
                totalDistance = distanceOfEathNeptune * 2;
                days = 2 * (unitPerDays * distanceOfEathNeptune) + countDaysOfEarth;
                if (countDaysOfEarth > maxNumberDaysNeptune)
                {
                    isValidNumberDays = false;
                }
                break;
            default:
                Console.WriteLine("Invalid planet name!");
                return;
        }
        if (isValidNumberDays)
        {
            Console.WriteLine($"Distance: {totalDistance:f2}");
            Console.WriteLine($"Total number of days: {days:f2}");
        }
        else
        {
            Console.WriteLine("Invalid number of days!");
        }
    }
}
