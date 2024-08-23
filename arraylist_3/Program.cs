using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraylist_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           ArrayList list = new ArrayList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            bool containthrre =  list.Contains(3);
            Console.WriteLine("Arraylist contain 3: "+ containthrre);

        }
    }
}
