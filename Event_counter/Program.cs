using System;
using System.Text;

namespace EventCounter
{
    

    public class Counter
    {
        // Event that is triggered when the threshold is reached
        public event EventHandler ThresholdReached;

        private int count = 0;
        private int threshold;

        // Constructor that sets the threshold
        public Counter(int threshold)
        {
            this.threshold = threshold;
        }

        // Method to add value to the counter
        public void Add(int value)
        {
            count += value;
            if (count >= threshold)
            {
                ThresholdReached?.Invoke(this,EventArgs.Empty); // Trigger the event if threshold is reached
            }
        }
    }

    internal class Program
    {
        // Event handler method
        static void OnThresholdReached(object a,EventArgs e)
        {
            Console.WriteLine("Threshold reached!");
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode; // Ensure proper encoding for any Unicode text
            Counter counter = new Counter(10);

            // Register the event handler
            counter.ThresholdReached += OnThresholdReached;

            Console.WriteLine("Starting count:");

            // Loop to add values to the counter
            for (int i = 1; i <= 10; i++)
            {
                counter.Add(1);
                Console.WriteLine("Current value: " + i);
            }

            Console.WriteLine("Counting finished.");
        }
    }
}
