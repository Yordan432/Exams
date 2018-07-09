using System;
class Lutenitsa
{
    static void Main()
    {
        double quantityDomatosKillos = double.Parse(Console.ReadLine());
        int numberOfBoxes = int.Parse(Console.ReadLine());
        int numberOfJar = int.Parse(Console.ReadLine());

        double totalKillosLutenitsa = quantityDomatosKillos / 5;
        double jars = totalKillosLutenitsa / 0.535;
        double boxes = jars / numberOfJar;

        Console.WriteLine($"Total lutenica: {(int)totalKillosLutenitsa} kilograms.");
        if (boxes > numberOfBoxes)
        {
            int cassettesRemain = (int)boxes - numberOfBoxes;
            int jarsRemain = (int)jars - (numberOfBoxes * numberOfJar);
            Console.WriteLine($"{cassettesRemain} boxes left.");
            Console.WriteLine($"{jarsRemain} jars left.");
        }
        else
        {
            int needBoxes = (int)(numberOfBoxes - boxes);
            int needJars = (int)((numberOfBoxes * numberOfJar) - jars);
            Console.WriteLine($"{needBoxes} more boxes needed.");
            Console.WriteLine($"{needJars} more jars needed.");
        }
    }
}

