using System;
class Program
{
    static void Main()
    {
        int firstNumberA = int.Parse(Console.ReadLine());
        char letterB = char.Parse(Console.ReadLine());
        char letterC = char.Parse(Console.ReadLine());
        int secondNumberD = int.Parse(Console.ReadLine());
        int thirdNumberE = int.Parse(Console.ReadLine());
        int fourtyNumberF = int.Parse(Console.ReadLine());
        int fiftyNumberN = int.Parse(Console.ReadLine());

        int counter = 0;
        bool isGeneretePassword = false;
        for (int first = 1; first <=firstNumberA; first++)
        {
            for (int second = 'A'; second <=letterB; second++)
            {
                for (int third = 'a'; third <=letterC; third++)
                {
                    for (int fourty = 1; fourty <=secondNumberD; fourty++)
                    {
                        for (int fifty = 1; fifty <=thirdNumberE; fifty++)
                        {
                            for (int sixty = 1; sixty <=fourtyNumberF; sixty++)
                            {
                                counter++;
                                if (counter == fiftyNumberN)
                                {
                                    Console.WriteLine("{0}{1}{2}{3}{4}{5}", first, (char)second, 
                                        (char)third,
                                        fourty, fifty, sixty);
                                    isGeneretePassword = true;
                                    return;
                                }
                            }
                        }
                    }
                }
            }
            if (!isGeneretePassword && counter < fiftyNumberN)
            {
                Console.WriteLine("No password on this position");
            }
        }
    }
}

