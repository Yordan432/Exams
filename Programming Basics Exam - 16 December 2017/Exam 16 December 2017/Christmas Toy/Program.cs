using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int dash = n * 2;

        Console.Write(new string('-', dash));
        Console.Write(new string('*', n));
        Console.WriteLine(new string('-', dash));
        dash -= 2;

        int stars = 1;
        int ampersand = n + 2;
        for (int i = 0; i < n / 2; i++)
        {
            Console.Write(new string('-', dash));
            Console.Write(new string('*', stars));
            Console.Write(new string('&', ampersand));
            Console.Write(new string('*', stars));
            Console.WriteLine(new string('-', dash));

            dash -= 2;
            stars++;
            ampersand += 2;
        }

        dash++;
        int tilda = n * 3 - 2;
        for (int i = 0; i < n / 2; i++)
        {
            Console.Write(new string('-', dash));
            Console.Write(new string('*', 2));
            Console.Write(new string('~', tilda));
            Console.Write(new string('*', 2));
            Console.WriteLine(new string('-', dash));

            dash--;
            tilda += 2;
        }

        dash++;
        Console.Write(new string('-', dash));
        Console.Write("*");
        Console.Write(new string('|', n * 4 - 2));
        Console.Write("*");
        Console.WriteLine(new string('-', dash));

        tilda = n * 4 - 4;
        for (int i = 0; i < n / 2; i++)
        {
            Console.Write(new string('-', dash));
            Console.Write(new string('*', 2));
            Console.Write(new string('~', tilda));
            Console.Write(new string('*', 2));
            Console.WriteLine(new string('-', dash));

            tilda -= 2;
            dash++;
        }

        stars = n / 2;
        ampersand = n * 2;
        for (int i = 0; i < n / 2; i++)
        {
            Console.Write(new string('-', dash));
            Console.Write(new string('*', stars));
            Console.Write(new string('&', ampersand));
            Console.Write(new string('*', stars));
            Console.WriteLine(new string('-', dash));

            dash+=2;
            stars--;
            ampersand -= 2;
        }

        Console.Write(new string('-', dash));
        Console.Write(new string('*', n));
        Console.WriteLine(new string('-', dash));
    }
}

