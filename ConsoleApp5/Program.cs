using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 3.422342;
            int b = 252;
            char c = 'a';
            Console.WriteLine("변형전, 변형후");
            Console.WriteLine("{0}, {1, 5:F2}", a, a);
            Console.WriteLine("{0}, {1:E}", a, a);
            Console.WriteLine("{0},  {0:C}", b);
            Console.WriteLine("{0},  {0:X}", b);
            Console.WriteLine("{0},  {0:X}", (int)c);
        }
    }
}
