using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPI_C__Session10
{
    public class FixedSizeList<T>
    {
        private T[] _items;
        private int _count;

        public FixedSizeList(int capacity)
        {
            if (capacity <= 0)
                throw new ArgumentException("Capacity must be greater than 0.");

            _items = new T[capacity];
            _count = 0;
        }

        public void Add(T item)
        {
            if (_count >= _items.Length)
                throw new InvalidOperationException("The list is full.");

            _items[_count] = item;
            _count++;
        }

        public T Get(int index)
        {
            if (index < 0 || index >= _count)
                throw new IndexOutOfRangeException("Invalid index.");

            return _items[index];
        }
    }
}
