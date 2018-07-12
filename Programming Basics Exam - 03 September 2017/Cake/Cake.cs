using System;
class Cake
{
    static void Main()
    {
        int widthCake = int.Parse(Console.ReadLine());
        int lengthCake = int.Parse(Console.ReadLine());

        int pieces = widthCake * lengthCake;
        while (pieces >=0) 
        {
            string piece = Console.ReadLine();
            int pieceNumber;
            bool hasPieceNum = int.TryParse(piece, out pieceNumber);
            if (hasPieceNum)
            {
                pieces -= pieceNumber;
            }
            else
            {
                break;
            }
        }
        if (pieces <0)
        {
            Console.WriteLine($"No more cake left! You need {Math.Abs(pieces)} pieces more.");
        }
        else
        {
            Console.WriteLine($"{pieces} pieces are left.");
        }
    }
}

