using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КурсоваяРабота
{
    class RangeArrayException:ApplicationException
    {
        public RangeArrayException() : base() { }
        public RangeArrayException(string str) : base(str) { }
        public override string ToString()
        {
            return Message;
        }
    }
}
