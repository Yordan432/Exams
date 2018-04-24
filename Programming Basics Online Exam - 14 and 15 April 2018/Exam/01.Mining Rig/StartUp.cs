using System;
public class StartUp
{
    public static void Main()
    {
        int priceVideoCard = int.Parse(Console.ReadLine());
        int priceAdapter = int.Parse(Console.ReadLine());

        double priceConsumedCurrentOfDay = double.Parse(Console.ReadLine());
        double profitFromCardOfDay = double.Parse(Console.ReadLine());

        double moneyBuyVideoCard = priceVideoCard * 13;
        double moneyBuyAdapter = priceAdapter * 13;

        double totalMoney = moneyBuyVideoCard + moneyBuyAdapter + 1000;

        double profit = profitFromCardOfDay - priceConsumedCurrentOfDay;
        double totalProfit = profit * 13;

        double daysBack = Math.Ceiling((totalMoney / totalProfit));

        Console.WriteLine(totalMoney);
        Console.WriteLine((int)daysBack);
    }
}

