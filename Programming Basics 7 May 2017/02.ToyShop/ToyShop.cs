using System;
class ToyShop
{
    static void Main()
    {
        double priceTour = double.Parse(Console.ReadLine());
        int numberPuzzle = int.Parse(Console.ReadLine());
        int numberTalkingDolls = int.Parse(Console.ReadLine());
        int numberTeddyBears = int.Parse(Console.ReadLine());
        int numberMinions = int.Parse(Console.ReadLine());
        int numberTrucks = int.Parse(Console.ReadLine());

        double pricePuzzle = 2.60;
        double priceTalkingDoll = 3.00;
        double priceTeddyBear = 4.10;
        double priceMinion = 8.20;
        double priceTruck = 2.00;

        double sum = numberPuzzle * pricePuzzle + numberTalkingDolls * priceTalkingDoll
            + numberTeddyBears * priceTeddyBear + numberMinions * priceMinion
            + numberTrucks * priceTruck;

        int numberToys = numberPuzzle + numberTalkingDolls + numberTeddyBears
            + numberMinions + numberTrucks;

        if (numberToys >= 50)
        {
            double price = 0.25 * sum;
            sum -= price;
        }
        sum = sum - (sum * 0.10);

        if (sum >=priceTour)
        {
            sum -= priceTour;
            Console.WriteLine("Yes! {0:f2} lv left.", sum);
        }
        else
        {
            Console.WriteLine("Not enough money! {0:f2} lv needed.", priceTour - sum);
        }
    }
}
