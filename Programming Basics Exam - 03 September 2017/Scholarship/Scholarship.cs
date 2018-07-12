using System;
class Scholarship
{
    static void Main()
    {
        double income = double.Parse(Console.ReadLine());
        double averageSuccess = double.Parse(Console.ReadLine());
        double minimalSalary = double.Parse(Console.ReadLine());

        if (averageSuccess <=4.50)
        {
            Console.WriteLine("You cannot get a scholarship!");
        }
        else if (averageSuccess > 4.50 && averageSuccess < 5.50)
        {
            if (income > minimalSalary)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else
            {
                Console.WriteLine($"You get a Social scholarship {Math.Floor(minimalSalary * 0.35)} BGN");
            }
        }
        else if(averageSuccess >= 5.50)
        {
            if (income < minimalSalary)
            {
                double excellentScholarship = Math.Floor(averageSuccess * 25);
                double socialScholarship = Math.Floor(minimalSalary * 0.35);

                if (Math.Max(excellentScholarship, socialScholarship) == excellentScholarship)
                {
                    Console.WriteLine($"You get a scholarship for excellent results {Math.Max(excellentScholarship, socialScholarship)} BGN");
                }
                else if(Math.Max(excellentScholarship, socialScholarship) == socialScholarship)
                {
                    Console.WriteLine($"You get a Social scholarship {Math.Max(excellentScholarship, socialScholarship)} BGN");
                }
            }
            else
            {
                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(averageSuccess * 25)} BGN");
            }
        }
        
    }
}

