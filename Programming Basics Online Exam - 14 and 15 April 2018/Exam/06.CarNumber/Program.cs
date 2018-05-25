using System;
class Program
{
    static void Main()
    {
        int startInterval = int.Parse(Console.ReadLine());
        int endInterval = int.Parse(Console.ReadLine());

        for (int first = startInterval; first <=endInterval; first++)
        {
            for (int second = startInterval; second <=endInterval; second++)
            {
                for (int third = startInterval; third <=endInterval; third++)
                {
                    for (int fourty = startInterval; fourty <=endInterval; fourty++)
                    {
                        bool firstStatment = (first % 2 == 0 && fourty % 2 == 1)
                            || fourty % 2 == 0 && first % 2 == 1;
                        bool firstBiggerFourty = first > fourty;
                        bool evenSumSecondThird = (second + third) % 2 == 0;

                        if (firstStatment && firstBiggerFourty && evenSumSecondThird)
                        {
                            Console.Write("{0}{1}{2}{3} " , first, second, third, fourty);
                        }
                    }
                }
            }
        }
        Console.WriteLine();
    }
}

