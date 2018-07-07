using System;
class Program
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());
        int specialNumber = int.Parse(Console.ReadLine());
        int controlNumber = int.Parse(Console.ReadLine());

        for (int i1 = firstNumber; i1 >=1; i1--)
        {
            for (int i2 = secondNumber; i2 >=1; i2--)
            {
                for (int i3 = thirdNumber; i3 >=1; i3--)
                {
                    int number = int.Parse($"{i1}{i2}{i3}");
                    int lastDigit = number % 10;
                    if (number % 3 == 0)
                    {
                        specialNumber += 5;
                    }
                    else if (lastDigit == 5)
                    {
                        specialNumber -= 2;
                    }
                    else if(number % 2 == 0)
                    {
                        specialNumber *= 2;
                    }
                    if (specialNumber >= controlNumber)
                    {
                        Console.WriteLine("Yes! Control number was reached! Current special number is {0}." ,specialNumber);
                        return;
                    }
                }
            }
        }
        if (specialNumber < controlNumber)
        {
            Console.WriteLine("No! {0} is the last reached special number.",specialNumber);
        }
    }
}

