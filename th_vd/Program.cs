using System;
using System.Threading;

namespace th_vd
{
    internal class Program
    {
        // Khởi tạo dữ liệu
        static int shareData = 0;

        // Tạo đối tượng khóa
        static readonly object lockObject = new object();

        // Tạo cờ
        static bool isDataAvailable = false;

        static void Main(string[] args)
        {
            Thread producer = new Thread(Producer);
            Thread consumer = new Thread(Consumer);

            producer.Start();
            consumer.Start();

            producer.Join();
            consumer.Join();
        }

        // Phương thức tạo dữ liệu
        static void Producer()
        {
            for (int i = 0; i < 10; i++)
            {
                lock (lockObject)
                {
                    // Cập nhật dữ liệu
                    shareData = i;
                    isDataAvailable = true;

                    // Thông báo cho consumer thread rằng dữ liệu mới đã sẵn sàng
                    Monitor.Pulse(lockObject);
                }

                // Giả lập thời gian chờ
                Thread.Sleep(500);
            }
        }

        // Phương thức tiêu thụ dữ liệu
        static void Consumer()
        {
            while (true)
            {
                lock (lockObject)
                {
                    // Đợi cho đến khi có dữ liệu mới
                    while (!isDataAvailable)
                    {
                        Monitor.Wait(lockObject);
                    }

                    // In dữ liệu ra màn hình
                    Console.WriteLine("Dữ liệu được tiêu thụ: " + shareData);
                    isDataAvailable = false;

                    // Nếu dữ liệu đạt đến giá trị 5, thoát khỏi vòng lặp
                    if (shareData == 5)
                    {
                        break;
                    }
                }
            }
        }
    }
}
