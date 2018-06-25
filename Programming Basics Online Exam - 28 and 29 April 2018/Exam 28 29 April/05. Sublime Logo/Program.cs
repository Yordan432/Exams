using System;
class Program
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());

        int sizeAsteriks = 2;
        int numberOfSpaces = size * 2 - 2;
        for (int i = 0; i < size; i++)
        {
            Console.Write(new string(' ', numberOfSpaces));
            Console.WriteLine(new string('*', sizeAsteriks));
            numberOfSpaces -= 2;
            sizeAsteriks += 2;
        }
    }
}

