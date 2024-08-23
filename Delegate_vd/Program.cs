using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_vd
{
    public delegate void stringDeeagte(string name);
    class program
    {
        static void main(string[] ags)
        {
            Hocsinh hs = new Hocsinh();
            hs.NameChanged += Hs_NameChanged;
            hs.Name = "Nguyen";
            hs.Name = "Van";
        }

        private static void Hs_NameChanged(string name)
        {
            Console.WriteLine("Ten da thay doi "+ name);
        }
    }
    class Hocsinh
    {
       public event stringDeeagte NameChanged;
        private string _Name;
        public string Name
        {
            get => _Name;
            set
            {
                _Name = value;
                if (NameChanged != null)
                {
                
                    NameChanged(value);
                }
            }
        }
    }
}
