using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_C_
{
    internal class FixedSizeList<T>
    {
        List<T> list;

        public FixedSizeList(int C)
        {
            list = new List<T>();
            list.Capacity = C;
        }

        public void Add(T item)
        {
            if (list.Count < list.Capacity)
                list.Add(item);
            else
                Console.WriteLine("\nthe list is already full.\n");
        }
        public T GetValue(int index)
        {
            if (index < 0 || index >= list.Count)
            {
                throw new IndexOutOfRangeException();
            }
            else
            return list[index];
        }
    }
}
