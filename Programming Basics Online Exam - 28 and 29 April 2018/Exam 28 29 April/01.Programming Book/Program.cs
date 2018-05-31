using System;
class ProgrammingBook
{
    static void Main()
    {
        double pricePage = double.Parse(Console.ReadLine());
        double priceOfCover = double.Parse(Console.ReadLine());
        int PercentReductionPrintingPaper = int.Parse(Console.ReadLine());
        double sumForPay = double.Parse(Console.ReadLine());
        int profitOfTotalSum = int.Parse(Console.ReadLine());

        int numberOfPages = 899;
        int convers = 2;

        double reduction = pricePage * numberOfPages + priceOfCover * convers;
        double profitReduction = reduction - (reduction * (PercentReductionPrintingPaper / 100.0));

        double moneyForDesigner = profitReduction + sumForPay;
        double profitTeam = moneyForDesigner - (moneyForDesigner * (profitOfTotalSum / 100.0));

        Console.WriteLine($"Avtonom should pay {profitTeam:f2} BGN.");
    }
}

