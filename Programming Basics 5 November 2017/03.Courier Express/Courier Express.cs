using System;
class CourierExpress
{
    static void Main()
    {
        double weight = double.Parse(Console.ReadLine());
        string typeFavor = Console.ReadLine();
        double distanceInKillometers = double.Parse(Console.ReadLine());

        double priceKillometer = 0;
        double totalPrice = 0;
        if (typeFavor == "standard")
        {
            double gr = weight / 0.0010000;
            if (gr <=1000)
            {
                priceKillometer = 0.03;
            }
            else
            {
                priceKillometer = GetCents(weight, priceKillometer);
            }
            totalPrice = distanceInKillometers * priceKillometer;
        }
        else
        {
            double cents = GetCents(weight, priceKillometer);
            double kmToCents = distanceInKillometers * cents;
            double profit = 0;

            if (weight <=1)
            {
                profit = 0.80;
            }
            else if(weight >= 1 && weight <= 10)
            {
                profit = 0.40;
            }
            else if(weight >= 11 && weight <= 40)
            {
                profit = 0.05;
            }
            else if(weight >=41 && weight <= 90)
            {
                profit = 0.02;
            }
            else if(weight >=91 && weight <= 150)
            {
                profit = 0.01;
            }
            double overcharge = profit * cents;
            overcharge = weight* overcharge;
            overcharge = distanceInKillometers* overcharge;

            double total = kmToCents + overcharge;
            totalPrice = total;
        }
        Console.WriteLine("The delivery of your shipment with weight of {0:f3} kg. would cost {1:f2} lv.", weight, totalPrice);
    }

    private static double GetCents(double weight, double priceKillometer)
    {
        if (weight >= 1 && weight <= 10)
        {
            priceKillometer = 0.05;
        }
        else if (weight >= 11 && weight <= 40)
        {
            priceKillometer = 0.10;
        }
        else if (weight >= 41 && weight <= 90)
        {
            priceKillometer = 0.15;
        }
        else if (weight >= 91 && weight <= 150)
        {
            priceKillometer = 0.20;
        }

        return priceKillometer;
    }
}

