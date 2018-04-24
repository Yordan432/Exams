using System;
class StartUp
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());

        int countSpace = size;
        int count = size;
        for (int i = 0; i < size / 4; i++)
        {
            Console.Write(new string(' ', countSpace));
            Console.WriteLine("|");
        }
        countSpace--;
        Console.Write(new string(' ', size - 1));
        Console.Write("_");
        Console.Write("|");
        Console.WriteLine("_");
        
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
        countSpace--;
        if (size % 2 == 0)
        {
            Console.Write(new string(' ', size - 3));
            Console.Write("_");
            Console.Write("|");
            Console.Write(new string('*', 3));
            Console.Write("|");
            Console.WriteLine("_");
            countSpace--;
        }
        else
        {
            Console.Write(new string(' ', size - 2));
            Console.Write("|");
            Console.Write(new string('*', 3));
            Console.WriteLine("|");
        }
        // n * 2 - 1
        string isEvenNumber = size % 2 == 0 ? "|" : "";
        for (int i = 0; i < size * 4 - 1; i++)
        {
            Console.Write(new string(' ', countSpace));
            Console.Write(isEvenNumber);
            Console.Write("|");
            Console.Write(new string('-' , 3));
            Console.Write("|");
            Console.WriteLine(isEvenNumber); 
        }
        Console.Write(new string(' ', countSpace - 1));
        Console.Write("_");
        Console.Write(isEvenNumber);
        Console.Write("|");
        Console.Write(new string('-', 3));
        Console.Write("|");
        Console.Write(isEvenNumber);
        Console.WriteLine("_");

        for (int i = 0; i < size - 2; i++)
        {
            Console.WriteLine(new string('|' , size * 2 + 1));
        }
    }
}
