using System;
public class Program
{
    public static void Main()
    {
        char firstSymbol = char.Parse(Console.ReadLine());
        int firstNumberOfChangeCode = int.Parse(Console.ReadLine());
        char secondSymbol = char.Parse(Console.ReadLine());
        int secondNumberOfChangeCode = int.Parse(Console.ReadLine());
        char thirdSymbol = char.Parse(Console.ReadLine());
        int thirdNumberOfChangeCode = int.Parse(Console.ReadLine());

        string result = string.Empty;

        var firstSum = firstSymbol + firstNumberOfChangeCode;
        char resultSymbol = (char)firstSum;
        result += resultSymbol.ToString();

        var secondSum = secondSymbol + secondNumberOfChangeCode;
        resultSymbol = (char)secondSum;
        result += resultSymbol.ToString();

        var thirdSum = thirdSymbol + thirdNumberOfChangeCode;
        resultSymbol = (char)thirdSum;

        result += resultSymbol.ToString();

        if (result == "@@@")
        {
            Console.WriteLine(result);
            Console.WriteLine("!!! YOU LOSE EVERYTHING !!!");
        }
        else if(result == "777")
        {
            Console.WriteLine(result);
            Console.WriteLine("*** JACKPOT ***");
        }
        else
        {
            Console.WriteLine(result);
        }
    }
}
