using System.Collections;

namespace GenericTypes
{
    internal class CustomList<T>
    {
        T[] _arr = new T[0];
        public int Count { get; private set; } = 0;
        public int Capacity { get; } = 5;
        public CustomList()
        {
            
        }
        public CustomList(int capacity)
        {
            Capacity = capacity <= 0 ? 5 : capacity;
        }
        public CustomList(int capacity, params T[] arr) : this(capacity)
        {
            _arr = arr;
            Count = arr.Length;
        }
        public void Add(T num)
        {
            if (Count == _arr.Length)
            {
                Array.Resize(ref _arr, Count + Capacity);
            }
            _arr[Count++] = num;
        }
        public bool Contains(T num)
        {
            foreach (T i in _arr)
            {
                if (i.Equals(num))
                {
                    return true;
                }
            }
            return false;
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index>= Count)
                    throw new IndexOutOfRangeException();
                return _arr[index];
            }
        }
    }
}
