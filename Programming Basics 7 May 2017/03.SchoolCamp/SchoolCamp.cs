using System;
class Program
{
    static void Main()
    {
        string season = Console.ReadLine();
        string typeGroup = Console.ReadLine();
        int numberOfStudents = int.Parse(Console.ReadLine());
        int numberOfNight = int.Parse(Console.ReadLine());

        double price = 0;
        if (season == "Winter")
        {
            if (typeGroup != "mixed")
            {
                price = 9.60;
            }
            else
            {
                price = 10;
            }
        }
        else if (season == "Spring")
        {
            if (typeGroup != "mixed")
            {
                price = 7.20;
            }
            else
            {
                price = 9.50;
            }
        }
        else
        {
            if (typeGroup != "mixed")
            {
                price = 15;
            }
            else
            {
                price = 20;
            }
        }
        double priceNight = numberOfStudents * price * numberOfNight;

        double discount = priceNight;
        if (numberOfStudents >= 50)
        {
            discount = priceNight - (priceNight * 0.50);
        }
        else if (numberOfStudents >= 20 && numberOfStudents < 50)
        {
            discount = priceNight - (priceNight * 0.15);
        }
        else if (numberOfStudents >= 10 && numberOfStudents < 20)
        {
            discount = priceNight - (priceNight * 0.05);
        }
        string sport = string.Empty;
        if (season == "Winter")
        {
            if (typeGroup == "girls")
            {
                sport = "Gymnastics";
            }
            else if (typeGroup == "boys")
            {
                sport = "Judo";
            }
            else
            {
                sport = "Ski";
            }
        }
        else if (season == "Spring")
        {
            if (typeGroup == "girls")
            {
                sport = "Athletics";
            }
            else if (typeGroup == "boys")
            {
                sport = "Tennis";
            }
            else
            {
                sport = "Cycling";
            }
        }
        else if (season == "Summer")
        {
            if (typeGroup == "girls")
            {
                sport = "Volleyball";
            }
            else if (typeGroup == "boys")
            {
                sport = "Football";
            }
            else
            {
                sport = "Swimming";
            }
        }
        Console.WriteLine($"{sport} {discount:f2} lv.");
    }
}
