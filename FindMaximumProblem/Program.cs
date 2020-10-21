using System;

namespace FindMaximumProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Find Maximum Problem");
            GetMaximum<double> getMaxObj = new GetMaximum<double>(2, 45.89, 4.8);
            Console.WriteLine(getMaxObj.GetMaxValue());
        }
    }
}
