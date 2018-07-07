using System;
class Program
{
    static void Main()
    {
        int capacityStadium = int.Parse(Console.ReadLine());
        int numbersFans = int.Parse(Console.ReadLine());

        double sectorA = 0.0;
        double sectorB = 0.0;
        double sectorV = 0.0;
        double sectorG = 0.0;
        for (int i = 0; i < numbersFans; i++)
        {
            string sector = Console.ReadLine();
            if (sector == "A")
            {
                sectorA++;
            }
            else if(sector == "B")
            {
                sectorB++;
            }
            else if(sector == "V")
            {
                sectorV++;
            }
            else if(sector == "G")
            {
                sectorG++;
            }
        }
        Console.WriteLine("{0:f2}%", (sectorA / numbersFans) * 100);
        Console.WriteLine("{0:f2}%", (sectorB / numbersFans) * 100);
        Console.WriteLine("{0:f2}%", (sectorV / numbersFans) * 100);
        Console.WriteLine("{0:f2}%", (sectorG / numbersFans) * 100);
        Console.WriteLine("{0:f2}%", ((double)numbersFans / capacityStadium) * 100);
    }
}
