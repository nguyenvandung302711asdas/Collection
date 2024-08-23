using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    internal class Program
    {
        static void Swap<T>(ref T a,ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {
            int a = 4;
            int b =6;
            Console.WriteLine($"a = {a} , b = {b}");
            Swap<int>(ref a,ref b);
            double c = 5.3;
            double d = 6.5;
            Console.WriteLine($"c = {c} , d = {d}");
            Swap<double>(ref c, ref d);
            Console.WriteLine($"c = {c} , d = {d}");
            Console.WriteLine($"a = {a} , b = {b}");

            MyGenericc<int> my = new MyGenericc<int>(5);
            my.setIntems(0, 20);
            my.setIntems(1, 32);
            Console.WriteLine(my.getIndex(0));
            Console.WriteLine(my.getIndex(1));
        }
    }
}
