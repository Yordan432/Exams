using System;
class ExternalEvaluation
{
    static void Main()
    {
        int numberOfStudents = int.Parse(Console.ReadLine());

        double poorGradesPercent = 0;
        double averageGradesPercent = 0;
        double goodGradesPercent = 0;
        double veryGoodGradesPercent = 0;
        double excellentGradesPercent = 0;
        for (int i = 0; i < numberOfStudents; i++)
        {
            double points = double.Parse(Console.ReadLine());
            if (points >= 0 && points <=22.5)
            {
                poorGradesPercent++;
            }
            else if (points > 22.5 && points <=40.5)
            {
                averageGradesPercent++;
            }
            else if (points > 40.5 && points <=58.5)
            {
                goodGradesPercent++;
            }
            else if (points > 58.5 && points <=76.5)
            {
                veryGoodGradesPercent++;
            }
            else if (points > 76.5 && points <= 100)
            {
                excellentGradesPercent++;
            }
        }
        Console.WriteLine("{0:f2}% poor marks", (poorGradesPercent / numberOfStudents) * 100);
        Console.WriteLine("{0:f2}% satisfactory marks", (averageGradesPercent / numberOfStudents) * 100);
        Console.WriteLine("{0:f2}% good marks", (goodGradesPercent / numberOfStudents) * 100);
        Console.WriteLine("{0:f2}% very good marks", (veryGoodGradesPercent / numberOfStudents) * 100);
        Console.WriteLine("{0:f2}% excellent marks", (excellentGradesPercent/numberOfStudents) * 100);
    }
}

