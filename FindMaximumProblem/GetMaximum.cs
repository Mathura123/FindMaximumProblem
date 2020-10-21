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
    }
}
