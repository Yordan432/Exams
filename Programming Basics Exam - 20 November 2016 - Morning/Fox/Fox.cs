using System;
class Fox
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int firstPart = (2 * n + 3) - 4;
        Console.Write(new string('*' , 1));
        Console.Write("\\");
        Console.Write(new string('-' , firstPart));
        Console.Write("/");
        Console.Write(new string('*', 1));
        Console.WriteLine();

        int dash = firstPart - 0;
        for (int i = 2; i <=n; i++)
        {
            Console.Write(new string('*' , i));
            Console.Write("\\");         
            Console.Write(new string('-' , dash - 2));
            Console.Write("/");
            Console.Write(new string('*', i));
            Console.WriteLine();
            dash -= 2;
        }
        int asterisksFirst = n;
        int asterisksSecond = n / 2;
        for (int i = 0; i < n / 3; i++)
        {
            Console.Write(new string('|' , 1));
            Console.Write(new string('*' , asterisksSecond));
            Console.Write("\\");
            Console.Write(new string('*' , asterisksFirst));
            Console.Write("/");
            Console.Write(new string('*', asterisksSecond));
            Console.Write(new string('|', 1));
            Console.WriteLine();
            asterisksFirst -= 2;
            asterisksSecond++;
        }
        for (int i = 1; i <=n; i++)
        {
            Console.Write(new string('-' , i));
            Console.Write("\\");
            Console.Write(new string('*' , firstPart));
            Console.Write("/");
            Console.Write(new string('-', i));
            firstPart-=2;
            Console.WriteLine();
        }
        Console.WriteLine();
		COnsole.ReadLine();
    }
}

