using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Thread_vd
{
    internal class Program
    {
        static void Main(string[] args)
        {
           for(int i = 0;i<5;i++)
            {
                int value = i;
                Thread t = new Thread(() =>
                {
                    DemoThread("Thread " + value);
                });
                t.Start();
            }
        }
        static void DemoThread(String Threadindex)
        {
            for(int i = 0; i < 5; i++)
            {
                //Ham ngủ theo thời gian
               //Thread.Sleep(TimeSpan.FromSeconds(1));
                Console.WriteLine(Threadindex +"_"+ i);
            }
        }
    }
}
