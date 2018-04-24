using System;
class StartUp
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());

        int count = size;
        for (int i = 0; i < size / 4; i++)
        {
            Console.Write(new string(' ', size));
            Console.WriteLine("|");
        }
        Console.Write(new string(' ', size - 1));
        Console.Write("_");
        Console.Write("|");
        Console.WriteLine("_");

        int specialRow = 1;
        for (int i = 0; i < size / 4; i++)
        {
            Console.Write(new string(' ', size - 1));
            Console.Write("|");
            Console.Write("-");
            Console.WriteLine("|");
        }
        Console.Write(new string(' ', size -2));
        Console.Write("_");
        Console.Write("|");
        Console.Write("-");
        Console.Write("|");
        Console.WriteLine("_");

        for (int i = 0; i < size / 4; i++)
        {
            Console.Write(new string(' ', size - 2));
            Console.Write("|");
            Console.Write(new string('*', 3));
            Console.WriteLine("|");
        }
        Console.Write(new string(' ', size - 3));
        Console.Write("_");
        Console.Write("|");
        Console.Write(new string('*', 3));
        Console.Write("|");
        Console.WriteLine("_");
    }
}

