using System;
class ChristmasHat
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int numberOfPoint = n + n - 1;
        Console.Write(new string('.', numberOfPoint));
        Console.Write("/");
        Console.Write("|");
        Console.Write("\\");
        Console.WriteLine(new string('.', numberOfPoint));

        Console.Write(new string('.', numberOfPoint));
        Console.Write("\\");
        Console.Write("|");
        Console.Write("/");
        Console.WriteLine(new string('.', numberOfPoint));

        Console.Write(new string('.', numberOfPoint));
        Console.Write("***");
        Console.WriteLine(new string('.', numberOfPoint));

        numberOfPoint--;
        int numberOfDashes = 1;
        for (int i = 0; i < n + n - 1; i++)
        {
            Console.Write(new string('.', numberOfPoint));
            Console.Write("*");
            Console.Write(new string('-', numberOfDashes));
            Console.Write("*");
            Console.Write(new string('-', numberOfDashes));
            Console.Write("*");
            Console.WriteLine(new string('.', numberOfPoint));
            numberOfPoint--;
            numberOfDashes++;
        }
        Console.WriteLine(new string('*', n * 4 + 1));

        for (int i = 0; i < n * 4 + 1; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(".");
            }
        }
        Console.WriteLine();
        Console.WriteLine(new string('*', n * 4 + 1));

    }
}
