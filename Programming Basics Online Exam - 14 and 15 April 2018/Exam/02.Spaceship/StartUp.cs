using System;
public class StartUp
{
    public static void Main()
    {
        double widthShip = double.Parse(Console.ReadLine());
        double lenghtShip = double.Parse(Console.ReadLine());
        double heightShip = double.Parse(Console.ReadLine());
        double averageHeightAstronaut = double.Parse(Console.ReadLine());

        double widhtMeters = 2;
        double lenghtMeters = 2;

        double volume = widthShip * lenghtShip * heightShip;
        double volumeRoom = (averageHeightAstronaut + 0.40) * widhtMeters * lenghtMeters;

        double emptySpaceForAstronaut = Math.Floor(volume / volumeRoom);

        if (emptySpaceForAstronaut < 3)
        {
            Console.WriteLine("The spacecraft is too small.");
        }
        else if (emptySpaceForAstronaut >=3 && emptySpaceForAstronaut <=10)
        {
            Console.WriteLine("The spacecraft holds {0} astronauts.", emptySpaceForAstronaut);
        }
        else
        {
            Console.WriteLine("The spacecraft is too big.");
        }
    }
}

