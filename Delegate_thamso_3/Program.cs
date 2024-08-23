using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_thamso_3
{
    internal class Program
    {
        delegate bool CompareDelegate(int a,int b);

        static bool IsGreater(int x,int y)
        {
            return (x > y);
        }

        static bool IsLess(int x,int y)
        {
            return (x < y);
        }

        static bool Compare(int x,int y,CompareDelegate compare)
        {
            return compare(x,y);
        }
        
        static void Main(string[] args)
        {

            int a = 1;
            int b = 2;
            bool result = Compare(a, b, IsGreater);
            Console.WriteLine("Ket qua cua a>b "+result);
            bool result1 = Compare(a, b, IsLess);
            Console.WriteLine("Ket qua cua a<b " + result1);
        }
    }
}
