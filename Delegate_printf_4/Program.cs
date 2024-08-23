using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_printf_4
{
    internal class Program
    {
        delegate void PrintDelegate();

        static void printHello()
        {
            Console.WriteLine("Hello");
        }
        static void printWorld()
        {
            Console.Write("World");
        }
        static void printGoodbye()
        {
            Console.WriteLine("GoodBye");
        }

        static void Main(string[] args)
        {
            PrintDelegate printDelegate += printGoodbye + printHello + printWorld;
            

           
        }
    }
}
