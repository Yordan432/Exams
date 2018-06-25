using System;
class Program
{
    static void Main(string[] args)
    {
        int experience = int.Parse(Console.ReadLine());
        string specialization = Console.ReadLine();

        double monthSalary = 0;
        switch (specialization)
        {
            case "C# Developer":
                monthSalary = 5400;
                break;
            case "Java Developer":
                monthSalary = 5700;
                break;
            case "Front-End Web Developer":
                monthSalary = 4100;
                break;
            case "UX / UI Designer":
                monthSalary = 3100;
                break;
            case "Game Designer":
                monthSalary = 3600;
                break;
        }
        double yearMoney = monthSalary * 12;
        if (experience <=5)
        {
            yearMoney = yearMoney - (yearMoney * 0.658);
        }
        Console.WriteLine($"Total earned money: {yearMoney:f2} BGN");
    }
}
