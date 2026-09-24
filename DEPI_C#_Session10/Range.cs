using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DEPI_C__Session10
{
    using System;
    using System.Numerics;

    namespace Session10
    {
        public class Range<T> where T : IComparable<T>, INumber<T>
        {
            public T Minimum { get;  }
            public T Maximum { get;  }

            private int _Size;

           
            public Range(T minimum, T maximum)
            {
                Minimum = minimum;
                Maximum = maximum;

                _Size = Convert.ToInt32( Maximum - Minimum);
            }

           
            public bool IsInRange(T value)
            {
                return value.CompareTo(Minimum) >= 0 &&
                       value.CompareTo(Maximum) <= 0;
            }

            
            public int Length()
            {
                return _Size;
            }
        }
    }
}
