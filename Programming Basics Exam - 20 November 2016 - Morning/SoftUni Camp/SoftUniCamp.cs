using System;
class SoftUniCamp
{
    static void Main()
    {
        int countGroupStudents = int.Parse(Console.ReadLine());

        double car = 0;
        double minibus = 0;
        double smallMinibus = 0;
        double bigMinibus = 0;
        double train = 0;

        double totalSum = 0;
        for (int i = 0; i < countGroupStudents; i++)
        {
            int n = int.Parse(Console.ReadLine());
            if (n <= 5)
            {
                car += n;
            }
            else if(n > 5 && n <= 12)
            {
                minibus += n;
            }
            else if(n > 12 && n <= 25)
            {
                smallMinibus += n;
            }
            else if(n > 25 && n <= 40)
            {
                bigMinibus += n;
            }
            else if(n > 40)
            {
                train += n;
            }
            totalSum += n;
        }
        Console.WriteLine("{0:f2}%" ,(car / totalSum) * 100);
        Console.WriteLine("{0:f2}%" ,(minibus / totalSum) * 100);
        Console.WriteLine("{0:f2}%" , (smallMinibus / totalSum) * 100);
        Console.WriteLine("{0:f2}%" , (bigMinibus / totalSum) * 100);
        Console.WriteLine("{0:f2}%" , (train / totalSum) * 100);

    }
}

