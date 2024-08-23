using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList product = new SortedList();
            product.Add("Cam", 20);
            product.Add("Tao", 10);
            product.Add("Chuoi", 25);
            product.Add("Dua", 102);
            product["Dua"] = 103;
            product.Remove("Dua");
            bool contains = product.ContainsKey("Chuoi");
            bool contains1 = product.ContainsValue("103");
            Console.WriteLine($"Contains 103:{contains1} ");
            Console.WriteLine($"Sortedlist contains: {contains}");
            product.RemoveAt(0);
            foreach(DictionaryEntry stemp in product)
            {
                Console.WriteLine($"{stemp.Key} :{stemp.Value}");
            }
        }
    }
}
