namespace GenericTypes
{
    internal class ListString
    {
        string[] _arr = new string[0];
        public ListString(params string[] arr)
        {
            _arr = arr;
        }
        public void Add(string num)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[^1] = num;
        }
        public bool Contains(string num)
        {
            foreach (string i in _arr)
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
