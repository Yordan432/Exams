using System;
class Grades
{
    static void Main()
    {
        double numberOfStudents = double.Parse(Console.ReadLine());

        double numberOfStudentsEvaluationCouple = 0;
        double numberOfStudentsMidleCouple = 0;
        double numberOfStudentsGoodCouple = 0;
        double numberOfStudentsExcellentCouple = 0;
        double average = 0;
        for (int i = 0; i < numberOfStudents; i++)
        {
            double gradeOfExam = double.Parse(Console.ReadLine());
            average += gradeOfExam;
            if (gradeOfExam >= 2.00 && gradeOfExam <= 2.99)
            {
                numberOfStudentsEvaluationCouple++;
            }
            else if (gradeOfExam >= 3.00 && gradeOfExam <= 3.99)
            {
                numberOfStudentsMidleCouple++;
            }
            else if (gradeOfExam >= 4.00 && gradeOfExam <= 4.99)
            {
                numberOfStudentsGoodCouple++;
            }
            else if(gradeOfExam >=5.00)
            {
                numberOfStudentsExcellentCouple++;
            }
        }
        Console.WriteLine($"Top students: {numberOfStudentsExcellentCouple / numberOfStudents * 100.00:f2}%");
        Console.WriteLine($"Between 4.00 and 4.99: {numberOfStudentsGoodCouple / numberOfStudents * 100.00:f2}%");
        Console.WriteLine($"Between 3.00 and 3.99: {numberOfStudentsMidleCouple / numberOfStudents * 100.00:f2}%"); // 2
        Console.WriteLine($"Fail: {numberOfStudentsEvaluationCouple / numberOfStudents * 100.00:f2}%");
        Console.WriteLine($"Average: {average / numberOfStudents:f2}");
        
    }
}

