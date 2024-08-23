using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_sum_1
{
    internal class Program
    {
        delegate int SumDelegate(int x ,int y);
        static int Add(int x,int y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            SumDelegate Sum = new SumDelegate(Add);
            Console.WriteLine(Sum(2,3));
            
        }
    }
}
