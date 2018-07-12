using System;
class TailoringWorkshop
{
    static void Main()
    {
        int rectangleTables = int.Parse(Console.ReadLine());
        double lengthOfTablesInMeters = double.Parse(Console.ReadLine());
        double widthOfTablesInMeteres = double.Parse(Console.ReadLine());

        double totalAreaCover = rectangleTables * (lengthOfTablesInMeters + 2 * 0.30)
            * (widthOfTablesInMeteres + 2 * 0.30);

        double totalAreaCoach = rectangleTables * (lengthOfTablesInMeters / 2) *
            (lengthOfTablesInMeters / 2);

        double priceInDolars = totalAreaCover * 7 + totalAreaCoach * 9;
        double priceInLv = priceInDolars * 1.85;

        Console.WriteLine($"{priceInDolars:f2} USD");
        Console.WriteLine($"{priceInLv:f2} BGN");
    }
}

