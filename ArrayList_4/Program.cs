using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add("NGUYEN");
            list.Add("DUNG");
            list.Add("DUNG");
            list[1] = "VAN";
            foreach(string item in list)
            {
                Console.Write(item);
            }

        }
    }
}
