using System;
public class StartUp
{
    public static void Main()
    {
        int numberOfProcessors = int.Parse(Console.ReadLine());
        int numberOfPerson = int.Parse(Console.ReadLine());
        int daysOfWorked = int.Parse(Console.ReadLine());

        int totalWokredHours = numberOfPerson * daysOfWorked * 8;
        double processingProcessors = Math.Floor(totalWokredHours / 3.0);

        double losses = Math.Abs(numberOfProcessors - processingProcessors);
        if (processingProcessors >=numberOfProcessors)
        {
            double profit = losses * 110.10;
            Console.WriteLine("Profit: -> {0:f2} BGN", profit);
        }
        else
        {
            Console.WriteLine("Losses: -> {0:f2} BGN", losses * 110.10);
        }
    }
}

