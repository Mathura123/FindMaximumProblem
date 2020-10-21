using System;

namespace FindMaximumProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Find Maximum Problem");
            GetMaximum getMaxObj = new GetMaximum();
            Console.WriteLine(getMaxObj.GetMaxFloat(50.2, 45.101, 84.45));
        }
    }
}
