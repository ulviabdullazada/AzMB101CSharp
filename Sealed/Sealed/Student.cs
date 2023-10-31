using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed
{
    internal sealed class Student : Person
    {
        public sealed override string GetFullInfo()
        {
            return base.GetFullInfo() + "Telebe";
        }
    }
}
