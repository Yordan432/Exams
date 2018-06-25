using System;
class Battles
{
    static void Main()
    {
        int firstPlayer = int.Parse(Console.ReadLine());
        int secondPlayer = int.Parse(Console.ReadLine());
        int maxBattle = int.Parse(Console.ReadLine());

        int count = 1;
        for (int player1 = 1; player1 <=secondPlayer; player1++)
        {
            for (int player2 = 1; player2 <=secondPlayer; player2++)
            {
                Console.Write($"({player1} <-> {player2}) ");
                if (count == maxBattle)
                {
                    return;
                }
                count++;
            }
            
        }
        Console.WriteLine();
    }
}

