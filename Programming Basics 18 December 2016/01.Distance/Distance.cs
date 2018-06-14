using System;
class Program
{
    static void Main()
    {
        var startSpeed = int.Parse(Console.ReadLine());
        var firstTimeInMinutes = int.Parse(Console.ReadLine());
        var secondTimeInMinutes = int.Parse(Console.ReadLine());
        var thirdTimeInMinutes = int.Parse(Console.ReadLine());

        decimal distance = startSpeed * 
            (firstTimeInMinutes * 0.016667M);

        decimal afterIncreasing = startSpeed + (startSpeed * 0.10M);
        decimal secondTimes = secondTimeInMinutes * 0.016667M;

        decimal secondTimeAfterIncreasing =
            afterIncreasing * secondTimes;

        decimal afterReduction = afterIncreasing - 
            (afterIncreasing * 0.05M);

        decimal thirdTimes = thirdTimeInMinutes * 0.016667M;
        decimal secondTimeAfterReduction = afterReduction * thirdTimes;

        decimal total = distance + secondTimeAfterIncreasing + 
            secondTimeAfterReduction;

        Console.WriteLine($"{total:f2}");
    }
}

