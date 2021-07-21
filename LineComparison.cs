using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparisonComputation
{
    class LineComparison
    {
        // variables
        double pointX1;
        double pointY1;
        double pointX2;
        double pointY2;
        double pointX3;
        double pointY3;
        double pointX4;
        double pointY4;

        public LineComparison(double pointX1, double pointY1, double pointX2, double pointY2,
                                double pointX3, double pointY3, double pointX4, double pointY4) 
        {
            this.pointX1 = pointX1;
            this.pointY1 = pointY1;
            this.pointX2 = pointX2;
            this.pointY2 = pointY2;
            this.pointX3 = pointX3;
            this.pointY3 = pointY3;
            this.pointX4 = pointX4;
            this.pointY4 = pointY4;
        }

        /// <summary>
        /// This method is used to check which line is greater, less or both lines are equal.
        /// </summary>
        public void length() 
        {
            // variables
            double distance1;
            double distance2;

            // length of first line
            distance1 = Math.Sqrt((pointX2 - pointX1) * (pointX2 - pointX1) + (pointY2 - pointY1) * (pointY2 - pointY1));
            Console.WriteLine("Length of a line:" +distance1);
            // length of first line
            distance2 = Math.Sqrt((pointX4 - pointX3) * (pointX4 - pointX3) + (pointY4 - pointY3) * (pointY4 - pointY3));
            Console.WriteLine("Length of a line:" + distance2);

            // comparing two lines
            if (distance1.CompareTo(distance2) > 0)
                Console.WriteLine("The length of first line is greater than second line.");
            else if (distance1.CompareTo(distance2) < 0)
                Console.WriteLine("The length of first line is less than second line.");
            else
                Console.WriteLine("Both the lines are equal.");

        }
    }
}
