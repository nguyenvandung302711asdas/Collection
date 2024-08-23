using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            //Them phan tu vao stack
            stack.Push("Dung");
            stack.Push("Van");
            stack.Push("Nguyen");
            //Kiem tra xem chieu dai cua stacck
            Console.WriteLine($"Chieu dai cua stack: {stack.Count}");
            //Kiem tra xme cac gia tri cua stack
            Console.WriteLine(stack.Peek());
            //kiem tra lai xem ham peek co xoa phan tu hay khong
            Console.WriteLine(stack.Count);
            int lenght = stack.Count;
            for(int i=0;i< lenght; i++)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}
