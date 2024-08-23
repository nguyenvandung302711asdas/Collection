using System;
using System.Security.Authentication.ExtendedProtection;
using System.Text;

namespace ev_vd
{
    class Program
    {
        static int count = 0;
       static void Main(string[] args)
        {
            Hocsinh hs = new Hocsinh();
            hs.NameChanged += Hs_NameChanged;
            hs.Name = "Nguyen";
            hs.Name = "Van";
            hs.Name = "Dung";
        }

        private static void Hs_NameChanged(object sender, changedName e)
        {
            count++;
            Console.WriteLine("Ten da thay doi lan: "+count+" la "+ e.Name );
            
        }
    }
    class Hocsinh
    {
        private string _Name;
        public string Name
        {
            get => _Name;
            set
            {
                if (_Name != value)
                {
                    _Name = value;
                    OnNameChanged(value);
                }
            }
        }

        private event EventHandler<changedName> _NameChanged;
        public event EventHandler<changedName> NameChanged
        {
            add
            {
                _NameChanged += value;
            }
            remove
            {
                _NameChanged -= value;
            }   
        }
        void OnNameChanged(string name)
        {
            if(_NameChanged != null)
            {
                _NameChanged(this, new changedName(name));
            }
        }
    }

    class changedName : EventArgs
    {
        public string Name { get; set;}
        public changedName(string name)
        {
            Name = name;
        }
    }
}
