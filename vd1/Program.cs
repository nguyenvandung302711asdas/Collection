using System;
using System.Text;

namespace Vd1
{
    public delegate void stringDelegate(string name);

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Hocsinh hs = new Hocsinh();
            hs.NameChanged += Hs_NameChanged;
            hs.Name = "Nguyen";
            hs.Name = "Van";
        }

        private static void Hs_NameChanged(string name)
        {
            Console.WriteLine("Tên đã thay đổi: " + name);
        }
    }

    class Hocsinh
    {
        public event stringDelegate NameChanged;
        private string _name;

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                NameChanged?.Invoke(value);
            }
        }
    }
}
