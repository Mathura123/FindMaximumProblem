using System;
using System.Collections.Generic;
using System.Text;
namespace FindMaximumProblem
{
    public class GetMaximum
    {
        public int GetMaxInt(int firstInt, int secondInt, int thirdInt)
        {
            if (firstInt.CompareTo(secondInt) >= 0 && firstInt.CompareTo(thirdInt) >= 0)
                return firstInt;
            else if (secondInt.CompareTo(firstInt) >= 0 && secondInt.CompareTo(thirdInt) >= 0)
                return secondInt;
            else
                return thirdInt;
        }
        public double GetMaxFloat(double firstFloat, double secondFloat, double thirdFloat)
        {
            if (firstFloat.CompareTo(secondFloat) >= 0 && firstFloat.CompareTo(thirdFloat) >= 0)
                return firstFloat;
            else if (secondFloat.CompareTo(firstFloat) >= 0 && secondFloat.CompareTo(thirdFloat) >= 0)
                return secondFloat;
            else
                return thirdFloat;
        }
        public string GetMaxString(string firstString, string secondString, string thirdString)
        {
            if (firstString.CompareTo(secondString) >= 0 && firstString.CompareTo(thirdString) >= 0)
                return firstString;
            else if (secondString.CompareTo(firstString) >= 0 && secondString.CompareTo(thirdString) >= 0)
                return secondString;
            else
                return thirdString;
        }
        public T GetMaxValue<T>(T firstValue, T secondValue, T thirdValue) where T : IComparable
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
