using System;
class Program
{
    static void Main()
    {
        int numberOfDays = int.Parse(Console.ReadLine());
        int footInKillos = int.Parse(Console.ReadLine());
        double firstDeerFootKillos = double.Parse(Console.ReadLine());
        double secondDeerFootKillos = double.Parse(Console.ReadLine());
        double thirdDeerFootKillos = double.Parse(Console.ReadLine());

        double firstDeerKillos = numberOfDays * firstDeerFootKillos;
        double secondDeerKillos = numberOfDays * secondDeerFootKillos;
        double thirdDeerKillos = numberOfDays * thirdDeerFootKillos;

        double totalFood = firstDeerKillos + secondDeerKillos + thirdDeerKillos;

        if (totalFood <=footInKillos)
        {
            Console.WriteLine("{0} kilos of food left.", 
                footInKillos - totalFood);
        }
        else
        {
            Console.WriteLine("{0} more kilos of food are needed.", 
                Math.Ceiling(totalFood - footInKillos));
        }

    }
}

