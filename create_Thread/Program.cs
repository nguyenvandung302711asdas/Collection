using System;
using System.Threading;

class Program
{
    // Biến đếm chung giữa các thread
    static int counter = 0;

    // Đối tượng dùng để khóa
    static readonly object lockObject = new object();

    static void Main(string[] args)
    {
        // Tạo hai thread và gán phương thức ThreadMethod cho chúng
        Thread thread1 = new Thread(ThreadMethod);
        Thread thread2 = new Thread(ThreadMethod);

        // Khởi chạy hai thread
        thread1.Start();
        thread2.Start();

        // Đợi cả hai thread hoàn thành
        thread1.Join();
        thread2.Join();

        // In ra giá trị cuối cùng của biến đếm
        Console.WriteLine($"Final counter value: {counter}");
    }

    // Phương thức được thực thi bởi các thread
    static void ThreadMethod()
    {
        for (int i = 0; i < 1000; i++)
        {
            // Khóa phần code truy cập vào biến đếm
            lock (lockObject)
            {
                counter++;
            }
        }
    }
}
