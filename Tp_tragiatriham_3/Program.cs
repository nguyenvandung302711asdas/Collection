using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_tragiatriham_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mang = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var ketqua = Tinhtoanmang(mang);
            Console.WriteLine($"Gia tri lon nhat cua mang:{ketqua.Item1}");
            Console.WriteLine($"Gia tri ho nhat cua mang:{ketqua.Item2}");
            Console.WriteLine($"Gia tri trugn binh cua mang:{ketqua.Item3}");
        }
        static Tuple<double,double,double> Tinhtoanmang(int[] mang)
        {
            double Max = mang.Max();
            double Min = mang.Min();
            double TB = mang.Average();
            return new Tuple<double,double,double>(Max,Min, TB);
        }
    }
}
