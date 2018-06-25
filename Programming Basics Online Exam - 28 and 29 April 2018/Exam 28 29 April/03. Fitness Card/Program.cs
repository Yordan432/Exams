using System;
class Program
{
    static void Main()
    {
        var sum = double.Parse(Console.ReadLine());
        var gener = char.Parse(Console.ReadLine());
        var age = int.Parse(Console.ReadLine());
        var sport = Console.ReadLine();

        double price = 0.0;
        if (sport == "Gym")
        {
            if (gener == 'm')
            {
                price = 42;
            }
            else
            {
                price = 35;
            }
        }
        else if (sport == "Boxing")
        {
            if (gener == 'm')
            {
                price = 41;
            }
            else
            {
                price = 37;
            }
        }
        else if(sport == "Yoga")
        {
            if (gener == 'm')
            {
                price = 45;
            }
            else
            {
                price = 42;
            }
        }
        else if(sport == "Zumba")
        {
            if (gener == 'm')
            {
                price = 34;
            }
            else
            {
                price = 31;
            }
        }
        else if(sport == "Dances")
        {
            if (gener == 'm')
            {
                price = 51;
            }
            else
            {
                price = 53;
            }
        }
        else if(sport == "Pilates")
        {
            if (gener == 'm')
            {
                price = 39;
            }
            else
            {
                price = 37;
            }
        }
        if (age <= 19)
        {
            price = price - (price * 0.2);
        }

        if (sum < price)
        {
            Console.
                WriteLine
                ("You don't have enough money! You need ${0:f2} more.", Math.Abs(sum - price));
        }
        else
        {
            Console.WriteLine($"You purchased a 1 month pass for {sport}.");
        }
    }
}

