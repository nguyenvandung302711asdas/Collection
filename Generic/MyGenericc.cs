using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    internal class MyGenericc<T>
    {
        private T[] items;
        public T[] Items
        { get { return items; } }

        public MyGenericc(int size)
        {
            items = new T[size];
        }

        public T getIndex(int index)
        {
            if(index < 0 || index >= items.Length)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                return items[index];
            }
        }
        public void setIntems(int index , T Value)
        {
            if(index < 0 || index >= items.Length)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                items[index] = Value;
            }
        }

    }
}
