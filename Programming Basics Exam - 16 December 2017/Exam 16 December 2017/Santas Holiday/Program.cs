using System;
class Program
{
    static void Main()
    {
        int daysStay = int.Parse(Console.ReadLine());
        string room = Console.ReadLine();
        string grade = Console.ReadLine();

        double price = 0;

        if (room == "room for one person")
        {
            price = 18.00;
        }
        else if(room == "apartment")
        {
            price = 25.00;
        }
        else
        {
            price = 35.00;
        }
        double percentage = 0;
        if (room == "apartment")
        {
            if (daysStay < 10)
            {
                percentage = 0.30;
            }
            else if(daysStay > 10 && daysStay < 15)
            {
                percentage = 0.35;
            }
            else
            {
                percentage = 0.50;
            }
        }
        else if(room == "president apartment")
        {
            if (daysStay < 10)
            {
                percentage = 0.10;
            }
            else if (daysStay > 10 && daysStay < 15)
            {
                percentage = 0.15;
            }
            else
            {
                percentage = 0.20;
            }
        }
        double nights = (daysStay - 1) * price;
        double percentagePrice = nights - (nights * percentage);

        if (grade == "positive")
        {
            percentagePrice += percentagePrice * 0.25;
        }
        else
        {
            percentagePrice -= percentagePrice * 0.10;
        }
        Console.WriteLine("{0:f2}", percentagePrice);
    }
}

