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
    }
}
