using System;
using System.Collections.Generic;
using System.Text;
namespace FindMaximumProblem
{
    public class GetMaximum<T> where T: IComparable
    {
        private T firstValue;
        private T secondValue;
        private T thirdValue;
        public GetMaximum(T firstValue,T secondValue, T thirdValue)
        {
            this.firstValue = firstValue;
            this.secondValue = secondValue;
            this.thirdValue = thirdValue;
        }
        public T GetMaxValue()
        {
            if (firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue) >= 0)
                return firstValue;
            else if (secondValue.CompareTo(firstValue) >= 0 && secondValue.CompareTo(thirdValue) >= 0)
                return secondValue;
            else
                return thirdValue;
        }
    }
}
