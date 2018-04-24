using System;
class StartUp
{
    static void Main()
    {
        int widthSpacePlace = int.Parse(Console.ReadLine());
        int lenghtSpacePlace = int.Parse(Console.ReadLine());
        int heightSpacePlace = int.Parse(Console.ReadLine());

        int meters = widthSpacePlace * lenghtSpacePlace * heightSpacePlace;

        int cubMeters = 0;
        while (meters >= cubMeters)
        {
            string line = Console.ReadLine();
            if (line == "Done")
            {
                break;
            }
            int numberCartons = int.Parse(line);
            cubMeters += numberCartons;
        }
        int totalMeters = meters - cubMeters;
        if (totalMeters <=0)
        {
            Console.WriteLine("No more free space! You need {0} Cubic meters more.", Math.Abs(totalMeters));
        }
        else
        {
            Console.WriteLine("{0} Cubic meters left.", totalMeters);
        }
    }
}

