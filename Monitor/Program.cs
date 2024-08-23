using System;
using System.Text;
using System.Threading;

class Program
{
    // Biến dùng chung để lưu dữ liệu
    static int sharedData = 0;

    // Đối tượng khóa để đồng bộ hóa
    static readonly object lockObject = new object();

    // Cờ để kiểm tra xem có dữ liệu mới không
    static bool isDataAvailable = false;

    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.Unicode;
        // Tạo thread cho việc tạo dữ liệu (producer) và tiêu thụ dữ liệu (consumer)
        Thread producerThread = new Thread(ProduceData);
        Thread consumerThread = new Thread(ConsumeData);

        // Khởi chạy hai thread
        producerThread.Start();
        consumerThread.Start();     

        // Chờ cả hai thread hoàn thành
        producerThread.Join();
        consumerThread.Join();
    }

    // Phương thức tạo dữ liệu
    static void ProduceData()
    {
        for (int i = 1; i <= 10; i++)
        {
            // Khóa để đảm bảo chỉ một thread truy cập vào đoạn mã này
            lock (lockObject)
            {
                // Tăng giá trị của dữ liệu
                sharedData = i;

                // Đặt cờ là true để báo rằng dữ liệu mới đã sẵn sàng
                isDataAvailable = true;

                // Báo cho thread tiêu thụ rằng dữ liệu mới đã sẵn sàng
                Monitor.Pulse(lockObject);
            }

            // Giả lập thời gian tạo dữ liệu
            Thread.Sleep(500);
        }
    }

    // Phương thức tiêu thụ dữ liệu
    static void ConsumeData()
    {
        while (true)
        {
            // Khóa để đảm bảo chỉ một thread truy cập vào đoạn mã này
            lock (lockObject)
            {
                // Đợi cho đến khi có dữ liệu mới
                while (!isDataAvailable)
                {
                    Monitor.Wait(lockObject);
                }

                // In dữ liệu ra màn hình
                Console.WriteLine($"Dữ liệu tiêu thụ: {sharedData}");

                // Đặt lại cờ để báo rằng dữ liệu đã được tiêu thụ
                isDataAvailable = false;

                // Nếu dữ liệu đã đạt giá trị cuối cùng, thoát khỏi vòng lặp
                if (sharedData == 10)
                {
                    break;
                }
            }
        }
    }
}
