using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 255, b = 0255, c = 0X255;
            Console.WriteLine("{0}, {1}, {2}", a, b, c);
        }
    }
}
