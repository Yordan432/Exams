using System;
public class StartUp
{
    public static void Main()
    {
        int budget = int.Parse(Console.ReadLine());
        int numberPhone = int.Parse(Console.ReadLine());
        string typePhone = Console.ReadLine();

        double discount = 0;
        double price = 0;
        switch (typePhone)
        {
            case "Gsm4e":
                price = 20.50;
                discount +=1;
                break;
            case "Mobifon4e":
                price = 50.75;
                discount += 2;
                break;
            case "Telefon4e":
                price = 115;
                discount += 3;
                break;
            default:
                break;
        }
        if (numberPhone > 10 && numberPhone <= 20)
        {
            discount += 2;
        }
        else if (numberPhone > 20 && numberPhone <= 50)
        {
            discount += 5;
        } 
        else if(numberPhone > 50)
        {
            discount += 7;
        }

        price = price * numberPhone;
        discount = price - (discount * price) / 100;
        if (budget >= discount)
        {
            Console.WriteLine($"The company bought all mobile phones. {budget - discount:f2} leva left.");
        }
        else
        {
            Console.WriteLine($"Not enough money for all mobiles. Company needs {Math.Abs(discount - budget):f2} more leva.");
        }
    }
}
