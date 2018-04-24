using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 2 * n + 1;
            int height = 8 * n - 8;

            if (n==3)
            {
                Console.WriteLine("  _|_");
                Console.WriteLine(" _|-|_");
                Console.WriteLine(" |***|");
            }
            else
            {
                for (int i = 0; i < n - 3; i++)
                {
                    Console.WriteLine("{0}|", new string(' ', n));
                }
                Console.WriteLine("{0}_|_", new string(' ', n-1));
                for (int i = 0; i < n-3; i++)
                {
                    Console.WriteLine("{0}|-|", new string(' ', n-1));
                }
                Console.WriteLine("{0}_|-|_", new string(' ', n-2));
                for (int i = 0; i < n-3; i++)
                {
                    Console.WriteLine("{0}|***|", new string(' ', n-2));
                }
                Console.WriteLine(" {0}|***|{0}", new string('_', (width-7)/2));

            }
            for (int i = 0; i < height-(3*(n-3)+4+n-2); i++)
            {
                Console.WriteLine(" {0}---{0}", new string('|', n-2));
            }
            Console.WriteLine("_{0}---{0}_", new string('|', n-2));
            for (int i = 0; i < n-2; i++)
            {
                Console.WriteLine($"{new string('|', width)}");
            }
        }
    }
}