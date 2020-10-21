using System;

namespace FindMaximumProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Find Maximum Problem");
            double[] input = { 2.4, 4.3, 5.6 ,5.4,8.46,782.08};
            GetMaximum<double> getMaxObj = new GetMaximum<double>(input);
            Console.WriteLine(getMaxObj.GetMaxValue());
        }
    }
}
