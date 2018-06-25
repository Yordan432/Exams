using System;
public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int countSpace = n - 2;
        int countSpaceMid = 0;
        FirstPart(n, ref countSpace, ref countSpaceMid);


        Console.WriteLine(new string('-', n * 2 + 2));

        Console.Write("|");
        Console.Write(new string(' ', n / 3));
        Console.Write("_");
        Console.Write(new string(' ', n + 1));
        Console.Write("_");
        Console.Write(new string(' ', n / 3));
        Console.WriteLine("|");

        double midPart = Math.Ceiling(n / 2.0);

        int countSpaceMiddle = n / 3;

        Console.Write("|");
        Console.Write(new string(' ', countSpaceMiddle));
        Console.Write("@");
        Console.Write(new string(' ', n + 1));
        Console.Write("@");
        Console.Write(new string(' ', countSpaceMiddle));
        Console.WriteLine("|");

        for (int i = 0; i < ((n + 1) / 2) - 1; i++)
        {
            Console.Write("|");
            Console.Write(new string(' ' , n * 2));
            Console.WriteLine("|");
        }

        Console.Write("|");
        Console.Write(new string(' ' ,n- 1));
        Console.Write("OO");
        Console.Write(new string(' ', n - 1));
        Console.WriteLine("|");


        Console.Write("|");
        Console.Write(new string(' ', n - 2));
        Console.Write("/");
        Console.Write(new string(' ' , 2));
        Console.Write("\\");
        Console.Write(new string(' ', n - 2));
        Console.WriteLine("|");

        Console.Write("|");
        Console.Write(new string(' ', n - 2));
        Console.Write(new string('|' , 4));
        Console.Write(new string(' ', n - 2));
        Console.WriteLine("|");

        int inclined = 1;
        int tilda = n * 2;
        for (int i = 0; i < n + 1; i++)
        {
            Console.Write(new string('\\' , inclined));
            Console.Write(new string('`' , tilda));
            Console.WriteLine(new string('/' , inclined));
            inclined++;
            tilda -= 2;
        }


    }

    private static void FirstPart(int n, ref int countSpace, ref int countSpaceMid)
    {
        for (int i = 0; i < n - 1; i++)
        {
            Console.Write(new string(' ', countSpace));
            Console.Write("/");
            Console.Write(new string(' ', countSpaceMid));
            Console.Write("|");
            Console.Write(new string(' ', 2));
            Console.Write("|");
            Console.Write(new string(' ', countSpaceMid));
            Console.Write("\\");

            countSpaceMid++;
            countSpace--;
            Console.WriteLine();
        }
    }
}
