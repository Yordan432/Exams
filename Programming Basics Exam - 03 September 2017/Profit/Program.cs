using System;
class Profit
{
    static void Main()
    {
        int cost1 = int.Parse(Console.ReadLine());
        int cost2 = int.Parse(Console.ReadLine());
        int cost5 = int.Parse(Console.ReadLine());
        int sum = int.Parse(Console.ReadLine());

        for (int i1 = 0; i1 <=cost1; i1++)
        {
            for (int i2 = 0; i2 <=cost2; i2++)
            {
                for (int i3 =0; i3 <=cost5; i3++)
                {
                    if (i1 * 1 + i2 * 2 + i3 * 5 == sum)
                    {
                        Console.WriteLine("{0} * {1} lv. + {2} * {3} lv. + {4} * {5} lv. = {6} lv.", i1, 1, i2, 2,i3 , 5,sum);
                    }
                }
            }
        }
    }
}

