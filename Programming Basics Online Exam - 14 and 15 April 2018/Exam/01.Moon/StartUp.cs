using System;
public class StartUp
{
    public static void Main()
    {
        double averageSpeed = double.Parse(Console.ReadLine());
        double littersFuelOf1km = double.Parse(Console.ReadLine());

        double distaneBetweenMoonAndLand = 384400;
        double totalDistance = distaneBetweenMoonAndLand * 2;

        double time = Math.Ceiling(totalDistance / averageSpeed);

        double totalTime = time + 3;

        double fuel = (littersFuelOf1km * totalDistance) / 100;
        Console.WriteLine(totalTime);
        Console.WriteLine(fuel);
    }
}
