using System;
class Program
{
    static void Main()
    {

        var numberOfCourses = int.Parse(Console.ReadLine());

        double sum = 0.0;
        double totalCredits = 0;
        for (int i = 0; i < numberOfCourses; i++)
        {
            int infoForStudent = int.Parse(Console.ReadLine());
            int grade = infoForStudent % 10;
            sum += grade;
            infoForStudent /= 10;
            var credit = (double)infoForStudent;
            switch (grade)
            {
                case 2:
                    credit = 0;
                    break;
                case 3:
                    credit = credit / 2;
                    break;
                case 4:
                    credit = credit * 0.7;
                    break;
                case 5:
                    credit = credit * 0.85;
                    break;
            }
            totalCredits += credit;
        }
        Console.WriteLine($"{totalCredits:f2}");
        Console.WriteLine($"{sum / numberOfCourses:f2}");
    }
}

