using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.Write("@");
        Console.Write(new string(' ', n - 2));
        Console.Write("@");
        Console.Write(new string(' ', n - 2));
        Console.WriteLine("@");

        Console.Write("**");
        Console.Write(new string(' ', n - 2 - 1));
        Console.Write("*");
        Console.Write(new string(' ', n - 2 - 1));
        Console.WriteLine("**");

        int middleCount = n / 2 - 2;

        int pointCounter = 1;
        int spaceCounter = n - 5;
        int middlePointCounter = 1;
        for (int i = 0; i < middleCount; i++)
        {
            Console.Write("*");
            Console.Write(new string('.', pointCounter));
            Console.Write("*");
            Console.Write(new string(' ', spaceCounter));
            Console.Write("*");
            Console.Write(new string('.', middlePointCounter));
            Console.Write("*");
            Console.Write(new string(' ', spaceCounter));
            Console.Write("*");
            Console.Write(new string('.', pointCounter));
            Console.WriteLine("*");

            middlePointCounter += 2;
            pointCounter++;
            spaceCounter -= 2;
        }
        int starsCounter = n % 2 == 0 ? 1 : 2;

        Console.Write("*");
        Console.Write(new string('.', pointCounter));
        Console.Write(new string('*', starsCounter));
        Console.Write(new string('.', middlePointCounter));
        Console.Write(new string('*', starsCounter));
        Console.Write(new string('.', pointCounter));
        Console.WriteLine("*");

        pointCounter++;
        int downMiddleStars = n % 2 == 0 ? (n +3) / 4 : (n - 2) / 2;
        Console.Write("*");
        Console.Write(new string('.', pointCounter));
        Console.Write(new string('*', downMiddleStars));
        Console.Write(".");
        Console.Write(new string('*', downMiddleStars));
        Console.Write(new string('.', pointCounter));
        Console.WriteLine("*");


        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine(new string('*', n * 2 - 1));
        }
    }
}
