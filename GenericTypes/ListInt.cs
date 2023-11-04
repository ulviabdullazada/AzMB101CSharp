namespace GenericTypes
{
    internal class ListInt
    {
        int[] _arr = new int[0];
        public ListInt(params int[] arr)
        {
            _arr = arr;
        }
        public void Add(int num)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[^1] = num;
        }
        public bool Contains(int num)
        {
            foreach (int i in _arr)
            {
                if (i == num)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
