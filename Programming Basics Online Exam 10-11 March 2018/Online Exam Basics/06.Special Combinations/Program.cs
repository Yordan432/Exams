using System;
public class Program
{
    public static void Main()
    {
        int upperHundred = int.Parse(Console.ReadLine());
        int upperTens = int.Parse(Console.ReadLine());
        int upperUnits = int.Parse(Console.ReadLine());

        for (int first = 2; first <=upperHundred; first++)
        {
            for (int second = 2; second <=upperTens; second++)
            {
                for (int third = 2; third <=upperUnits; third++)
                {
                    if (first % 2 == 0 && third % 2 == 0 && second >=2 && IsPrimeRange(second))
                    {
                        Console.WriteLine("{0} {1} {2}" , first, second,third);
                    }
                }
            }
        }

    }

    private static bool IsPrimeRange(int second)
    {
        bool isPrime = true;
        for (int i = 2; i <=second - 1; i++)
        {
            if (second % i == 0)
            {
                isPrime = false;
                break;
            }
        }
        return isPrime;
    }
}

