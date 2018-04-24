using System;
public class StartUp
{
    public static void Main()
    {
        int numberJoinery = int.Parse(Console.ReadLine());
        string typeJoinery = Console.ReadLine();
        string wayOfReceiving = Console.ReadLine();

        double price = 0.0;
        bool isHaveWithDiscount = wayOfReceiving == "With delivery";
        if (numberJoinery <= 10)
        {
            Console.WriteLine("Invalid order");
        }
        else
        {
            double calcultePrice = 0;
            switch (typeJoinery)
            {
                case "90X130":
                    price = 110.00;
                    calcultePrice = numberJoinery * price;
                    if (numberJoinery > 60)
                    {
                        calcultePrice *= 0.92;
                    }
                    else if(numberJoinery > 30)
                    {
                        calcultePrice *= 0.95;
                    }
                    break;
                case "100X150":
                    price = 140;
                    calcultePrice = numberJoinery * price;

                    if (numberJoinery > 80)
                    {
                        calcultePrice *= 0.90;
                    }
                    else if(numberJoinery > 40)
                    {
                        calcultePrice *= 0.94;
                    }
                    break;
                case "130X180":
                    price = 190;
                    calcultePrice = price * numberJoinery;
                    if (numberJoinery >= 50)
                    {
                        calcultePrice *= 0.88;
                    }
                    else if(numberJoinery > 20)
                    {
                        calcultePrice *= 0.93;
                    }
                    break;
                case "200X300":
                    price = 250;
                    calcultePrice = price * numberJoinery;
                    if (numberJoinery > 50)
                    {
                        calcultePrice *= 0.86;
                    }
                    else if(numberJoinery > 25)
                    {
                        calcultePrice *= 0.91;
                    }
                    break;
                default:
                    break;
            }
            if (isHaveWithDiscount)
            {
                calcultePrice += 60;
            }
            if (numberJoinery >= 100)
            {
                calcultePrice *= 0.96;
            }
            Console.WriteLine($"{calcultePrice:f2} BGN");
        }
    }
}

