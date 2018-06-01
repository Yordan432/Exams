using System;
class Program
{
    static void Main()
    {
        char gender = char.Parse(Console.ReadLine());
        double widthInKillos = double.Parse(Console.ReadLine());
        double heightInMeters = double.Parse(Console.ReadLine());
        int age = int.Parse(Console.ReadLine());
        string physicalActivity = Console.ReadLine();

        double convertMetersInCentimetrs = heightInMeters / 0.010000;
        double typeCoeficent = GetCoeficentForMan(physicalActivity);
        if (gender == 'm')
        {
            double width = 66 + (13.7 * widthInKillos) + (5 * convertMetersInCentimetrs)
                - (6.8 * age);

            double result = width * typeCoeficent;

            Console.WriteLine($"To maintain your current weight you will need {Math.Ceiling(result)} calories per day.");
        }
        else
        {
            double width = 655 + (9.6 * widthInKillos) + (1.8 * convertMetersInCentimetrs)
                - (4.7 * age);
            double result = width * typeCoeficent;
            Console.WriteLine($"To maintain your current weight you will need {Math.Ceiling(result)} calories per day.");
        }
    }

    private static double GetCoeficentForMan(string physicalActivity)
    {
        switch (physicalActivity)
        {
            case "sedentary":
                return 1.2;
             case "lightly active":
                return 1.375;
            case "moderately active":
                return 1.55;
            case "very active":
                return 1.725;
            default:
                return 0;
        }
    }
}

