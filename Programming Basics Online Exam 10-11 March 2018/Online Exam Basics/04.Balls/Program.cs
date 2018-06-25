using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static void Main()
    {
        int numberOfBall = int.Parse(Console.ReadLine());

        int totalBall = 0;

        int redBalls = 0;
        int orangeBalls = 0;
        int yellowBalls = 0;
        int whiteBalls = 0;
        int otherColor = 0;
        int blackBalls = 0;
        for (int i = 0; i < numberOfBall; i++)
        {
            string numbeOfColors = Console.ReadLine();

            switch (numbeOfColors)
            {
                case "red":
                    totalBall += 5;
                    redBalls++;
                    break;
                case "orange":
                    totalBall += 10;
                    orangeBalls++;
                    break;
                case "yellow":
                    totalBall += 15;
                    yellowBalls++;
                    break;
                case "white":
                    totalBall += 20;
                    whiteBalls++;
                    break;
                case "black":
                    totalBall /= 2;
                    blackBalls++;
                    break;
                default:
                    otherColor++;
                    break;
            }
        }
        Console.WriteLine("Total points: {0}", totalBall);
        Console.WriteLine("Points from red balls: {0}" , redBalls);
        Console.WriteLine("Points from orange balls: {0}" , orangeBalls);
        Console.WriteLine("Points from yellow balls: {0}" , yellowBalls);
        Console.WriteLine("Points from white balls: {0}" , whiteBalls);
        Console.WriteLine("Other colors picked: {0}" , otherColor);
        Console.WriteLine("Divides from black balls: {0}" , blackBalls);
    }
}

