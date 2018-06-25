using System;
class Pets
{
    static void Main()
    {
        double countDays = double.Parse(Console.ReadLine());
        double foodkg = double.Parse(Console.ReadLine());
        double foodDogKg = double.Parse(Console.ReadLine());
        double foodCatKg = double.Parse(Console.ReadLine());
        double foodTurtleGram = double.Parse(Console.ReadLine());

        double needFoodDog = countDays * foodDogKg;
        double needFoodCat = countDays * foodCatKg;
        double needFoodTirtle = (countDays * foodTurtleGram) / 1000;

        double totalFood = needFoodDog + needFoodCat + needFoodTirtle;

        if (totalFood <=foodkg)
        {
            double residue = Math.Floor(foodkg - totalFood);
            Console.WriteLine($"{residue} kilos of food left.");
        }
        else
        {
            double residue = Math.Ceiling(totalFood - foodkg);
            Console.WriteLine($"{residue} more kilos of food are needed.");
        }
    }
}

