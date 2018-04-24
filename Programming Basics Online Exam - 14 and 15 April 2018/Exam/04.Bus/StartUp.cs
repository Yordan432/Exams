using System;
class StartUp
{
    static void Main()
    {
        int numberOfPerson = int.Parse(Console.ReadLine());
        int numberStop = int.Parse(Console.ReadLine());

        int checkPerson = 1;
        int totalTrainPerson = numberOfPerson;
        for (int i = 0; i < numberStop; i++)
        {
            int outBus = int.Parse(Console.ReadLine());
            int inBus = int.Parse(Console.ReadLine());

            totalTrainPerson -= outBus;
            totalTrainPerson += inBus;

            if (checkPerson % 2 == 1)
            {
                totalTrainPerson += 2;
            }
            else
            {
                totalTrainPerson -= 2;
            }
            checkPerson++;
        }
        Console.WriteLine($"The final number of passengers is : {totalTrainPerson}");
    }
}

