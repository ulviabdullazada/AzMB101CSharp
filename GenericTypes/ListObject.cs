using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypes
{
    internal class ListObject
    {
        object[] _arr = new object[0];
        public ListObject(params object[] arr)
        {
            _arr = arr;
        }
        public void Add(object num)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[^1] = num;
        }
        public bool Contains(object num)
        {
            foreach (object i in _arr)
            {
                if (i.Equals(num))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
