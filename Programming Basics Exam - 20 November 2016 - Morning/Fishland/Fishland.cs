using System;
class Fishland
{
    static void Main()
    {
        double priceSkumriq = double.Parse(Console.ReadLine());
        double priceCaca = double.Parse(Console.ReadLine());
        double kgPalamud = double.Parse(Console.ReadLine());
        double kgSafrid = double.Parse(Console.ReadLine());
        double kgMidi = double.Parse(Console.ReadLine());

        double pricePalamud = priceSkumriq + (priceSkumriq * 0.60);
        double sumPalamud = kgPalamud * pricePalamud;
        double priceSafrid = priceCaca + (priceCaca * 0.80);
        double sumSafrid = kgSafrid * priceSafrid;
        double sumMidi = kgMidi * 7.50;

        double result = sumPalamud + sumSafrid + sumMidi;
        Console.WriteLine("{0:f2}" , result);

    }
}

