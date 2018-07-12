using System;
class Program
{
    static void Main()
    {
        string startBarcode = Console.ReadLine();
        string endBarcode = Console.ReadLine();

        int firstDigitStart = startBarcode[0] - '0';
        int secondDigitStart = startBarcode[1] - '0';
        int thirdDigitStart = startBarcode[2] - '0';
        int fourtyDigitStart = startBarcode[3] - '0';

        int firstDigitEnd = endBarcode[0] - '0';
        int secondDigitEnd = endBarcode[1] - '0';
        int thirdDigitEnd = endBarcode[2] - '0';
        int fourtyDigitEnd = endBarcode[3] - '0';

        for (int i1 = firstDigitStart; i1 <=firstDigitEnd; i1++)
        {
            for (int i2 = secondDigitStart; i2 <=secondDigitEnd; i2++)
            {
                for (int i3 = thirdDigitStart; i3 <=thirdDigitEnd; i3++)
                {
                    for (int i4 = fourtyDigitStart; i4 <=fourtyDigitEnd; i4++)
                    {
                        if (i1 % 2 != 0 && i2 % 2 != 0 && i3 % 2 != 0 && i4 % 2 != 0)
                        {
                            Console.Write($"{i1}{i2}{i3}{i4} ");
                        }
                    }
                }
            }
        }
    }
}

