using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Markup;

namespace FindMaximumProblem
{
    public class GetMaximum<T> where T : IComparable
    {
        private T[] values;
        public GetMaximum(T[] values)
        {
            this.values = values;
        }
        private T[] SortValues(T[] values)
        {
            Array.Sort(values);
            return values;
        }
        public T GetMaxValue()
        {
            T[] sortedValues = SortValues(values);
            return sortedValues[sortedValues.Length - 1];
        }
    }
}
