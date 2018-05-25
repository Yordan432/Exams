using System;
class Program
{
    static int countSpace = 1;
    static int lastCountSpace;
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        lastCountSpace = n * 2 - 1;
        FirstUpPart(n);

        PrintSecondPartFromFrst(n);
        MiddlePart(n);

        PrintPaip();
        Console.Write(new string('P', n * 2));
        PrintSpace(n);
        PrintPaip();
        Console.Write("I");
        PrintSpace(n);
        PrintPaip();
        Console.Write("N");
        Console.Write(new string(' ', countSpace++));
        Console.Write("N");
        Console.Write(new string(' ', lastCountSpace--));
        Console.WriteLine("N");

        PrintDownPart(n);

        Console.Write("\\");
        Console.Write("_");
        int countP = n % 2 == 0 ? 1 : 2;
        Console.Write(new string('P', countP));
        // even - n * 3 - 1
        // odd  - n * 3 - 2
        int spaces = n % 2 == 0 ? n * 3 - 1 : n * 3 - 2;
        Console.Write(new string(' ', spaces));
        Console.Write("\\");
        Console.Write("_");
        Console.Write("I");
        PrintSpace(n);
        Console.Write("\\");
        Console.Write("_");
        Console.Write("N");
        PrintSpace(n * 2);
        Console.WriteLine("NN");

    }

    private static void PrintDownPart(int n)
    {
        int countP = 2;
        for (int i = 0; i < n; i++)
        {
            PrintPaip();
            if (n % 2 == 0)
            {
                countP = 1;
            }
            Console.Write(new string('P', countP));
            // even - n * 3 - 1
            // odd  - n * 3 - 2
            int countSp = n * 3 - 1;
            if (n % 2 == 1)
            {
                countSp = n * 3 - 2;
            }
            Console.Write(new string(' ', countSp));
            PrintPaip();
            Console.Write("I");
            PrintSpace(n);
            PrintPaip();
            Console.Write("N");
            PrintSpace(countSpace);
            Console.Write("N");
            PrintSpace(lastCountSpace);
            Console.WriteLine("N");
            countSpace++;
            lastCountSpace--;
        }
    }

    private static void MiddlePart(int n)
    {
        // n - 2
        for (int i = 0; i < n - 2; i++)
        {
            PrintPaip();
            Console.Write("P");
            if (IsEvenNumber(n))
            {
                PrintSpace(n);
            }
            else
            {
                PrintSpace(n * 2 - 2);
            }
            Console.Write("P");
            PrintSpace(n);
            PrintPaip();
            Console.Write("I");
            PrintSpace(n);
            PrintPaip();
            Console.Write("N");
            Console.Write(new string(' ', countSpace));
            Console.Write("N");

            if (IsEvenNumber(n))
            {
                PrintSpace(n);
            }
            else
            {
                PrintSpace(lastCountSpace);
            }
            countSpace++;
            lastCountSpace--;
            Console.WriteLine("N");
        }
    }

    private static void PrintSecondPartFromFrst(int n)
    {
        PrintPaip();
        Console.Write("P");
        if (IsEvenNumber(n))
        {
            PrintSpace(n);
        }
        else
        {
            PrintSpace(n * 2 - 2);
        }
        Console.Write("P");
        PrintSpace(n);
        PrintPaip();
        Console.Write("I");
        PrintSpace(n);
        PrintPaip();
        Console.Write("NN");
        PrintSpace(n * 2);
        Console.WriteLine("N");
    }

    private static bool IsEvenNumber(int n)
    {
        return n % 2 == 0;
    }

    private static void PrintPaip()
    {
        Console.Write("| ");
    }

    private static void FirstUpPart(int n)
    {
        SlashWithSpecialSymbol();
        Console.Write(new string('P', n * 2));
        PrintSpace(n);
        SlashWithSpecialSymbol();
        Console.Write("I");
        PrintSpace(n);
        SlashWithSpecialSymbol();
        Console.Write("N");
        Console.Write(new string(' ', n * 2 + 1));
        Console.WriteLine("N");
    }

    private static void PrintSpace(int n)
    {
        Console.Write(new string(' ', n));
    }

    private static void SlashWithSpecialSymbol()
    {
        Console.Write("/");
        Console.Write("`");
    }
}