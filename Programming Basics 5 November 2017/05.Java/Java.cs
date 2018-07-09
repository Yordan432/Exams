using System;
class Java
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write(new string(' ', n));
            Console.WriteLine("~ ~ ~");
        }
        Console.WriteLine(new string('=',n * 3 + 6 - 1));
        for (int i = 0; i < n / 2 - 1; i++)
        {
            Console.Write("|");
            Console.Write(new string('~', n * 2 + 4));
            Console.Write("|");
            Console.Write(new string(' ', n - 1));
            Console.WriteLine("|");
        }
        // ((n * 2) / 5) - 1
        Console.Write("|");
        Console.Write(new string('~', n));
        Console.Write("JAVA");
        Console.Write(new string('~', n));
        Console.Write("|");
        Console.Write(new string(' ', n - 1));
        Console.WriteLine("|");

        int middle = ((n * 2) / 5) - 1;
        for (int i = 0; i < middle; i++)
        {
            Console.Write("|");
            Console.Write(new string('~', n * 2 + 4));
            Console.Write("|");
            Console.Write(new string(' ', n - 1));
            Console.WriteLine("|");
        }
        Console.WriteLine(new string('=', n * 3 + 6 - 1));

        int countSpace = 0;
        int symbol = n * 2 + 4;
        for (int i = 0; i < n; i++)
        {
            Console.Write(new string(' ', countSpace));
            Console.Write("\\");
            Console.Write(new string('@', symbol));
            Console.WriteLine("/");

            countSpace++;
            symbol -= 2;
        }
        // n * 2 + 6
        Console.WriteLine(new string('=', n *2+6));
    }
}

