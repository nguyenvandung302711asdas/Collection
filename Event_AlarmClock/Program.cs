using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Event_AlarmClock
{
    public class AlarmClock
    {
        public event EventHandler AlarmRings;
        private Timer timer;

        public AlarmClock(int seconds)
        {
            timer = new Timer(seconds *1000 );
            timer.Elapsed += OntimeEvent;
            timer.AutoReset = false;
        }
        private void OntimeEvent(object sender, EventArgs e)
        {
            AlarmRings?.Invoke(this, EventArgs.Empty);
        }
        public void Start()
        {
            Console.WriteLine("Báo thức đã được đặt");
            timer.Start();
        }


    }

    internal class Program
    {
        static void OnAlarmRings(object sender, EventArgs e)
        {
            Console.WriteLine("Báo thức đã kêu rồi!");
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            AlarmClock al = new AlarmClock(5);
            al.AlarmRings += OnAlarmRings;
            al.Start();
            Console.WriteLine("Chờ báo thức");
            Console.ReadLine();

        }
        
    }
}
