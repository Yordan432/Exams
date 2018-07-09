using System;
class LuckyNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i1 = 1; i1 <=9; i1++)
        {
            for (int i2 = 1; i2 <=9; i2++)
            {
                for (int i3 = 1; i3 <=9; i3++)
                {
                    for (int i4 = 1; i4 <=9; i4++)
                    {
                        int leftSum = i1 + i2;
                        int rigthSum = i3 + i4;
                        if (i1 >= 1 && i1 <=9 && i2 >=1 && i2 <=9 && i3 >=1 && i3 <=9 && i4 >=1 && i4 <=9)
                        {
                            int happyNumber = int.Parse($"{i1}{i2}");
                            int divide = n % (i1 + i2);
                            if (leftSum == rigthSum && divide == 0)
                            {
                                Console.Write($"{i1}{i2}{i3}{i4} ");
                            }
                        }
                    }
                }
            }
        }
    }
}

