using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_tinh_toan_tuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dodai = Tuple.Create(3.2, 30.2, 1.2);
            var cvdt = chuVidienTich(dodai);
            Console.WriteLine("Chu vi tam giac: " + cvdt.Item1);
            Console.WriteLine("Dien tich tam giac: " + cvdt.Item2);

        }
        static Tuple<double,double> chuVidienTich(Tuple<double,double,double> tamGiac)
        {
            double chieudai = tamGiac.Item1;
            double chieurong = tamGiac.Item2;
            double chieuccao = tamGiac.Item3;

            //Tinh chu vi
            double chuvi = chieudai+ chieurong + chieuccao;

            //Tinh dien tich(Cong thuc heron)
            double p = chuvi / 2;
            double dientich = Math.Sqrt(p*(p-chieudai)*(p-chieuccao)*(p-chieurong));
            return Tuple.Create(chuvi,dientich);





        }
    }
}
