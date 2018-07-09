using System;
class Program
{
    static void Main()
    {
        int lengthInMeters = int.Parse(Console.ReadLine());
        int widthInMeters = int.Parse(Console.ReadLine());
        double heightInMeters = double.Parse(Console.ReadLine());
        double priceInLeva = double.Parse(Console.ReadLine());
        double weight = double.Parse(Console.ReadLine());

        double lengthNetwork = 2 * lengthInMeters + 2 * widthInMeters;
        double priceNetwork = lengthNetwork * priceInLeva;
        double areaNetwork = lengthNetwork * heightInMeters;
        double weigthNetwork = areaNetwork * weight;

        Console.WriteLine($"{lengthNetwork}");
        Console.WriteLine($"{priceNetwork:f2}");
        Console.WriteLine($"{weigthNetwork:f3}");

    }
}

