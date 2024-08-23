using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //khoi tao tuple thong qua phuong thuc create
            var mytuple_1 = Tuple.Create<int, string>(1, "Dung");
            //khoi tao tuple thong qua constructor cua lop generic
            var mytuple_2 = new Tuple<int, string>(2, "Van");
            Console.WriteLine($"ID : {mytuple_1.Item1}, Name : {mytuple_1.Item2}");
            Console.WriteLine("ID : {0} , Name : {1}",mytuple_2.Item1,mytuple_2.Item2);

            //viet ham tra ve ba gia tri ngay thang nam,cua he thong
            var current = GetcurrenDayMonthYear();
            Console.WriteLine($"Ngay thang nam hien tai:{current.Item1}, {current.Item2},{current.Item3}");
            Console.WriteLine(current.ToString());
            
        }

        static Tuple<int, int, int> GetcurrenDayMonthYear()
        {
            DateTime now = DateTime.Now;
            return new Tuple<int,int,int>(now.Day,now.Month,now.Year);  
        }
    }
}
