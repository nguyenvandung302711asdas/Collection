using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ht_khoitao_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("Jonh", "25");
            hashtable.Add("Jane", "30");
            hashtable.Add("Tom", "35");

            hashtable.Remove("Jane");
            bool contaiTom = hashtable.ContainsKey("Tom");
            Console.WriteLine($"Hashtable contain : {contaiTom}");
            hashtable["Jonh"] = 28;
            foreach (DictionaryEntry entry in hashtable)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
        }
    }
}
