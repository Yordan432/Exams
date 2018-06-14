using System;
class ChangeTiles
{
    static void Main()
    {
        double collectMoney = double.Parse(Console.ReadLine());
        double widthOfFloor = double.Parse(Console.ReadLine());
        double lengthOfFloor = double.Parse(Console.ReadLine());
        double sideTriangle = double.Parse(Console.ReadLine());
        double heightTriangle = double.Parse(Console.ReadLine());
        double priceTile = double.Parse(Console.ReadLine());
        double sumOfMaster = double.Parse(Console.ReadLine());

        double areaTile = widthOfFloor * lengthOfFloor;
        double totalAreaTile = (sideTriangle * heightTriangle) / 2;
        double needTiles = Math.Ceiling(areaTile / totalAreaTile) + 5;
        double totalSum = (needTiles * priceTile) + sumOfMaster;

        if (totalSum <=collectMoney)
        {
            Console.WriteLine("{0:f2} lv left.", collectMoney - totalSum);
        }
        else
        {
            Console.WriteLine("You'll need {0:f2} lv more.", totalSum - collectMoney);
        }
    }
}

