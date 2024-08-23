using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraylist_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add("Apple");
            list.Add("Banana");
            list.Add("Cherry");
            list.RemoveAt(0);
            foreach(string item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
