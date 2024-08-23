using System;

namespace Delegate_Methods_2
{
    internal class Program
    {
        
        delegate int OperationDelegate(int x, int y);

        static int Add(int x, int y)
        {
            return x + y;
        }

        static int Subtract(int x, int y)
        {
            return x - y;
        }

        static int Multiply(int x, int y)
        {
            return x * y;
        }

        static void Main(string[] args)
        {
            // Tạo các delegate riêng lẻ
            OperationDelegate add = new OperationDelegate(Add);
            OperationDelegate subtract = new OperationDelegate(Subtract);
            OperationDelegate multiply = new OperationDelegate(Multiply);

            // Thực hiện các phép toán một cách riêng lẻ
            Console.WriteLine("Add: " + add(5, 2));
            Console.WriteLine("Subtract: " + subtract(5, 2));
            Console.WriteLine("Multiply: " + multiply(5, 2));

            // Sử dụng multicast delegate, kết quả chỉ trả về từ phương thức cuối cùng
            OperationDelegate multicast = add + subtract + multiply;
            Console.WriteLine("Multicast (result from Multiply): " + multicast(5, 2));

            Console.ReadLine();
        }
    }
}
