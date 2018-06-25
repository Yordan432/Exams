using System;
public class Program
{
    public static void Main()
    {
        int widthOfHole = int.Parse(Console.ReadLine());
        int lenghtOfHole = int.Parse(Console.ReadLine());
        int sideOfPicture = int.Parse(Console.ReadLine());
        int numberOfPicture = int.Parse(Console.ReadLine());

        double areaHole = widthOfHole * lenghtOfHole;
        double areaPicture = (sideOfPicture * sideOfPicture) * numberOfPicture;

        if (areaPicture > areaHole)
        {
            Console.WriteLine("The pictures don't fit in the hole. Picture area is {0} bigger than hole area.", Math.Abs(areaHole - areaPicture));
        }
        else
        {
            Console.WriteLine("The pictures fit in the hole. Hole area is {0} bigger than pictures area.", areaHole - areaPicture);
        }
    }
}

