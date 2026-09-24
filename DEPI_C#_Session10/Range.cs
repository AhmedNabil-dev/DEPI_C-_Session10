using System;
using System.Numerics;
using System.Reflection;

namespace DEPI_C__Session10.Session10
{
    public class Range<T> where T : IComparable<T>, INumber<T>
    {
        public T Minimum { get; }
        public T Maximum { get; }

        public Range(T minimum, T maximum)
        {
            Minimum = minimum;
            Maximum = maximum;
        }

        public bool IsInRange(T value)
        {
            return value.CompareTo(Minimum) >= 0 &&
                   value.CompareTo(Maximum) <= 0;
        }

        public int Length()
        {
            PropertyInfo? minimumProperty =
                typeof(Range<T>).GetProperty(nameof(Minimum));

            PropertyInfo? maximumProperty =
                typeof(Range<T>).GetProperty(nameof(Maximum));

            T minimum = (T)minimumProperty!.GetValue(this)!;
            T maximum = (T)maximumProperty!.GetValue(this)!;

            return Convert.ToInt32(maximum - minimum);
        }
    }
}