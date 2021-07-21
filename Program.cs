using System;

namespace LineComparisonComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            LineComparison lineComparison = new LineComparison(1.2,2.3,4.5,3.2,3.4,2.6,5.2,6.1);
            lineComparison.length();
        }
    }
}
