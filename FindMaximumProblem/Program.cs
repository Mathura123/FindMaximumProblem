using System;

namespace FindMaximumProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Find Maximum Problem");
            GetMaximum getMaxObj = new GetMaximum();
            Console.WriteLine(getMaxObj.GetMaxValue(4,5.01,45.1));
        }
    }
}
