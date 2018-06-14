using System;
class LettersCombinations
{
    static void Main()
    {
        char startInterval = char.Parse(Console.ReadLine());
        char endInterval = char.Parse(Console.ReadLine());
        string combinations = Console.ReadLine();

        int numberCombinations = 0;
        for (char i = startInterval; i <= endInterval; i++)
        {
            for (char j = startInterval; j <= endInterval; j++)
            {
                for (char k = startInterval; k <= endInterval; k++)
                {
                    string combination = $"{i}{j}{k}";
                    if (!combination.Contains(combinations))
                    {
                        Console.Write(combination + " ");
                        numberCombinations++;
                    }
                }
            }
        }
        Console.WriteLine(numberCombinations);
    }
}

