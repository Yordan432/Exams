using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.Write(new string('*', 1));
        Console.Write(new string('.', n));
        Console.Write(new string('*', 1));
        Console.Write(new string('.', n));
        Console.Write(new string('*', 1));
        Console.WriteLine();

        int coutPoint = n - 1;
        for (int i = 1; i <= n - 2; i++)
        {
            Console.Write(new string('.', i));
            Console.Write(new string('*', 1));
            Console.Write(new string('.', coutPoint));
            Console.Write("*");
            Console.Write(new string('.', coutPoint));
            Console.Write(new string('*', 1));
            Console.Write(new string('.', i));
            coutPoint--;
            Console.WriteLine();
        }


        Console.Write(new string('.', n - 1));
        Console.Write(new string('*', 5));
        Console.Write(new string('.', n - 1));
        Console.WriteLine();
        Console.WriteLine(new string('*', n * 2 + 3));
        Console.Write(new string('.', n - 1));
        Console.Write(new string('*', 5));
        Console.Write(new string('.', n - 1));

        Console.WriteLine();
        int pointDown = n - 2;
        int downPoint = 2;
        for (int i = 0; i < n - 1; i++)
        {
            Console.Write(new string('.' , pointDown));
            Console.Write(new string('*' , 1));

            Console.Write(new string('.' , downPoint));
            Console.Write(new string('*', 1));

            Console.Write(new string('.', downPoint));
            Console.Write(new string('*', 1));
            Console.Write(new string('.', pointDown));
            pointDown--;
            downPoint++;
            Console.WriteLine();
        }
        
        Console.WriteLine();

    }
}

