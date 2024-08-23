using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_Tao_sd_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tao tuple
            var sv = Tuple.Create<string, string, int>();
            //goi ham in thong tin
            Inthongtinsinhvien(sv);

        }
        static void Inthongtinsinhvien(Tuple<string, string,int > sinhvien )
        {
            Console.WriteLine("Id : "+ sinhvien.Item1);
            sinhvien.Item1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Name : "+sinhvien.Item2);
            sinhvien.Item2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Diem trung binh : " + sinhvien.Item3);
            sinhvien.Item3 = int.Parse(Console.ReadLine());
        }
    }
}
