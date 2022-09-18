using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("press key Esc is exit");
                ConsoleKeyInfo keyname = Console.ReadKey();
                Console.WriteLine("\n key name = "+ keyname.Key);
                if (keyname.Key == ConsoleKey.Escape) { break; }
            }
        }
    }
}
