using System.Text;
using System;

namespace Event_Voi_Delegate
{
    class Button
    {
        public delegate void ClickEventHandler(object sender, EventArgs e);
        //khai bao su kien
        public event ClickEventHandler Click;
        //phuong thu de kich hoat su kien
        public void Onclick()
        {
            if (Click != null)
            {
               Click(this, EventArgs.Empty);
            }
        }
    }

    class Handler
    {
        public void Hnanler(object sender, EventArgs e)
        {
            Console.WriteLine("Button was clicked");
        }
    }

    class Program
    {
        static void Main(string[] ags)
        {
            Button button = new Button();
            Handler handler = new Handler();

            button.Click += handler.Hnanler;
            button.Onclick();
            Console.ReadLine();
        }
    }

}
